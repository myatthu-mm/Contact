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
    public partial class Action : Form
    {
        int selectedIndex;
        public Action(int index)
        {
            InitializeComponent();
            selectedIndex = index;
        }

        private void Action_Load(object sender, EventArgs e)
        {
            Contact selectedContact = (Contact)Home.contactList[selectedIndex];
            txtName.Text = selectedContact.Name;
            txtPhno.Text = selectedContact.Phno;
            txtEmail.Text = selectedContact.Email;
            cboRelation.SelectedItem = selectedContact.Relation;
            chkFavourite.Checked = selectedContact.isFavourite;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.ToString();
            string phno = txtPhno.Text.ToString();
            string email = txtEmail.Text.ToString();
            string relation = cboRelation.SelectedItem.ToString();
            bool isFavourite = chkFavourite.Checked;
            //update contact
            Home.contactList[selectedIndex] = new Contact(name, phno, email, relation, isFavourite);
            MessageBox.Show(name +"'s contact has been successfully updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Contact selectedContact = (Contact)Home.contactList[selectedIndex];
            string deletedContact = selectedContact.Name;
            Home.contactList.RemoveAt(selectedIndex);
            MessageBox.Show(deletedContact + "'s contact has been successfully deleted!");
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
