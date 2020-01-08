namespace My_Contact
{
    partial class ShowContacts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkFavourite = new System.Windows.Forms.CheckBox();
            this.cboRelation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowAllContacts = new System.Windows.Forms.Button();
            this.contactGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favourite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.chkFavourite);
            this.groupBox1.Controls.Add(this.cboRelation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnShowAllContacts);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(34, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by Parameters";
            // 
            // chkFavourite
            // 
            this.chkFavourite.AutoSize = true;
            this.chkFavourite.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFavourite.Location = new System.Drawing.Point(348, 86);
            this.chkFavourite.Name = "chkFavourite";
            this.chkFavourite.Size = new System.Drawing.Size(157, 22);
            this.chkFavourite.TabIndex = 5;
            this.chkFavourite.Text = " Favourite   ";
            this.chkFavourite.UseVisualStyleBackColor = true;
            this.chkFavourite.CheckedChanged += new System.EventHandler(this.chkFavourite_CheckedChanged);
            // 
            // cboRelation
            // 
            this.cboRelation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cboRelation.FormattingEnabled = true;
            this.cboRelation.Items.AddRange(new object[] {
            "Friend",
            "Family",
            "Job"});
            this.cboRelation.Location = new System.Drawing.Point(384, 26);
            this.cboRelation.Name = "cboRelation";
            this.cboRelation.Size = new System.Drawing.Size(121, 28);
            this.cboRelation.TabIndex = 2;
            this.cboRelation.SelectedIndexChanged += new System.EventHandler(this.cboRelation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relation";
            // 
            // btnShowAllContacts
            // 
            this.btnShowAllContacts.Location = new System.Drawing.Point(21, 47);
            this.btnShowAllContacts.Name = "btnShowAllContacts";
            this.btnShowAllContacts.Size = new System.Drawing.Size(126, 31);
            this.btnShowAllContacts.TabIndex = 0;
            this.btnShowAllContacts.Text = "All Contacts";
            this.btnShowAllContacts.UseVisualStyleBackColor = true;
            this.btnShowAllContacts.Click += new System.EventHandler(this.btnShowAllContacts_Click);
            // 
            // contactGridView
            // 
            this.contactGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.phno,
            this.email,
            this.relation,
            this.favourite});
            this.contactGridView.Location = new System.Drawing.Point(34, 156);
            this.contactGridView.Name = "contactGridView";
            this.contactGridView.Size = new System.Drawing.Size(552, 184);
            this.contactGridView.TabIndex = 1;
            this.contactGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.contactGridView_MouseDoubleClick);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // phno
            // 
            this.phno.HeaderText = "Phone No";
            this.phno.Name = "phno";
            this.phno.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // relation
            // 
            this.relation.HeaderText = "Relation";
            this.relation.Name = "relation";
            this.relation.ReadOnly = true;
            // 
            // favourite
            // 
            this.favourite.HeaderText = "Favourite";
            this.favourite.Name = "favourite";
            this.favourite.ReadOnly = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(224, 355);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(164, 35);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(447, 367);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 3;
            // 
            // ShowContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 413);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.contactGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShowContacts";
            this.Text = "ShowContacts";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboRelation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowAllContacts;
        private System.Windows.Forms.CheckBox chkFavourite;
        private System.Windows.Forms.DataGridView contactGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phno;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn relation;
        private System.Windows.Forms.DataGridViewTextBoxColumn favourite;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblStatus;
    }
}