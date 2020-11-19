﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilkTeaHouseProject.DAL;
using MilkTeaHouseProject.DTO;
using MilkTeaShopManagement.DAL;
using MilkTeaShopManagement.DTO;

namespace MilkTeaHouseProject
{
    public partial class fAddStaff : Form
    {
        public fAddStaff()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = this.txtUser.Text;
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("Nhập Họ Tên", "Error");
            }
            else if (string.IsNullOrEmpty(this.cbbPos.Text))
            {
                MessageBox.Show("Chọn Công việc", "Error");
            }
            else if (string.IsNullOrEmpty(this.txtSalary.Text))
            {
                MessageBox.Show("Nhập mức lương cơ bản", "Error");
            }
            else if (string.IsNullOrEmpty(this.txtUser.Text))
            {
                MessageBox.Show("Nhập User", "Error");
            }
            else if (string.IsNullOrEmpty(this.txtPass.Text))
            {
                MessageBox.Show("Nhập PassWord", "Error");
            }
            else
            {
                Account.Instance.SignUp(this.txtUser.Text, this.txtPass.Text);
                StaffDAL.Instance.AddStaff(this.txtName.Text, this.dateTimePicker1.Value, this.cbbPos.Text, 96, int.Parse(this.txtSalary.Text), this.txtUser.Text); ;
                this.Close();
            }
        }
        private void txtBasicSalary_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
