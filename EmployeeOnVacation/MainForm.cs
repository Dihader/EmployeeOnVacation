using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EmployeeOnVacation.Vacations;

namespace EmployeeOnVacation
{
    public partial class MainForm : Form
    {
        private Vacation _vacation;
        private Employee emp;
        public MainForm()
        {
            InitializeComponent();
            CreateVacations();

            cbxEmployeesSurname.DisplayMember = "LastName";
            cbxEmployeesSurname.ValueMember = "ID";
            cbxEmployeesSurname.DataSource = EmployeeRepository.GetAllEmployee();
            cbxSurnamesForSearch.DisplayMember = "LastName";
            cbxSurnamesForSearch.ValueMember = "ID";
            cbxSurnamesForSearch.DataSource = EmployeeRepository.GetAllEmployee();
            lbxListVacations.DisplayMember = "Name";
            lbxListVacations.ValueMember = "Name";
            lbxListVacations.DataSource = VacationRepository.GetAllVacations();
        }

        private void CreateVacations()
        {
            cbxVacationTypes.Items.Add("Отпуск по болезни");
            cbxVacationTypes.Items.Add("Отпуск без оплаты");
            cbxVacationTypes.Items.Add("Регулярный отпуск");
            cbxVacationTypes.Items.Add("Учебный отпуск");


        }

        private void btnCreateRequest_Click(object sender, EventArgs e)
        {
            try
            {
                int indexVacation = cbxVacationTypes.SelectedIndex;
                if (!ValidateDate(indexVacation))
                {
                    return;
                }
                emp = EmployeeRepository.GetEmployee(Convert.ToInt32(cbxEmployeesSurname.SelectedValue));
                switch (indexVacation)
                {
                    case 0:
                        CreateSickness();
                        break;
                    case 1:
                        CreateWithoutPayment();
                        break;
                    case 2:
                        CreateRegular();
                        break;
                    case 3:
                        CreateEducational();
                        break;
                    default:
                        MessageBox.Show("Не выбран тип отпуска.");
                        break;

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void CreateRegular()
        {
            string name = "";
            if (ckbxConfirm.Checked)
            {
                name = emp.LastName + " " + cbxVacationTypes.Text + " " + dtpStartVacation.Value.ToShortDateString() + "-" + dtpEndVacation.Value.ToShortDateString() + " Статус=Потвержден";

            }
            else
            {
                name = emp.LastName + " " + cbxVacationTypes.Text + " " + dtpStartVacation.Value.ToShortDateString() + "-" + dtpEndVacation.Value.ToShortDateString() + " Статус=Не потвержден";

            }
            _vacation = new RegularVacation(name, emp, dtpStartVacation.Value, dtpEndVacation.Value, txtComment.Text, ckbxConfirm.Checked);
            VacationRepository.Add(_vacation);
            MessageBox.Show("Выплата за этот отпуск составит:" + _vacation.GetMoneyVacation().ToString("###,##"));
        }

        private void CreateWithoutPayment()
        {
            string name = "";
            if (ckbxConfirm.Checked)
            {
                name = emp.LastName + " " + cbxVacationTypes.Text + " " + dtpStartVacation.Value.ToShortDateString() + "-" + dtpEndVacation.Value.ToShortDateString() + " Статус=Потвержден";

            }
            else
            {
                name = emp.LastName + " " + cbxVacationTypes.Text + " " + dtpStartVacation.Value.ToShortDateString() + "-" + dtpEndVacation.Value.ToShortDateString() + " Статус=Не потвержден";

            }
            _vacation = new WithoutPaymentVacation(name, emp, dtpStartVacation.Value, dtpEndVacation.Value, txtComment.Text, ckbxConfirm.Checked);
            VacationRepository.Add(_vacation);
            MessageBox.Show("Выплата за этот отпуск составит:" + _vacation.GetMoneyVacation().ToString("###,##"));
        }

        private void CreateEducational()
        {
            string name = emp.LastName + " " + cbxVacationTypes.Text + " " + dtpStartVacation.Value.ToShortDateString() + "-" + dtpEndVacation.Value.ToShortDateString();
            _vacation = new EducationalVacation(name, emp, dtpStartVacation.Value, dtpEndVacation.Value, txtComment.Text);
            VacationRepository.Add(_vacation);
            MessageBox.Show("Выплата за этот отпуск составит:" + _vacation.GetMoneyVacation().ToString("###,##"));
        }

        private void CreateSickness()
        {
            string name = emp.LastName + " " + cbxVacationTypes.Text + " " + dtpStartVacation.Value.ToShortDateString() + "-" + dtpEndVacation.Value.ToShortDateString();
            _vacation = new SicknessVacation(name, emp, dtpStartVacation.Value, dtpEndVacation.Value, txtComment.Text, txtLinkSickList.Text);
            VacationRepository.Add(_vacation);
            MessageBox.Show("Выплата за этот отпуск составит:" + _vacation.GetMoneyVacation().ToString("###,##"));
        }

        private bool ValidateDate(int index)
        {
            if (dtpStartVacation.Value >= dtpEndVacation.Value)
            {
                MessageBox.Show("Даты конца отпуска должна быть больше даты начала отпуска.");
                return false;
            }
            else
            {
                if (index == 0 && txtLinkSickList.Text == "")
                {
                    MessageBox.Show("Введите ссылку на больничный лист.");
                    return false;
                }
                return true;
            }
        }

        private void cbxEmployeesSurname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Employee> employeesInfo = EmployeeRepository.GetAllEmployee();
                txtName.Text = employeesInfo[cbxEmployeesSurname.SelectedIndex].FirstName;
                txtMidleName.Text = employeesInfo[cbxEmployeesSurname.SelectedIndex].MiddleName;
                txtSalary.Text = employeesInfo[cbxEmployeesSurname.SelectedIndex].Salary.ToString("#,##");

            }
            catch
            {
            }
        }

        private void cbxVacationTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexVacation = cbxVacationTypes.SelectedIndex;
            switch (indexVacation)
            {
                case 0:
                    ckbxConfirm.Visible = false;
                    txtLinkSickList.Visible = true;
                    lblSickList.Visible = true;
                    break;
                case 1:
                    ckbxConfirm.Visible = true;
                    txtLinkSickList.Visible = false;
                    lblSickList.Visible = false;
                    break;
                case 2:
                    ckbxConfirm.Visible = true;
                    txtLinkSickList.Visible = false;
                    lblSickList.Visible = false;
                    break;
                case 3:
                    ckbxConfirm.Visible = false;
                    txtLinkSickList.Visible = false;
                    lblSickList.Visible = false;
                    break;
                default:
                    ckbxConfirm.Visible = false;
                    txtLinkSickList.Visible = false;
                    lblSickList.Visible = false;
                    break;

            }

        }


        private void lbxListVacations_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string name = lbxListVacations.SelectedValue.ToString();
                Vacation vacation = VacationRepository.GetVacation(name);
                dtpStartDateForThisEmployee.Value = vacation.DateStartVacation;
                dtpEndDateForThisEmployee.Value = vacation.DateEndVacation;
                txtCommentForThisEmployee.Text = vacation.Description;
            }
            catch
            {
            }
        }

        private void btnGetAllVacations_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(cbxSurnamesForSearch.SelectedValue);
                lbxListVacations.DataSource = VacationRepository.GetListVacations(ID);
            }
            catch
            {
            }

        }
    }
}
