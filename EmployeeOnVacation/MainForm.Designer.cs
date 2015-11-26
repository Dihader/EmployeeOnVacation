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
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxRequestForVacation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxRequestForVacation
            // 
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
            this.gbxRequestForVacation.Size = new System.Drawing.Size(434, 323);
            this.gbxRequestForVacation.TabIndex = 0;
            this.gbxRequestForVacation.TabStop = false;
            this.gbxRequestForVacation.Text = "Создания заявки на отпуск";
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
            this.btnCreateRequest.Location = new System.Drawing.Point(9, 279);
            this.btnCreateRequest.Name = "btnCreateRequest";
            this.btnCreateRequest.Size = new System.Drawing.Size(419, 38);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 457);
            this.Controls.Add(this.gbxRequestForVacation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отпуска";
            this.gbxRequestForVacation.ResumeLayout(false);
            this.gbxRequestForVacation.PerformLayout();
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
    }
}

