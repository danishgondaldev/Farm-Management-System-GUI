﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmManagementSystem.DL;

namespace FarmManagementSystem
{
    public partial class AddEggs : Form
    {
        public AddEggs()
        {
            InitializeComponent();
        }


        private void btnSaveData_Click(object sender, EventArgs e)
        {
            FarmDataDL.Data.Eggs = FarmDataDL.Data.Eggs + int.Parse(txtEggs.Text);
            FarmDataDL.Data.Eggs_price = int.Parse(txtEggsPrice.Text);
            FarmDataDL.storeFarmDataIntoFile();
            MessageBox.Show("Data Saved Successfully! ");
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is AdminMenu)
                {
                    oForm.Show();
                    break;
                }
            }
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is HomePage)
                {
                    oForm.Show();
                    break;
                }
            }
            this.Close();
        }
    }
}
