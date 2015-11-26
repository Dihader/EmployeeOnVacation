using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmployeeOnVacation
{
    public partial class MainForm : Form
    {
        private IVacation _vacation;
        private Employee _employee= new Employee();

        public MainForm()
        {
            InitializeComponent();
            CreateVacations();
            cbxEmployeesSurname.DisplayMember = "LastName";
            cbxEmployeesSurname.ValueMember = "LastName";
            cbxEmployeesSurname.DataSource = _employee.GetAllEmployee();
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
                if (!ValisateDate())
                {
                    MessageBox.Show("Даты конца отпуска должна быть больше даты начала отпуска.");
                    return;
                }
                int indexVacation = cbxVacationTypes.SelectedIndex;
                switch (indexVacation)
                {
                    case 0:
                        MessageBox.Show("Отпуск по болезни");
                        _vacation=new SicknessVacation();
                        break;
                    case 1:
                        MessageBox.Show("Отпуск без оплаты");
                        _vacation = new WithoutPaymentVacation();
                        break;
                    case 2:
                        MessageBox.Show("Регулярный отпуск");
                          _vacation=new RegularVacation();
                        break;
                    case 3:
                        MessageBox.Show("Учебный отпуск");
                        _vacation=new EducationalVacation();
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

        private bool ValisateDate()
        {
            if (dtpStartVacation.Value>=dtpEndVacation.Value)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cbxEmployeesSurname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Employee> employeesInfo = _employee.GetAllEmployee();
                txtName.Text = employeesInfo[cbxEmployeesSurname.SelectedIndex].FirstName;
                txtMidleName.Text = employeesInfo[cbxEmployeesSurname.SelectedIndex].MiddleName;
                txtSalary.Text = employeesInfo[cbxEmployeesSurname.SelectedIndex].Salary.ToString("#,##");

            }
            catch
            {
            }
        }
    }
}
