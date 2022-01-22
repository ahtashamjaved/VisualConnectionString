using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualConnectionString
{
    public partial class FormConnectionString : MetroFramework.Forms.MetroForm
    {
        public FormConnectionString()
        {
            InitializeComponent();
        }


        private string getIntegratedSecurity()
        {
            if (rbtnFalse.Checked)
                return "false";
            else
                return "true";
        }
        private void setIntegratedSecurity()
        {
            if (StaticClass.integratedSecurity == "true")
                rbtnTrue.Checked = true;
            else
                rbtnFalse.Checked = true;

        }
        private void loadConnectionStringData()
        {
            txtServer.Text = StaticClass.ServerName;
            txtDatabase.Text = StaticClass.initialCatelog;
            setIntegratedSecurity();
            txtTimeout.Text = StaticClass.timeout;
            txtUsername.Text = StaticClass.userId;
            txtPassword.Text = StaticClass.password;

        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                string integratedSecurity = getIntegratedSecurity();
                StaticClass.updateConnectionString(txtServer.Text, txtDatabase.Text, integratedSecurity, txtTimeout.Text, txtUsername.Text, txtPassword.Text);
                StaticClass.saveConnectionStringToFile();
                var connection = new SqlConnection(StaticClass.connectionString);
                connection.Open(); 
                lblMessage.Text = "Connection String changed successfully please press Close button";
                connection.Close();
            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }
        }

        private void FormConnectionString_Load(object sender, EventArgs e)
        {
            try
            {
                StaticClass.loadConnectionStringFromFile();
                loadConnectionStringData();
            }
            catch (Exception)
            {


            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
