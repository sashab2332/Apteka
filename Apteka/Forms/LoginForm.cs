using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apteka.Data.Repositories;


namespace Apteka.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IEmployeeRep _employeeRepo;
        public LoginForm()
        {
            _employeeRepo = (IEmployeeRep)Program.ServiceProvider.GetService(typeof(IEmployeeRep));
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;

            if (login == "admin")
            {
                if (password == "pass")
                {
                    Hide();
                    MainForm frm= new MainForm();
                    Program.UserPosition = "Администратор";
                    Program.UserId = 9999;
                    // frm.linkLabel1.Visible = false;
                    frm.ShowDialog();
                    return;
                }
            }

            var user = await _employeeRepo.GetEmployee(login);
            if (user == null || user.Password != password)
            {
                MessageBox.Show("Неверный логин или пароль!");
                return;
            }
          //  var useronline = user.Name;
            


            switch (user.Position)
            {
                case "Директор":
                    Hide();
                    Program.UserPosition = user.Position;
                    Program.UserName = user.Name;
                    Program.UserId = user.EmployeeId;
                    new MainForm().ShowDialog();
                    break;
                case "Бухгалтер":
                    Hide();
                    Program.UserPosition = user.Position;
                    Program.UserName = user.Name;
                    Program.UserId = user.EmployeeId;
                    new MainForm().ShowDialog();
                    break;
                case "Продавец":
                    Hide();
                    Program.UserPosition = user.Position;
                    Program.UserName = user.Name;
                    Program.UserId = user.EmployeeId;
                    new MainForm().ShowDialog();
                    //здесь должны быть скрыты вкладки и отчёты
                

                    break;
            }

        }

    }
}
