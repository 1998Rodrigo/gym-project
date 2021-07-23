using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using Models;


namespace WindowsFormsApplication1
{
    public partial class STUREG : UserControl
    {
        public STUREG()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            try
            {
                var registration = new RegistrationModel()
                {
                    Id = int.Parse(txtId.Text),
                    Fname = txtFName.Text,
                    Lname = txtLName.Text,
                    Age = int.Parse(txtAge.Text),
                    Email = txtEmail.Text,
                    BirthDate = DateTimePicker1.Text,

                };

                var data = new RegistrationData();
                if(data.SaveClient(registration))
                {
                    MessageBox.Show("Save Details");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Update()
        {
            try
            {
                var registration = new RegistrationModel()
                {
                    Id = int.Parse(txtId.Text),
                    Fname = txtFName.Text,
                    Lname = txtLName.Text,
                    Age = int.Parse(txtAge.Text),
                    Email = txtEmail.Text,
                    BirthDate = DateTimePicker1.Text,
                };



                var data = new RegistrationData();
                if (data.UpdateClient(registration))
                {
                    MessageBox.Show("Update Sucessfull");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            try
            {
                var registration = new RegistrationModel()
                {
                    Id = int.Parse(txtId.Text),
                    Fname = txtFName.Text,
                    Lname = txtLName.Text,
                    Age = int.Parse(txtAge.Text),
                    Email = txtEmail.Text,
                    BirthDate = DateTimePicker1.Text,

                };

                var data = new RegistrationData();
                if (data.DeleteClient(registration))
                {
                    MessageBox.Show("Save Details");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
