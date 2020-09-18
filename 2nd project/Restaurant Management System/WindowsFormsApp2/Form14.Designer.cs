namespace WindowsFormsApp2
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.client = new System.Windows.Forms.Label();
            this.iteam = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.clienttextBox = new System.Windows.Forms.TextBox();
            this.iteamcomboBox = new System.Windows.Forms.ComboBox();
            this.qcombobox = new System.Windows.Forms.ComboBox();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.totaltextBox = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.printpre = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.pricetextBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.dcomboBox = new System.Windows.Forms.ComboBox();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.pDocument = new System.Drawing.Printing.PrintDocument();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rcomboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Different Taste Restaurant";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // client
            // 
            this.client.AutoSize = true;
            this.client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client.Location = new System.Drawing.Point(157, 86);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(78, 16);
            this.client.TabIndex = 3;
            this.client.Text = "Client name";
            this.client.Click += new System.EventHandler(this.label4_Click);
            // 
            // iteam
            // 
            this.iteam.AutoSize = true;
            this.iteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iteam.Location = new System.Drawing.Point(157, 158);
            this.iteam.Name = "iteam";
            this.iteam.Size = new System.Drawing.Size(78, 16);
            this.iteam.TabIndex = 4;
            this.iteam.Text = "Iteam name";
            this.iteam.Click += new System.EventHandler(this.label5_Click);
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(162, 238);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(56, 16);
            this.Quantity.TabIndex = 5;
            this.Quantity.Text = "Quantity";
            this.Quantity.Click += new System.EventHandler(this.label6_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(162, 297);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(84, 16);
            this.price.TabIndex = 6;
            this.price.Text = "price per unit";
            // 
            // clienttextBox
            // 
            this.clienttextBox.Location = new System.Drawing.Point(342, 82);
            this.clienttextBox.Name = "clienttextBox";
            this.clienttextBox.Size = new System.Drawing.Size(176, 20);
            this.clienttextBox.TabIndex = 7;
            this.clienttextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // iteamcomboBox
            // 
            this.iteamcomboBox.FormattingEnabled = true;
            this.iteamcomboBox.Items.AddRange(new object[] {
            "------",
            "classic beef burger",
            "smash burger",
            "the gangstar burger",
            "classic chicken burger",
            "super big mac ham burger",
            "twilight beef burger",
            "Batman Pizza",
            "Macaroni Pizza",
            "classic Pizza",
            "Dominos Pizza",
            "Spanky Pizza",
            "Super Egg Pizza",
            "Regular Fried Chicken",
            "Mango BBQ Chicken",
            "Korean Chicken",
            "Chicken Souvlaki Kebab",
            "Crispy Fried chicken",
            "Chicken Marsala",
            "Mineral Water",
            "Cocacola",
            "7up",
            "Pepsi",
            "Milk Shake",
            "Lemon Juice",
            "Banana Juice",
            "Lacchi"});
            this.iteamcomboBox.Location = new System.Drawing.Point(342, 158);
            this.iteamcomboBox.Name = "iteamcomboBox";
            this.iteamcomboBox.Size = new System.Drawing.Size(176, 21);
            this.iteamcomboBox.TabIndex = 8;
            this.iteamcomboBox.SelectedIndexChanged += new System.EventHandler(this.iteamcomboBox_SelectedIndexChanged);
            // 
            // qcombobox
            // 
            this.qcombobox.FormattingEnabled = true;
            this.qcombobox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.qcombobox.Location = new System.Drawing.Point(342, 238);
            this.qcombobox.Name = "qcombobox";
            this.qcombobox.Size = new System.Drawing.Size(121, 21);
            this.qcombobox.TabIndex = 9;
            this.qcombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pricetextBox
            // 
            this.pricetextBox.Location = new System.Drawing.Point(342, 296);
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.Size = new System.Drawing.Size(100, 20);
            this.pricetextBox.TabIndex = 10;
            this.pricetextBox.TextChanged += new System.EventHandler(this.pricetextBox_TextChanged);
            // 
            // totaltextBox
            // 
            this.totaltextBox.Location = new System.Drawing.Point(342, 520);
            this.totaltextBox.Name = "totaltextBox";
            this.totaltextBox.Size = new System.Drawing.Size(150, 20);
            this.totaltextBox.TabIndex = 11;
            this.totaltextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(180, 524);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(66, 16);
            this.total.TabIndex = 12;
            this.total.Text = "total price";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(939, 71);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(120, 40);
            this.add.TabIndex = 13;
            this.add.Text = "Add new order";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // printpre
            // 
            this.printpre.Location = new System.Drawing.Point(939, 158);
            this.printpre.Name = "printpre";
            this.printpre.Size = new System.Drawing.Size(120, 40);
            this.printpre.TabIndex = 14;
            this.printpre.Text = "Print  preview";
            this.printpre.UseVisualStyleBackColor = true;
            this.printpre.Click += new System.EventHandler(this.printpre_Click);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(939, 276);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(120, 40);
            this.print.TabIndex = 15;
            this.print.Text = "print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(342, 578);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 34);
            this.Save.TabIndex = 16;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1170, 567);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 74);
            this.Exit.TabIndex = 17;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(342, 381);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(75, 23);
            this.equal.TabIndex = 18;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // pricetextBox2
            // 
            this.pricetextBox2.Location = new System.Drawing.Point(342, 448);
            this.pricetextBox2.Name = "pricetextBox2";
            this.pricetextBox2.Size = new System.Drawing.Size(100, 20);
            this.pricetextBox2.TabIndex = 19;
            this.pricetextBox2.TextChanged += new System.EventHandler(this.pricetextBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Price";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.Location = new System.Drawing.Point(564, 220);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(75, 16);
            this.discount.TabIndex = 21;
            this.discount.Text = "Discount %";
            // 
            // dcomboBox
            // 
            this.dcomboBox.FormattingEnabled = true;
            this.dcomboBox.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100"});
            this.dcomboBox.Location = new System.Drawing.Point(698, 219);
            this.dcomboBox.Name = "dcomboBox";
            this.dcomboBox.Size = new System.Drawing.Size(73, 21);
            this.dcomboBox.TabIndex = 22;
            // 
            // printPreview
            // 
            this.printPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreview.Enabled = true;
            this.printPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreview.Icon")));
            this.printPreview.Name = "printPreview";
            this.printPreview.Visible = false;
            this.printPreview.Load += new System.EventHandler(this.printPreview_Load);
            // 
            // pDocument
            // 
            this.pDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDocument_PrintPage);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(939, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(647, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Rating";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // rcomboBox
            // 
            this.rcomboBox.FormattingEnabled = true;
            this.rcomboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.rcomboBox.Location = new System.Drawing.Point(709, 335);
            this.rcomboBox.Name = "rcomboBox";
            this.rcomboBox.Size = new System.Drawing.Size(53, 21);
            this.rcomboBox.TabIndex = 23;
            this.rcomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 26;
            this.button1.Text = "New record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 628);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "-----------------------------------------------------------------";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1350, 749);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rcomboBox);
            this.Controls.Add(this.dcomboBox);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pricetextBox2);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.print);
            this.Controls.Add(this.printpre);
            this.Controls.Add(this.add);
            this.Controls.Add(this.total);
            this.Controls.Add(this.totaltextBox);
            this.Controls.Add(this.pricetextBox);
            this.Controls.Add(this.qcombobox);
            this.Controls.Add(this.iteamcomboBox);
            this.Controls.Add(this.clienttextBox);
            this.Controls.Add(this.price);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.iteam);
            this.Controls.Add(this.client);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form14";
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label client;
        private System.Windows.Forms.Label iteam;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox clienttextBox;
        private System.Windows.Forms.ComboBox iteamcomboBox;
        private System.Windows.Forms.ComboBox qcombobox;
        private System.Windows.Forms.TextBox pricetextBox;
        private System.Windows.Forms.TextBox totaltextBox;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button printpre;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.TextBox pricetextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.ComboBox dcomboBox;
        private System.Windows.Forms.PrintPreviewDialog printPreview;
        private System.Drawing.Printing.PrintDocument pDocument;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox rcomboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}