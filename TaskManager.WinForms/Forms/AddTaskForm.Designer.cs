namespace TaskManager.WinForms.Forms
{
    partial class AddTaskForm
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
            pnlTop = new Panel();
            btnBack = new Button();
            lblAddTask = new Label();
            txtDescription = new TextBox();
            dtEnd = new DateTimePicker();
            dtStart = new DateTimePicker();
            cmbStatus = new ComboBox();
            cmbCategory = new ComboBox();
            txtTitle = new TextBox();
            lblDescription = new Label();
            lblEndDate = new Label();
            lblStartDate = new Label();
            lblStatus = new Label();
            lblCategory = new Label();
            lblTitle = new Label();
            btnAddTask = new Button();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(btnBack);
            pnlTop.Controls.Add(lblAddTask);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(596, 118);
            pnlTop.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(45, 52);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblAddTask
            // 
            lblAddTask.AutoSize = true;
            lblAddTask.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddTask.Location = new Point(210, 52);
            lblAddTask.Name = "lblAddTask";
            lblAddTask.Size = new Size(175, 32);
            lblAddTask.TabIndex = 0;
            lblAddTask.Text = "Add New Task";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(210, 443);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(325, 31);
            txtDescription.TabIndex = 26;
            // 
            // dtEnd
            // 
            dtEnd.Location = new Point(210, 382);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(317, 31);
            dtEnd.TabIndex = 25;
            // 
            // dtStart
            // 
            dtStart.Location = new Point(210, 325);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(317, 31);
            dtStart.TabIndex = 24;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(210, 270);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(325, 33);
            cmbStatus.TabIndex = 23;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(210, 216);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(325, 33);
            cmbCategory.TabIndex = 22;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(210, 165);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(325, 31);
            txtTitle.TabIndex = 21;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(58, 443);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(109, 25);
            lblDescription.TabIndex = 20;
            lblDescription.Text = "Description";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndDate.Location = new Point(58, 382);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(89, 25);
            lblEndDate.TabIndex = 19;
            lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartDate.Location = new Point(58, 325);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(99, 25);
            lblStartDate.TabIndex = 18;
            lblStartDate.Text = "Start Date";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(58, 270);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(65, 25);
            lblStatus.TabIndex = 17;
            lblStatus.Text = "Status";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(58, 216);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(90, 25);
            lblCategory.TabIndex = 16;
            lblCategory.Text = "Category";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(58, 165);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(50, 25);
            lblTitle.TabIndex = 15;
            lblTitle.Text = "Title";
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(249, 509);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(112, 34);
            btnAddTask.TabIndex = 27;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 598);
            Controls.Add(btnAddTask);
            Controls.Add(txtDescription);
            Controls.Add(dtEnd);
            Controls.Add(dtStart);
            Controls.Add(cmbStatus);
            Controls.Add(cmbCategory);
            Controls.Add(txtTitle);
            Controls.Add(lblDescription);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(lblStatus);
            Controls.Add(lblCategory);
            Controls.Add(lblTitle);
            Controls.Add(pnlTop);
            Name = "AddTaskForm";
            Text = "AddTaskForm";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTop;
        private Label lblAddTask;
        private TextBox txtDescription;
        private DateTimePicker dtEnd;
        private DateTimePicker dtStart;
        private ComboBox cmbStatus;
        private ComboBox cmbCategory;
        private TextBox txtTitle;
        private Label lblDescription;
        private Label lblEndDate;
        private Label lblStartDate;
        private Label lblStatus;
        private Label lblCategory;
        private Label lblTitle;
        private Button btnAddTask;
        private Button btnBack;
    }
}