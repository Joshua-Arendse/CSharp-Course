using System.Windows.Forms;
using System.Xml.Linq;

namespace PayMyEmployeeV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string surname = Surname.Text;
            string employeeId = EmpID.Text;
            double hourlyRate = double.Parse(HourlyRate.Text);
            double hoursWorked = double.Parse(HoursWorked.Text);

            double TotalPay = hourlyRate * hoursWorked;

            double pensionFund = TotalPay * 0.05;
            double medicalAid = TotalPay * 0.06;
            double UIF = TotalPay * 0.04;
            double Deductions = pensionFund + medicalAid + UIF;

            double ActualPay = TotalPay - Deductions;

            DisplayBox.Text =
                $"Name: {name} {surname}\r\n" +
                $"Employee ID: #{employeeId}\r\n" +
                $"Hours Worked: {hoursWorked} Hours\r\n" +
                $"Hourly Rate: R{hourlyRate}\r\n" +
                $"This is your Salary after deductions:\r\n R{ActualPay}";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            HourlyRate.Text = string.Empty;
            NameBox.Text = string.Empty;
            Surname.Text = string.Empty;
            HoursWorked.Text = string.Empty;
            EmpID.Text = string.Empty;
            DisplayBox.Text = string.Empty;
        }
    }
}
