using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MALLMAP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
                currentFormChild.Close();

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(childForm);
            childForm.Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox.Items.Add("Tầng 1");
            comboBox.Items.Add("Tầng 2");
            comboBox.Items.Add("Tầng 3");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string tang = comboBox.SelectedItem.ToString();

            switch (tang)
            {
                case "Tầng 1":
                    OpenChildForm(new Form1());
                    break;

                case "Tầng 2":

                    break;

                case "Tầng 3":

                    break;
            }
        }
    }
}
