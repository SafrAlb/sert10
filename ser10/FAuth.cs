using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using ser10.Model;
using static ser10.FReg;

namespace ser10
{
    public partial class FAuth : Form
    {
        Model1 model = new Model1();
        public FAuth()
        {
            InitializeComponent();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {

            string HashCode = GetHash(tbPas.Text);
            Users usr = model.Users.Find(tbLog.Text);
            if (HashCode == usr.password)
            {
                MessageBox.Show("успешный вход");
            }
            else
            {
                MessageBox.Show("неверный пароль");
            }
        }

        private void btReg_Click(object sender, EventArgs e)
        {
            FReg reg = new FReg();
            reg.ShowDialog();
            Close();
        }

        private void cbShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPas.Checked == true)
            {
                tbPas.PasswordChar = '\0';
            }
            else
            {
                tbPas.PasswordChar = '*';
            }
        }
    }
}
