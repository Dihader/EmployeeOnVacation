namespace EmployeeOnVacation
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxRequestForVacation = new System.Windows.Forms.GroupBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLinkSickList = new System.Windows.Forms.TextBox();
            this.lblSickList = new System.Windows.Forms.Label();
            this.ckbxConfirm = new System.Windows.Forms.CheckBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpEndVacation = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStartVacation = new System.Windows.Forms.DateTimePicker();
            this.btnCreateRequest = new System.Windows.Forms.Button();
            this.cbxVacationTypes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMidleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEmployeesSurname = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbxListVacations = new System.Windows.Forms.ListBox();
            this.txtCommentForThisEmployee = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpEndDateForThisEmployee = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpStartDateForThisEmployee = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxSurnamesForSearch = new System.Windows.Forms.ComboBox();
            this.btnGetAllVacations = new System.Windows.Forms.Button();
            this.gbxRequestForVacation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxRequestForVacation
            // 
            this.gbxRequestForVacation.Controls.Add(this.txtComment);
            this.gbxRequestForVacation.Controls.Add(this.label8);
            this.gbxRequestForVacation.Controls.Add(this.txtLinkSickList);
            this.gbxRequestForVacation.Controls.Add(this.lblSickList);
            this.gbxRequestForVacation.Controls.Add(this.ckbxConfirm);
            this.gbxRequestForVacation.Controls.Add(this.txtSalary);
            this.gbxRequestForVacation.Controls.Add(this.label7);
            this.gbxRequestForVacation.Controls.Add(this.dtpEndVacation);
            this.gbxRequestForVacation.Controls.Add(this.label6);
            this.gbxRequestForVacation.Controls.Add(this.label5);
            this.gbxRequestForVacation.Controls.Add(this.dtpStartVacation);
            this.gbxRequestForVacation.Controls.Add(this.btnCreateRequest);
            this.gbxRequestForVacation.Controls.Add(this.cbxVacationTypes);
            this.gbxRequestForVacation.Controls.Add(this.label4);
            this.gbxRequestForVacation.Controls.Add(this.txtName);
            this.gbxRequestForVacation.Controls.Add(this.txtMidleName);
            this.gbxRequestForVacation.Controls.Add(this.label3);
            this.gbxRequestForVacation.Controls.Add(this.label2);
            this.gbxRequestForVacation.Controls.Add(this.label1);
            this.gbxRequestForVacation.Controls.Add(this.cbxEmployeesSurname);
            this.gbxRequestForVacation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxRequestForVacation.Location = new System.Drawing.Point(12, 12);
            this.gbxRequestForVacation.Name = "gbxRequestForVacation";
            this.gbxRequestForVacation.Size = new System.Drawing.Size(434, 394);
            this.gbxRequestForVacation.TabIndex = 0;
            this.gbxRequestForVacation.TabStop = false;
            this.gbxRequestForVacation.Text = "Создания заявки на отпуск";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(110, 261);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(316, 26);
            this.txtComment.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Описание";
            // 
            // txtLinkSickList
            // 
            this.txtLinkSickList.Location = new System.Drawing.Point(232, 312);
            this.txtLinkSickList.Name = "txtLinkSickList";
            this.txtLinkSickList.Size = new System.Drawing.Size(194, 26);
            this.txtLinkSickList.TabIndex = 17;
            this.txtLinkSickList.Visible = false;
            // 
            // lblSickList
            // 
            this.lblSickList.AutoSize = true;
            this.lblSickList.Location = new System.Drawing.Point(3, 315);
            this.lblSickList.Name = "lblSickList";
            this.lblSickList.Size = new System.Drawing.Size(225, 20);
            this.lblSickList.TabIndex = 16;
            this.lblSickList.Text = "Ссылка на больничный лист";
            this.lblSickList.Visible = false;
            // 
            // ckbxConfirm
            // 
            this.ckbxConfirm.AutoSize = true;
            this.ckbxConfirm.Location = new System.Drawing.Point(10, 296);
            this.ckbxConfirm.Name = "ckbxConfirm";
            this.ckbxConfirm.Size = new System.Drawing.Size(134, 24);
            this.ckbxConfirm.TabIndex = 15;
            this.ckbxConfirm.Text = "Потвержден?";
            this.ckbxConfirm.UseVisualStyleBackColor = true;
            this.ckbxConfirm.Visible = false;
            // 
            // txtSalary
            // 
            this.txtSalary.Enabled = false;
            this.txtSalary.Location = new System.Drawing.Point(112, 129);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(316, 26);
            this.txtSalary.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Зарплата";
            // 
            // dtpEndVacation
            // 
            this.dtpEndVacation.Location = new System.Drawing.Point(113, 229);
            this.dtpEndVacation.Name = "dtpEndVacation";
            this.dtpEndVacation.Size = new System.Drawing.Size(316, 26);
            this.dtpEndVacation.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Отпуск по";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Отпуск с";
            // 
            // dtpStartVacation
            // 
            this.dtpStartVacation.Location = new System.Drawing.Point(113, 197);
            this.dtpStartVacation.Name = "dtpStartVacation";
            this.dtpStartVacation.Size = new System.Drawing.Size(316, 26);
            this.dtpStartVacation.TabIndex = 9;
            // 
            // btnCreateRequest
            // 
            this.btnCreateRequest.Location = new System.Drawing.Point(9, 346);
            this.btnCreateRequest.Name = "btnCreateRequest";
            this.btnCreateRequest.Size = new System.Drawing.Size(417, 38);
            this.btnCreateRequest.TabIndex = 8;
            this.btnCreateRequest.Text = "Создать заявку";
            this.btnCreateRequest.UseVisualStyleBackColor = true;
            this.btnCreateRequest.Click += new System.EventHandler(this.btnCreateRequest_Click);
            // 
            // cbxVacationTypes
            // 
            this.cbxVacationTypes.FormattingEnabled = true;
            this.cbxVacationTypes.Location = new System.Drawing.Point(113, 163);
            this.cbxVacationTypes.Name = "cbxVacationTypes";
            this.cbxVacationTypes.Size = new System.Drawing.Size(316, 28);
            this.cbxVacationTypes.TabIndex = 7;
            this.cbxVacationTypes.SelectedIndexChanged += new System.EventHandler(this.cbxVacationTypes_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Вид отпуска";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(112, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(316, 26);
            this.txtName.TabIndex = 5;
            // 
            // txtMidleName
            // 
            this.txtMidleName.Enabled = false;
            this.txtMidleName.Location = new System.Drawing.Point(112, 95);
            this.txtMidleName.Name = "txtMidleName";
            this.txtMidleName.Size = new System.Drawing.Size(316, 26);
            this.txtMidleName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилии";
            // 
            // cbxEmployeesSurname
            // 
            this.cbxEmployeesSurname.FormattingEnabled = true;
            this.cbxEmployeesSurname.Location = new System.Drawing.Point(112, 25);
            this.cbxEmployeesSurname.Name = "cbxEmployeesSurname";
            this.cbxEmployeesSurname.Size = new System.Drawing.Size(316, 28);
            this.cbxEmployeesSurname.TabIndex = 0;
            this.cbxEmployeesSurname.SelectedIndexChanged += new System.EventHandler(this.cbxEmployeesSurname_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetAllVacations);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbxListVacations);
            this.groupBox1.Controls.Add(this.txtCommentForThisEmployee);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpEndDateForThisEmployee);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dtpStartDateForThisEmployee);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cbxSurnamesForSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(452, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 394);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Просмотр отпусков";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 40);
            this.label10.TabIndex = 21;
            this.label10.Text = "Список \r\nотпусков";
            // 
            // lbxListVacations
            // 
            this.lbxListVacations.FormattingEnabled = true;
            this.lbxListVacations.HorizontalScrollbar = true;
            this.lbxListVacations.ItemHeight = 20;
            this.lbxListVacations.Location = new System.Drawing.Point(112, 164);
            this.lbxListVacations.Name = "lbxListVacations";
            this.lbxListVacations.Size = new System.Drawing.Size(316, 84);
            this.lbxListVacations.TabIndex = 20;
            this.lbxListVacations.DoubleClick += new System.EventHandler(this.lbxListVacations_DoubleClick);
            // 
            // txtCommentForThisEmployee
            // 
            this.txtCommentForThisEmployee.Enabled = false;
            this.txtCommentForThisEmployee.Location = new System.Drawing.Point(112, 327);
            this.txtCommentForThisEmployee.Name = "txtCommentForThisEmployee";
            this.txtCommentForThisEmployee.Size = new System.Drawing.Size(316, 26);
            this.txtCommentForThisEmployee.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Описание";
            // 
            // dtpEndDateForThisEmployee
            // 
            this.dtpEndDateForThisEmployee.Enabled = false;
            this.dtpEndDateForThisEmployee.Location = new System.Drawing.Point(112, 292);
            this.dtpEndDateForThisEmployee.Name = "dtpEndDateForThisEmployee";
            this.dtpEndDateForThisEmployee.Size = new System.Drawing.Size(316, 26);
            this.dtpEndDateForThisEmployee.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Отпуск по";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 265);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Отпуск с";
            // 
            // dtpStartDateForThisEmployee
            // 
            this.dtpStartDateForThisEmployee.Enabled = false;
            this.dtpStartDateForThisEmployee.Location = new System.Drawing.Point(112, 260);
            this.dtpStartDateForThisEmployee.Name = "dtpStartDateForThisEmployee";
            this.dtpStartDateForThisEmployee.Size = new System.Drawing.Size(316, 26);
            this.dtpStartDateForThisEmployee.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Фамилии";
            // 
            // cbxSurnamesForSearch
            // 
            this.cbxSurnamesForSearch.FormattingEnabled = true;
            this.cbxSurnamesForSearch.Location = new System.Drawing.Point(112, 25);
            this.cbxSurnamesForSearch.Name = "cbxSurnamesForSearch";
            this.cbxSurnamesForSearch.Size = new System.Drawing.Size(312, 28);
            this.cbxSurnamesForSearch.TabIndex = 0;
            // 
            // btnGetAllVacations
            // 
            this.btnGetAllVacations.Location = new System.Drawing.Point(13, 61);
            this.btnGetAllVacations.Name = "btnGetAllVacations";
            this.btnGetAllVacations.Size = new System.Drawing.Size(411, 57);
            this.btnGetAllVacations.TabIndex = 22;
            this.btnGetAllVacations.Text = "Показать отпуска этого сотрудника";
            this.btnGetAllVacations.UseVisualStyleBackColor = true;
            this.btnGetAllVacations.Click += new System.EventHandler(this.btnGetAllVacations_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 411);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxRequestForVacation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отпуска";
            this.gbxRequestForVacation.ResumeLayout(false);
            this.gbxRequestForVacation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRequestForVacation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEmployeesSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMidleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEndVacation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStartVacation;
        private System.Windows.Forms.Button btnCreateRequest;
        private System.Windows.Forms.ComboBox cbxVacationTypes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckbxConfirm;
        private System.Windows.Forms.TextBox txtLinkSickList;
        private System.Windows.Forms.Label lblSickList;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCommentForThisEmployee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpEndDateForThisEmployee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpStartDateForThisEmployee;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbxSurnamesForSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbxListVacations;
        private System.Windows.Forms.Button btnGetAllVacations;
    }
}

