using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_Contact
{
    public partial class NewContact : Form
    {
        public NewContact()
        {
            InitializeComponent();
        }

        private void NewContact_Load(object sender, EventArgs e)
        {
            cboRelation.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.ToString();
            string phno = txtPhno.Text.ToString();
            string email = txtEmail.Text.ToString();
            string relation = cboRelation.SelectedItem.ToString();
            bool isFavourite = chkFavourite.Checked;
            // add to contact
            Home.contactList.Add(new Contact(name, phno, email, relation, isFavourite));
            //form clear
            txtName.Clear();
            txtPhno.Clear();
            txtEmail.Clear();
            cboRelation.SelectedIndex = 0;
            chkFavourite.Checked = false;
            MessageBox.Show(name + " has been successfully saved!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
