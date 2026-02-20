using TaskManager.Models.DTOs;
using TaskManager.WinForms.Services;

namespace TaskManager.WinForms.Forms
{
    public partial class MainForm : Form
    {
        private readonly TaskApiService _taskApiService = new TaskApiService();
        private Guid _loggedInUserId;
        private Guid _selectedTaskId;
        private TaskListDto _selectedTask;

        public MainForm(Guid userId)
        {
            InitializeComponent();
            _loggedInUserId = userId;
        }

        public async Task LoadTasks()
        {
            var tasks = await _taskApiService.GetUserTasks(_loggedInUserId);

            dgvTasks.Rows.Clear();

            foreach (var task in tasks)
            {
                int rowIndex = dgvTasks.Rows.Add(
                    task.TaskId,
                    task.Title,
                    task.Category,
                    task.Status
                );

                dgvTasks.Rows[rowIndex].Tag = task;
            }
        }

        private async Task LoadLookups()
        {
            var categories = await _taskApiService.GetCategories(_loggedInUserId);
            var statuses = await _taskApiService.GetStatuses();

            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";

            cmbStatus.DataSource = statuses;
            cmbStatus.DisplayMember = "StatusName";
            cmbStatus.ValueMember = "StatusId";
        }


        private async void MainForm_Load(object sender, EventArgs e)
        {
            await LoadLookups();
            await LoadTasks();
        }

        private void dgvTasks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow == null) return;

            _selectedTask =
                dgvTasks.CurrentRow.Tag as TaskListDto;

            if (_selectedTask == null)
                return;

            _selectedTaskId = _selectedTask.TaskId;

            txtTitle.Text = _selectedTask.Title;
            txtDescription.Text = _selectedTask.Description;

            cmbCategory.SelectedValue = _selectedTask.CategoryId;
            cmbStatus.SelectedValue = _selectedTask.StatusId;

            dtStart.Value = _selectedTask.StartDate;
            dtEnd.Value = _selectedTask.EndDate;
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
                TaskId = _selectedTaskId,
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
