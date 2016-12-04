namespace BeersBought
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
            System.Windows.Forms.Label label1;
            this.textCustomerID = new System.Windows.Forms.TextBox();
            this.buttonSearchID = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBudLight = new System.Windows.Forms.Button();
            this.quantityBought = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 13);
            label1.TabIndex = 1;
            label1.Text = "Customer ID";
            // 
            // textCustomerID
            // 
            this.textCustomerID.Location = new System.Drawing.Point(83, 26);
            this.textCustomerID.Name = "textCustomerID";
            this.textCustomerID.Size = new System.Drawing.Size(100, 20);
            this.textCustomerID.TabIndex = 0;
            // 
            // buttonSearchID
            // 
            this.buttonSearchID.Location = new System.Drawing.Point(189, 23);
            this.buttonSearchID.Name = "buttonSearchID";
            this.buttonSearchID.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchID.TabIndex = 2;
            this.buttonSearchID.Text = "Search";
            this.buttonSearchID.UseVisualStyleBackColor = true;
            this.buttonSearchID.Click += new System.EventHandler(this.buttonSearchID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Beers Bought:";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::BeersBought.Properties.Resources.coors_light_inflatable_rafts_point_of_sale__large;
            this.button4.Location = new System.Drawing.Point(363, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 119);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::BeersBought.Properties.Resources.ba19718cb2c2c335a1bcbb98d0d50c14;
            this.button3.Location = new System.Drawing.Point(189, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 119);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnBudLight
            // 
            this.btnBudLight.BackgroundImage = global::BeersBought.Properties.Resources._4323923_54618c92f00c5;
            this.btnBudLight.Location = new System.Drawing.Point(15, 155);
            this.btnBudLight.Name = "btnBudLight";
            this.btnBudLight.Size = new System.Drawing.Size(168, 119);
            this.btnBudLight.TabIndex = 4;
            this.btnBudLight.Text = "button2";
            this.btnBudLight.UseVisualStyleBackColor = true;
            this.btnBudLight.Click += new System.EventHandler(this.btnBudLight_Click);
            // 
            // quantityBought
            // 
            this.quantityBought.AutoSize = true;
            this.quantityBought.Location = new System.Drawing.Point(160, 118);
            this.quantityBought.Name = "quantityBought";
            this.quantityBought.Size = new System.Drawing.Size(35, 13);
            this.quantityBought.TabIndex = 7;
            this.quantityBought.Text = "label3";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(50, 66);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(57, 13);
            this.firstName.TabIndex = 8;
            this.firstName.Text = "FirstName:";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(50, 89);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(58, 13);
            this.lastName.TabIndex = 9;
            this.lastName.Text = "LastName:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(160, 89);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(35, 13);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "label3";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(160, 66);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(35, 13);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 281);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.quantityBought);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBudLight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSearchID);
            this.Controls.Add(label1);
            this.Controls.Add(this.textCustomerID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCustomerID;
        private System.Windows.Forms.Button buttonSearchID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBudLight;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label quantityBought;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
    }
}

