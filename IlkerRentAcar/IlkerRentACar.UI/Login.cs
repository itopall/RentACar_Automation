using IlkerRentACar.UI.Cache;
using RentACar.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlkerRentACar.UI
{
    public partial class Login : Form
    {
        IUserServices userServices = new UserServices();
        int userTypeId;
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MdiForm mdiForm = new MdiForm();
            
            var dto = userServices.Login(txtUsername.Text,txtPassword.Text);
            if (dto != null)
            {
                CacheManager.LoginUser = dto;
                CacheManager.LoginPassword = dto;
                
                if (dto.UsertypeId == 2)
                {
                    
                    mdiForm.toolStripAyarlar.Enabled = false;
                    
                }
                

                Hide();
                
                mdiForm.Show();
                
            }
            else
            {
                MessageBox.Show("Girdiğiniz kullanıcı adı veya parola hatalı!");
            }

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MdiForm mdiForm = new MdiForm();
            mdiForm.Show();   
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
