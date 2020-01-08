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
    public partial class Home : Form
    {
        public static List<Contact> contactList;
        public Home()
        {
            InitializeComponent();
            contactList = new List<Contact>();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            contactList.Add(new Contact("Zay Yar Tun", "0912345678", "zayar@gmail.com", "Friend", true));
            contactList.Add(new Contact("Myat Min Khant", "0912345678", "myat@gmail.com", "Family", false));
            contactList.Add(new Contact("Sam Min Aung", "0912345678", "sam@gmail.com", "Friend", true));
            contactList.Add(new Contact("Kaung Set Hein", "0912345678", "kaung@gmail.com", "Job", false));
            contactList.Add(new Contact("Kyaw Min Tun", "0912345678", "kyaw@gmail.com", "Family", true));
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
           new NewContact().ShowDialog(this);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            new ShowContacts().ShowDialog(this);
        }

      
    }
}
