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
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelMediaSubmenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelSubMenuTools.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelMediaSubmenu.Visible == true)
            {
                panelMediaSubmenu.Visible = false;
            }
            if (panelPlaylistSubMenu.Visible == true)
            {
                panelPlaylistSubMenu.Visible = false;
            }
            if (panelSubMenuTools.Visible == true)
            {
                panelSubMenuTools.Visible = false;
            }
        }
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }else
                subMenu.Visible = false;
        }
       
        //buttons
        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubmenu(panelMediaSubmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.ShowDialog();
            // And to close
            form2.Close();
            hideSubMenu();
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubmenu(panelPlaylistSubMenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            // And to close
            form3.Close();
            hideSubMenu();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubMenuTools);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            this.Close();
        }
        private Form activeForm = null;
        private void OpenChildPanel(Form childForm)
        {
           if (activeForm != null)
            activeForm.Close();
        activeForm = childForm;
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        panelChildForm.Controls.Add(childForm);
        panelChildForm.Tag = childForm;
        panelChildForm.Parent = this;           
        childForm.BringToFront();
        childForm.Show();
        }

    }


}

