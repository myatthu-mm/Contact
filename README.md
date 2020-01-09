# Contact
C# Windows Form Template Project

## Documentation

![Flow Diagram](https://github.com/myatthu-mm/Contact/blob/master/ss/flow.png)
*Project Flow Diagram*


### Home Form
![Home Form](https://github.com/myatthu-mm/Contact/blob/master/ss/home.png)

> 
ဒါကတော့ home form design ပါ။ Element 4 ခုထဲ ပါ။

 1. contact icon
 2. label (with border)
 3. create new contact button
 4. show all contacts button

**Home.cs**


    public  static  List<Contact> contactList;
    
    public  Home()
    {
    InitializeComponent();
    contactList  =  new  List<Contact>();
    }
    
> Contact data တွေကိုသိမ်းဖို့ *contactList* ဆိုတဲ့ Contact အမျိုးစား
> List တစ်ခု ဆောက်ပါတယ်။ သတိထားရမှာက *static keyword*
> သုံးပီးလုပ်ထားတာပါ၊  တခြား Form class ကနေ တိုက်ရိုက်
> ယူသုံးလို့ရအောင်ပါ။ (Contact class ကိုတော့ project ထဲမှာ
> ကြည့်နိုင်ပါတယ်)

    private  void  Home_Load(object sender, EventArgs e)
    {
    contactList.Add(new  Contact("Zay Yar Tun", "0912345678", "zayar@gmail.com", "Friend", true));
    contactList.Add(new  Contact("Myat Min Khant", "0912345678", "myat@gmail.com", "Family", false));
    contactList.Add(new  Contact("Sam Min Aung", "0912345678", "sam@gmail.com", "Friend", true));
    contactList.Add(new  Contact("Kaung Set Hein", "0912345678", "kaung@gmail.com", "Job", false));
    contactList.Add(new  Contact("Kyaw Min Tun", "0912345678", "kyaw@gmail.com", "Family", true));
    }
    
   
Form load မှာ contact ၅ ခုကို အရင် initialize လုပ်ထားတာပါ(show all ကို click ရင် data မြင်ရအောင်လို့)

    private  void  btnNewContact_Click(object sender, EventArgs e)
    {
    new  NewContact().ShowDialog(this);
    }
    
    private  void  btnShowAll_Click(object sender, EventArgs e)
    {
    new  ShowContacts().ShowDialog(this);
    }

**New contact button နဲ့ Show all button တွေရဲ့ onClick functions တွေပါ။ New contact ကို click ရင် Create New Contact form ကို ကူးသွားရမှာပါ။ အဲ့မှာ သတိထားရမှာက ShowDialog(this) ပါ။ ကူးသွားတဲ့ New Contact form ကို child form ဖြစ်စေဖို့ပါ။ New Contact form က child form အဖြစ် ရှိနေရင် Parent form ဖြစ်တဲ့ Home form ကို Child form(New Contact form) active ဖြစ်နေစဥ် click လို့ မရအောင်ပါ။ ShowContact form ကို ကူးတဲ့ အခါမှာလည်း အလားတူပဲ ဖြစ်တယ်။**

### New Contact Form
![New Contact Form](https://github.com/myatthu-mm/Contact/blob/master/ss/new.png)

ပုံမှာ တွေ့တဲ့အတိုင်း input fields တွေအနေနဲ့ textbox 3 ခု combo 1 ခု checkbox 1 ခု ပါ။

NewContact.cs

    private void NewContact_Load(object sender, EventArgs e)
      {
                cboRelation.SelectedIndex = 0;
      }

Form load မှာ combo box ရဲ့ ပထမဆုံး item ကို ရွေးထားစေချင်လို့ပါ

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

Input fields တွေကနေ value တွေယူပီး Home form မှာ ရှိတဲ့ Contacts တွေသိမ်းတဲ့ list ထဲပဲ သိမ်းတာပါ ။ value တွေယူတဲ့အခါ validation တွေကိုတော့ မထည့်ထားပါဘူး (ထည့်ချင်ရင် ကိုယ့်ဘာသာထည့်လို့ပြောတာ)
သိမ်းပီးရင်တော့ input fields တွေကို ပြန်ပီး Clear လုပ်ဖို့ လိုပါတယ်(ဒါမှ နောက် contact ထည့်သွင်းလို့ အဆင်ပြေမှာပါ)


### ShowContacts Form
![Show Contacts Form](https://github.com/myatthu-mm/Contact/blob/master/ss/show.png)

> ပုံပါအတိုင်း All Contacts button က List ထဲ ရှိသမျှ contacts တွေဆွဲ
> ထုတ်ပေးပီး GridView မှာ ပြရမှာပါ။
> 
> Relation combo box ရဲ့ Item change တိုင်းမှာ GridView မှာ ရှိတဲ့ data
> တွေက Relation combo ရဲ့ selection value အတိုင်း ရွေးပြရမှာပါ။
> 
> Favourite checkbox လည်း ထိုနည်းတူပါပဲ
> Refresh button က update နဲ့ delete လုပ်ပီးတိုင်း click မှ GridView မှာ
> update ဖြစ်မှာပါ

ShowContacts.cs

    public ShowContacts()
            {
                InitializeComponent();
                ShowAllContacts();
            }

Form load မှာ list ထဲမှာ ရှိတဲ့ contact တွေအားလုံး Grid View မှာ ပြဖို့လိုပါတယ်

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

UpdateGridView function ရဲ့ responsibility က parameter ပေးတဲ့ list ရဲ့ data တွေအတိုင်း GridView မှာ ပေါ်ပေးဖို့ပါ

    private void cboRelation_SelectedIndexChanged(object sender, EventArgs e)
            {
                //filter relation category
                List<Contact> relationList = (List<Contact>)Home.contactList.Where(contact => contact.Relation == cboRelation.SelectedItem.ToString()).ToList();
                //update grid view
                UpdateGridView(relationList);
                //pointing label for specific progress
                lblStatus.Text = "Relation is searching...";
            }

**Relation combo box ရဲ့ selection item ပြောင်းတိုင်းမှာ Main List ဖြစ်တဲ့ Home.contactList ထဲက Where clause နဲ့ ဆွဲထုတ်ပီး relationList ဆိုတဲ့ list တခုထဲ ပြောင်းထည့်ပါတယ် ပီးတော့ grid view မှာ update လုပ်လိုက်ပါတယ်**

    private void contactGridView_MouseDoubleClick(object sender, MouseEventArgs e)
            {
                int selectedRowIndex = contactGridView.CurrentCell.RowIndex;
                new Action(selectedRowIndex).ShowDialog(this);
            }

Grid view ရဲ့ cell ကို click တဲ့ အခါ click တဲ့ row index ကို ယူပီး Action form ကို ကူးပီး ပေးလိုက်ပါတယ်


### Action Form
![Action Form](https://github.com/myatthu-mm/Contact/blob/master/ss/update.png)

Action form သည် grid view က ရွေးလိုက်တဲ့ သူရဲ့ contact info ကို Remove / Update လုပ်ဖို့ဖြစ်ပါတယ်

Action.cs

		    int selectedIndex;
            public Action(int index)
            {
                InitializeComponent();
                selectedIndex = index;
            }

Constructor ထဲမှာ Gridview က ပို့လိုက်တဲ့ index ကို selectedIndex variable ထဲ ထည့်ပီး သိမ်းထားပါတယ်

    private void Action_Load(object sender, EventArgs e)
            {
                Contact selectedContact = (Contact)Home.contactList[selectedIndex];
                txtName.Text = selectedContact.Name;
                txtPhno.Text = selectedContact.Phno;
                txtEmail.Text = selectedContact.Email;
                cboRelation.SelectedItem = selectedContact.Relation;
                chkFavourite.Checked = selectedContact.isFavourite;
            }

Form load မှာ လုပ်ရမှာက main list ထဲကနေ ရရှိထားတဲ့ selectedIndex ပေးပီး contact info တွေ ဆွဲထုတ်ပီးတော့ Form ရဲ့ input field တွေမှာ လိုက်ဖြည့်ပေးရပါမယ်



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

ပြင်ပီးသား ပြန် save ဖို့(update) နဲ့ delete လုပ်တာကလည်း main list (***Home.contactList***) ထဲမှာပဲ လုပ်ပေးရမှာ ဖြစ်ပါတယ်။

  

ဒီလောက်ဆို အားလုံးလည်း အဆင်ပြေကြမယ် ထင်ပါတယ်

  
Remark: Using *List* instead of *ArrayList* is efficient to use in ***Linq*** filtering.

![](https://github.com/myatthu-mm/Contact/blob/master/ss/rock.gif)


