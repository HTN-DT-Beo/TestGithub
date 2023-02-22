using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tenTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void mssvTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void tenLabel_Click(object sender, EventArgs e)
        {

        }
        private void mssvLabel_Click(object sender, EventArgs e)
        {

        }
        private void toanTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void lyTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void hoaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void toanLabel_Click(object sender, EventArgs e)
        {

        }
        private void lyLabel_Click(object sender, EventArgs e)
        {

        }
        private void hoaLabel_Click(object sender, EventArgs e)
        {

        }

        
        private void AddButton_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();

            if ((string.IsNullOrEmpty(tenTextBox.Text)) || (string.IsNullOrEmpty(mssvTextBox.Text)))
            {
                MessageBox.Show("Please enter your ID");
            }
            else
            {
                ListViewItem item = new ListViewItem();
                //ListViewItem.ListViewSubItem subitem1;
               
                sv.Mssv = int.Parse(mssvTextBox.Text);
                item.Text = sv.Mssv.ToString();
                listView1.Items.Add(item);

                sv.Name = tenTextBox.Text;
                //subitem1 = new ListViewItem.ListViewSubItem(item, (sv.Name));
                item.SubItems.Add(sv.Name);

                sv.Diem.TCC = double.Parse(toanTextBox.Text);
                //subitem1 = new ListViewItem.ListViewSubItem(item, (sv.Diem.TCC.ToString()));
                item.SubItems.Add(sv.Diem.TCC.ToString());

                sv.Diem.LDC = double.Parse(lyTextBox.Text);
                //subitem1 = new ListViewItem.ListViewSubItem(item, (sv.Diem.LDC.ToString()));
                item.SubItems.Add(sv.Diem.LDC.ToString());

                sv.Diem.HDC = double.Parse(hoaTextBox.Text);
                //subitem1 = new ListViewItem.ListViewSubItem(item, (sv.Diem.HDC.ToString()));
                item.SubItems.Add(sv.Diem.HDC.ToString());

                //ubitem1 = new ListViewItem.ListViewSubItem(item, (sv.Gpa.ToString()));
                item.SubItems.Add(SinhVien.ToStringGpa(sv.Gpa));

                mssvTextBox.Clear();
                tenTextBox.Clear();
                toanTextBox.Clear();
                lyTextBox.Clear();
                hoaTextBox.Clear();

            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Student does not exits", "Canh bao");
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
