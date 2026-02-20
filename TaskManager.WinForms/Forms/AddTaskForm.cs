using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskManager.Models.DTOs;
using TaskManager.Models.Entities;
using TaskManager.WinForms.Services;

namespace TaskManager.WinForms.Forms
{
    public partial class AddTaskForm : Form
    {
        private readonly TaskApiService _taskApiService = new TaskApiService();
        private Guid _userId;
        private MainForm _mainForm;
        public AddTaskForm(Guid userId, MainForm mainForm)
        {
            InitializeComponent();
            _userId = userId;
            _mainForm = mainForm;
        }

        private async void btnAddTask_Click(object sender, EventArgs e)
        {
            int categoryId;

            if (cmbCategory.SelectedItem is Category selectedCategory)
            {
                categoryId = selectedCategory.CategoryId;
            }
            else
            {
                var newCategory =
                    await _taskApiService.CreateCategory(
                        cmbCategory.Text,
                        _userId);

                categoryId = newCategory.CategoryId;
            }

            var dto = new CreateTaskDto
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                StartDate = dtStart.Value,
                EndDate = dtEnd.Value,
                StatusId = (int)cmbStatus.SelectedValue,
                CategoryId = categoryId,
                UserId = _userId
            };

            var success = await _taskApiService.AddTask(dto);

            if (success)
            {
                MessageBox.Show("Task added!");
                await _mainForm.LoadTasks();
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            this.Close();
        }

        private async Task LoadLookups()
        {
            var categories = await _taskApiService.GetCategories(_userId);
            var statuses = await _taskApiService.GetStatuses();

            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";

            cmbStatus.DataSource = statuses;
            cmbStatus.DisplayMember = "StatusName";
            cmbStatus.ValueMember = "StatusId";
        }

        private async void AddTaskForm_Load(object sender, EventArgs e)
        {
            await LoadLookups();
        }
    }
}
