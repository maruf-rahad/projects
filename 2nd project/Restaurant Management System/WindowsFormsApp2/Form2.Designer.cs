namespace WindowsFormsApp2
{
    partial class Form2
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
            this.Burger = new System.Windows.Forms.Button();
            this.Pizza = new System.Windows.Forms.Button();
            this.Drinks = new System.Windows.Forms.Button();
            this.Chicken = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Burger
            // 
            this.Burger.BackColor = System.Drawing.Color.Lime;
            this.Burger.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Burger.Location = new System.Drawing.Point(192, 61);
            this.Burger.Name = "Burger";
            this.Burger.Size = new System.Drawing.Size(375, 216);
            this.Burger.TabIndex = 0;
            this.Burger.Text = "Burger";
            this.Burger.UseVisualStyleBackColor = false;
            this.Burger.Click += new System.EventHandler(this.Burger_Click);
            // 
            // Pizza
            // 
            this.Pizza.BackColor = System.Drawing.Color.Gold;
            this.Pizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pizza.Location = new System.Drawing.Point(723, 61);
            this.Pizza.Name = "Pizza";
            this.Pizza.Size = new System.Drawing.Size(350, 216);
            this.Pizza.TabIndex = 1;
            this.Pizza.Text = "Pizza";
            this.Pizza.UseVisualStyleBackColor = false;
            this.Pizza.Click += new System.EventHandler(this.Pizza_Click);
            // 
            // Drinks
            // 
            this.Drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drinks.Location = new System.Drawing.Point(723, 346);
            this.Drinks.Name = "Drinks";
            this.Drinks.Size = new System.Drawing.Size(350, 235);
            this.Drinks.TabIndex = 3;
            this.Drinks.Text = "Drinks";
            this.Drinks.UseVisualStyleBackColor = true;
            this.Drinks.Click += new System.EventHandler(this.Drinks_Click);
            // 
            // Chicken
            // 
            this.Chicken.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Chicken.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chicken.Location = new System.Drawing.Point(192, 346);
            this.Chicken.Name = "Chicken";
            this.Chicken.Size = new System.Drawing.Size(375, 235);
            this.Chicken.TabIndex = 6;
            this.Chicken.Text = "Chicken";
            this.Chicken.UseVisualStyleBackColor = false;
            this.Chicken.Click += new System.EventHandler(this.Chicken_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(1157, 534);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(96, 89);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1353, 749);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Chicken);
            this.Controls.Add(this.Drinks);
            this.Controls.Add(this.Pizza);
            this.Controls.Add(this.Burger);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Burger;
        private System.Windows.Forms.Button Pizza;
        private System.Windows.Forms.Button Drinks;
        private System.Windows.Forms.Button Chicken;
        private System.Windows.Forms.Button Exit;
    }
}