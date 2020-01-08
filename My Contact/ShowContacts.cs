using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace My_Contact
{
    public partial class ShowContacts : Form
    {
        public ShowContacts()
        {
            InitializeComponent();
            ShowAllContacts();
        }

        private void ShowAllContacts()
        {
            UpdateGridView(Home.contactList);
        }

        private void UpdateGridView(List<Contact> list)
        {
            if(list.Count > 0)
            {
                contactGridView.Rows.Clear();
                foreach (Contact c in list)
                {
                    int n = contactGridView.Rows.Add();
                    contactGridView.Rows[n].Cells[0].Value = c.Name;
                    contactGridView.Rows[n].Cells[1].Value = c.Phno;
                    contactGridView.Rows[n].Cells[2].Value = c.Email;
                    contactGridView.Rows[n].Cells[3].Value = c.Relation;
                    contactGridView.Rows[n].Cells[4].Value = (c.isFavourite)?"YES":"NO";
                }
            }
        }

        private void contactGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedRowIndex = contactGridView.CurrentCell.RowIndex;
            new Action(selectedRowIndex).ShowDialog(this);
        }

        private void btnShowAllContacts_Click(object sender, EventArgs e)
        {
            ShowAllContacts();
            cboRelation.SelectedIndex = 0;
            lblStatus.Text = "";
        }

        private void cboRelation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filter relation category
            List<Contact> relationList = (List<Contact>)Home.contactList.Where(contact => contact.Relation == cboRelation.SelectedItem.ToString()).ToList();
            //update grid view
            UpdateGridView(relationList);
            //pointing label for specific progress
            lblStatus.Text = "Relation is searching...";
        }

        private void chkFavourite_CheckedChanged(object sender, EventArgs e)
        {
            //filter favourites
            List<Contact> favouriteList = (List<Contact>)Home.contactList.Where(contact => contact.isFavourite == chkFavourite.Checked).ToList();
            //update grid view
            UpdateGridView(favouriteList);
            //pointing label for specific progress
            lblStatus.Text = "Favourite is searching...";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowAllContacts();
            lblStatus.Text = "";
        }
    }
}
