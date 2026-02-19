using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskManager.Models.DTOs;
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
            var dto = new CreateTaskDto
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                StartDate = dtStart.Value,
                EndDate = dtEnd.Value,
                StatusId = (int)cmbStatus.SelectedValue,
                CategoryId = (int)cmbCategory.SelectedValue,
                UserId = _userId
            };

            var success = await _taskApiService.AddTask(dto);

            if (success)
            {
                MessageBox.Show("Task added!");
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            this.Close();
        }
    }
}
