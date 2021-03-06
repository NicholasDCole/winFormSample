﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColeProject4
{
    public partial class ClothingForm : Form
    {
        public ClothingForm()
        {
            InitializeComponent();
            ProductRetrieval pr = new ProductRetrieval("3");
            clothingGrid.DataSource = pr.dt;
            numRecordsLabel.Text = "Number of Rows: " + clothingGrid.Rows.Count.ToString();
        }

        private void ClothingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure want to exit?",
                               "Cole's Form",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                    Environment.Exit(1);
                else
                    e.Cancel = true; // to don't close form is user change his mind
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var frm = new CategoryForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
