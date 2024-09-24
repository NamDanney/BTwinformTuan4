using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(frm.Msnv, frm.Name, frm.LuongCB );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Form2 frm = new Form2();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    selectedRow.Cells["MSNV"].Value = frm.Msnv;
                    selectedRow.Cells["TenNV"].Value = frm.Name;
                    selectedRow.Cells["Luong"].Value = frm.LuongCB;
                }
            }
            else { MessageBox.Show("Vui lòng chọn một nhân viên để sửa.");}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Chọn nhân viên để xóa");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
