namespace TaskManager.WinForms.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            btnRefresh = new Button();
            btnAddTask = new Button();
            splitMain = new SplitContainer();
            panel1 = new Panel();
            lblTaskList = new Label();
            dgvTasks = new DataGridView();
            colTaskId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            txtDescription = new TextBox();
            dtEnd = new DateTimePicker();
            dtStart = new DateTimePicker();
            cmbStatus = new ComboBox();
            cmbCategory = new ComboBox();
            txtTitle = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            lblDescription = new Label();
            lblEndDate = new Label();
            lblStartDate = new Label();
            lblStatus = new Label();
            lblCategory = new Label();
            lblTitle = new Label();
            lblTaskDetails = new Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnRefresh);
            panelTop.Controls.Add(btnAddTask);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1021, 115);
            panelTop.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(173, 58);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(42, 58);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(112, 34);
            btnAddTask.TabIndex = 0;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 115);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(panel1);
            splitMain.Panel1.Controls.Add(dgvTasks);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(txtDescription);
            splitMain.Panel2.Controls.Add(dtEnd);
            splitMain.Panel2.Controls.Add(dtStart);
            splitMain.Panel2.Controls.Add(cmbStatus);
            splitMain.Panel2.Controls.Add(cmbCategory);
            splitMain.Panel2.Controls.Add(txtTitle);
            splitMain.Panel2.Controls.Add(btnDelete);
            splitMain.Panel2.Controls.Add(btnUpdate);
            splitMain.Panel2.Controls.Add(lblDescription);
            splitMain.Panel2.Controls.Add(lblEndDate);
            splitMain.Panel2.Controls.Add(lblStartDate);
            splitMain.Panel2.Controls.Add(lblStatus);
            splitMain.Panel2.Controls.Add(lblCategory);
            splitMain.Panel2.Controls.Add(lblTitle);
            splitMain.Panel2.Controls.Add(lblTaskDetails);
            splitMain.Size = new Size(1021, 502);
            splitMain.SplitterDistance = 399;
            splitMain.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTaskList);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 67);
            panel1.TabIndex = 1;
            // 
            // lblTaskList
            // 
            lblTaskList.AutoSize = true;
            lblTaskList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaskList.Location = new Point(141, 21);
            lblTaskList.Name = "lblTaskList";
            lblTaskList.Size = new Size(109, 32);
            lblTaskList.TabIndex = 0;
            lblTaskList.Text = "Task List";
            // 
            // dgvTasks
            // 
            dgvTasks.AllowUserToAddRows = false;
            dgvTasks.AllowUserToDeleteRows = false;
            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Columns.AddRange(new DataGridViewColumn[] { colTaskId, colTitle, colCategory, colStatus, colDescription });
            dgvTasks.Dock = DockStyle.Bottom;
            dgvTasks.Location = new Point(0, 66);
            dgvTasks.MultiSelect = false;
            dgvTasks.Name = "dgvTasks";
            dgvTasks.ReadOnly = true;
            dgvTasks.RowHeadersVisible = false;
            dgvTasks.RowHeadersWidth = 62;
            dgvTasks.ScrollBars = ScrollBars.None;
            dgvTasks.Size = new Size(399, 436);
            dgvTasks.TabIndex = 0;
            dgvTasks.SelectionChanged += dgvTasks_SelectionChanged;
            // 
            // colTaskId
            // 
            colTaskId.HeaderText = "TaskId";
            colTaskId.MinimumWidth = 8;
            colTaskId.Name = "colTaskId";
            colTaskId.ReadOnly = true;
            colTaskId.Visible = false;
            // 
            // colTitle
            // 
            colTitle.HeaderText = "Title";
            colTitle.MinimumWidth = 8;
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 8;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colDescription
            // 
            colDescription.HeaderText = "Description";
            colDescription.MinimumWidth = 8;
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            colDescription.Visible = false;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(218, 351);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(325, 31);
            txtDescription.TabIndex = 14;
            // 
            // dtEnd
            // 
            dtEnd.Location = new Point(218, 290);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(317, 31);
            dtEnd.TabIndex = 13;
            // 
            // dtStart
            // 
            dtStart.Location = new Point(218, 233);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(317, 31);
            dtStart.TabIndex = 12;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(218, 178);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(325, 33);
            cmbStatus.TabIndex = 11;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(218, 124);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(325, 33);
            cmbCategory.TabIndex = 10;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(218, 73);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(325, 31);
            txtTitle.TabIndex = 9;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(218, 406);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(66, 406);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(66, 351);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(109, 25);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndDate.Location = new Point(66, 290);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(89, 25);
            lblEndDate.TabIndex = 5;
            lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartDate.Location = new Point(66, 233);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(99, 25);
            lblStartDate.TabIndex = 4;
            lblStartDate.Text = "Start Date";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(66, 178);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(65, 25);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(66, 124);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(90, 25);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(66, 73);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(50, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            // 
            // lblTaskDetails
            // 
            lblTaskDetails.AutoSize = true;
            lblTaskDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaskDetails.Location = new Point(246, 21);
            lblTaskDetails.Name = "lblTaskDetails";
            lblTaskDetails.Size = new Size(148, 32);
            lblTaskDetails.TabIndex = 0;
            lblTaskDetails.Text = "Task Details";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 617);
            Controls.Add(splitMain);
            Controls.Add(panelTop);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panelTop.ResumeLayout(false);
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            splitMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button btnRefresh;
        private Button btnAddTask;
        private SplitContainer splitMain;
        private DataGridView dgvTasks;
        private DataGridViewTextBoxColumn colTaskId;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colDescription;
        private Panel panel1;
        private Label lblTaskDetails;
        private Label lblTaskList;
        private Button btnDelete;
        private Button btnUpdate;
        private Label lblDescription;
        private Label lblEndDate;
        private Label lblStartDate;
        private Label lblStatus;
        private Label lblCategory;
        private Label lblTitle;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private DateTimePicker dtEnd;
        private DateTimePicker dtStart;
        private ComboBox cmbStatus;
        private ComboBox cmbCategory;
    }
}