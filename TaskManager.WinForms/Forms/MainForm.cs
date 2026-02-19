using TaskManager.Models.DTOs;
using TaskManager.WinForms.Services;

namespace TaskManager.WinForms.Forms
{
    public partial class MainForm : Form
    {
        private readonly TaskApiService _taskApiService = new TaskApiService();
        private Guid _loggedInUserId;
        private Guid _selectedTaskId;
        public MainForm(Guid userId)
        {
            InitializeComponent();
            _loggedInUserId = userId;
        }

        private async Task LoadTasks()
        {
            var tasks = await _taskApiService.GetUserTasks(_loggedInUserId);
            dgvTasks.Rows.Clear();
            foreach (var task in tasks)
            {
                dgvTasks.Rows.Add(
                    task.TaskId,
                    task.Title,
                    task.Category,
                    task.Status
                );
            }
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await LoadTasks();
        }

        private void dgvTasks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow == null) return;

            _selectedTaskId =
                Guid.Parse(dgvTasks.CurrentRow.Cells["colTaskId"].Value.ToString());

            txtTitle.Text =
                dgvTasks.CurrentRow.Cells["colTitle"].Value.ToString();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var success = await _taskApiService.DeleteTask(_selectedTaskId);
            if (success)
                await LoadTasks();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var dto = new UpdateTaskDto
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                StartDate = dtStart.Value,
                EndDate = dtEnd.Value,
                StatusId = (int)cmbStatus.SelectedValue,
                CategoryId = (int)cmbCategory.SelectedValue,
            };

            var success = await _taskApiService.UpdateTask(_selectedTaskId, dto);

            if (success)
                await LoadTasks();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var form = new AddTaskForm(_loggedInUserId, this);
            form.ShowDialog();
        }
    }
}
