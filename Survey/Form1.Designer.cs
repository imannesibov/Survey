namespace Survey
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.customerText = new System.Windows.Forms.TextBox();
            this.Survey = new System.Windows.Forms.GroupBox();
            this.genderlbl = new System.Windows.Forms.Label();
            this.femalegender = new System.Windows.Forms.RadioButton();
            this.malegender = new System.Windows.Forms.RadioButton();
            this.birthdaycl = new System.Windows.Forms.DateTimePicker();
            this.birthdaylbl = new System.Windows.Forms.Label();
            this.phonelbl = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.citylbl = new System.Windows.Forms.Label();
            this.cityText = new System.Windows.Forms.TextBox();
            this.countrylbl = new System.Windows.Forms.Label();
            this.countryText = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.Label();
            this.dadname = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.surnamelbl = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.Survey.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerText
            // 
            this.customerText.Location = new System.Drawing.Point(134, 12);
            this.customerText.Name = "customerText";
            this.customerText.Size = new System.Drawing.Size(100, 20);
            this.customerText.TabIndex = 5;
            // 
            // Survey
            // 
            this.Survey.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Survey.Controls.Add(this.genderlbl);
            this.Survey.Controls.Add(this.femalegender);
            this.Survey.Controls.Add(this.malegender);
            this.Survey.Controls.Add(this.birthdaycl);
            this.Survey.Controls.Add(this.birthdaylbl);
            this.Survey.Controls.Add(this.phonelbl);
            this.Survey.Controls.Add(this.phoneText);
            this.Survey.Controls.Add(this.citylbl);
            this.Survey.Controls.Add(this.cityText);
            this.Survey.Controls.Add(this.countrylbl);
            this.Survey.Controls.Add(this.countryText);
            this.Survey.Controls.Add(this.fname);
            this.Survey.Controls.Add(this.dadname);
            this.Survey.Controls.Add(this.namelbl);
            this.Survey.Controls.Add(this.name);
            this.Survey.Controls.Add(this.surnamelbl);
            this.Survey.Controls.Add(this.surname);
            this.Survey.Location = new System.Drawing.Point(13, 47);
            this.Survey.Name = "Survey";
            this.Survey.Size = new System.Drawing.Size(390, 433);
            this.Survey.TabIndex = 4;
            this.Survey.TabStop = false;
            this.Survey.Text = "Survey";
            this.Survey.Enter += new System.EventHandler(this.Survey_Enter_1);
            // 
            // genderlbl
            // 
            this.genderlbl.AutoSize = true;
            this.genderlbl.Location = new System.Drawing.Point(60, 404);
            this.genderlbl.Name = "genderlbl";
            this.genderlbl.Size = new System.Drawing.Size(42, 13);
            this.genderlbl.TabIndex = 18;
            this.genderlbl.Text = "Gender";
            // 
            // femalegender
            // 
            this.femalegender.AutoSize = true;
            this.femalegender.Location = new System.Drawing.Point(217, 400);
            this.femalegender.Name = "femalegender";
            this.femalegender.Size = new System.Drawing.Size(59, 17);
            this.femalegender.TabIndex = 17;
            this.femalegender.TabStop = true;
            this.femalegender.Text = "Female";
            this.femalegender.UseVisualStyleBackColor = true;
            // 
            // malegender
            // 
            this.malegender.AutoSize = true;
            this.malegender.Location = new System.Drawing.Point(136, 400);
            this.malegender.Name = "malegender";
            this.malegender.Size = new System.Drawing.Size(48, 17);
            this.malegender.TabIndex = 16;
            this.malegender.TabStop = true;
            this.malegender.Text = "Male";
            this.malegender.UseVisualStyleBackColor = true;
            // 
            // birthdaycl
            // 
            this.birthdaycl.Location = new System.Drawing.Point(121, 356);
            this.birthdaycl.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.birthdaycl.Name = "birthdaycl";
            this.birthdaycl.Size = new System.Drawing.Size(188, 20);
            this.birthdaycl.TabIndex = 15;
            this.birthdaycl.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // birthdaylbl
            // 
            this.birthdaylbl.AutoSize = true;
            this.birthdaylbl.Location = new System.Drawing.Point(59, 356);
            this.birthdaylbl.Name = "birthdaylbl";
            this.birthdaylbl.Size = new System.Drawing.Size(47, 13);
            this.birthdaylbl.TabIndex = 14;
            this.birthdaylbl.Text = "BirthDay";
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.Location = new System.Drawing.Point(59, 297);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(38, 13);
            this.phonelbl.TabIndex = 13;
            this.phonelbl.Text = "Phone";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(121, 294);
            this.phoneText.Margin = new System.Windows.Forms.Padding(9);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(188, 20);
            this.phoneText.TabIndex = 12;
            // 
            // citylbl
            // 
            this.citylbl.AutoSize = true;
            this.citylbl.Location = new System.Drawing.Point(59, 247);
            this.citylbl.Name = "citylbl";
            this.citylbl.Size = new System.Drawing.Size(24, 13);
            this.citylbl.TabIndex = 11;
            this.citylbl.Text = "City";
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(121, 244);
            this.cityText.Margin = new System.Windows.Forms.Padding(9);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(188, 20);
            this.cityText.TabIndex = 10;
            // 
            // countrylbl
            // 
            this.countrylbl.AutoSize = true;
            this.countrylbl.Location = new System.Drawing.Point(59, 204);
            this.countrylbl.Name = "countrylbl";
            this.countrylbl.Size = new System.Drawing.Size(43, 13);
            this.countrylbl.TabIndex = 9;
            this.countrylbl.Text = "Country";
            // 
            // countryText
            // 
            this.countryText.Location = new System.Drawing.Point(121, 197);
            this.countryText.Margin = new System.Windows.Forms.Padding(9);
            this.countryText.Name = "countryText";
            this.countryText.Size = new System.Drawing.Size(188, 20);
            this.countryText.TabIndex = 8;
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(47, 135);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(68, 13);
            this.fname.TabIndex = 7;
            this.fname.Text = "Father Name";
            // 
            // dadname
            // 
            this.dadname.Location = new System.Drawing.Point(121, 132);
            this.dadname.Margin = new System.Windows.Forms.Padding(9);
            this.dadname.Name = "dadname";
            this.dadname.Size = new System.Drawing.Size(188, 20);
            this.dadname.TabIndex = 6;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(47, 85);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(35, 13);
            this.namelbl.TabIndex = 5;
            this.namelbl.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(121, 82);
            this.name.Margin = new System.Windows.Forms.Padding(9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(188, 20);
            this.name.TabIndex = 4;
            // 
            // surnamelbl
            // 
            this.surnamelbl.AutoSize = true;
            this.surnamelbl.Location = new System.Drawing.Point(47, 42);
            this.surnamelbl.Name = "surnamelbl";
            this.surnamelbl.Size = new System.Drawing.Size(49, 13);
            this.surnamelbl.TabIndex = 3;
            this.surnamelbl.Text = "Surname";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(121, 35);
            this.surname.Margin = new System.Windows.Forms.Padding(9);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(188, 20);
            this.surname.TabIndex = 2;
            // 
            // loadBtn
            // 
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.Image = global::Survey.Properties.Resources.Double_J_Design_Super_Mono_3d_Load_download;
            this.loadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadBtn.Location = new System.Drawing.Point(270, 10);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(118, 36);
            this.loadBtn.TabIndex = 3;
            this.loadBtn.Text = "LOAD";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Image = global::Survey.Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Save;
            this.savebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savebtn.Location = new System.Drawing.Point(28, 486);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(360, 39);
            this.savebtn.TabIndex = 1;
            this.savebtn.Text = "SAVE";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(413, 537);
            this.Controls.Add(this.customerText);
            this.Controls.Add(this.Survey);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.savebtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Survey";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Survey.ResumeLayout(false);
            this.Survey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.TextBox customerText;
        private System.Windows.Forms.GroupBox Survey;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label surnamelbl;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label phonelbl;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label citylbl;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Label countrylbl;
        private System.Windows.Forms.TextBox countryText;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.TextBox dadname;
        private System.Windows.Forms.DateTimePicker birthdaycl;
        private System.Windows.Forms.Label birthdaylbl;
        private System.Windows.Forms.Label genderlbl;
        private System.Windows.Forms.RadioButton femalegender;
        private System.Windows.Forms.RadioButton malegender;
    }
}

