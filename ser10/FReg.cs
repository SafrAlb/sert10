using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ser10.Model;

namespace ser10
{
    public partial class FReg : Form
    {
        public FReg()
        {
            InitializeComponent();
        }

        internal static string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }

        private void btSaveQuit_Click(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            Users usr = new Users();
            usr.FIO = tbFIO.Text;
            usr.login = tbLog.Text;
            usr.password = tbPas.Text;
            string HashCode = GetHash(tbPas.Text);
            usr.password = HashCode;
            model.Users.Add(usr);
            model.SaveChanges();
            MessageBox.Show("Успешно добавлен в базу");
            FAuth auth = new FAuth();
            auth.Show();
            Close();
        }
    }
}
