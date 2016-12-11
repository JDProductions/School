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
            this.btnBudLight = new System.Windows.Forms.Button();
            this.quantityBought = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBeerName = new System.Windows.Forms.TextBox();
            this.btnAddBeer = new System.Windows.Forms.Button();
            this.txtBreweryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeleteCustomer = new System.Windows.Forms.TextBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
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
            // btnBudLight
            // 
            this.btnBudLight.BackgroundImage = global::BeersBought.Properties.Resources._4323923_54618c92f00c5;
            this.btnBudLight.Location = new System.Drawing.Point(15, 155);
            this.btnBudLight.Name = "btnBudLight";
            this.btnBudLight.Size = new System.Drawing.Size(168, 119);
            this.btnBudLight.TabIndex = 4;
            this.btnBudLight.UseVisualStyleBackColor = true;
            this.btnBudLight.Click += new System.EventHandler(this.btnBudLight_Click);
            // 
            // quantityBought
            // 
            this.quantityBought.AutoSize = true;
            this.quantityBought.Location = new System.Drawing.Point(160, 118);
            this.quantityBought.Name = "quantityBought";
            this.quantityBought.Size = new System.Drawing.Size(0, 13);
            this.quantityBought.TabIndex = 7;
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
            this.lblLastName.Size = new System.Drawing.Size(0, 13);
            this.lblLastName.TabIndex = 10;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(160, 66);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(0, 13);
            this.lblFirstName.TabIndex = 11;
            // 
            // txtBeerName
            // 
            this.txtBeerName.Location = new System.Drawing.Point(325, 82);
            this.txtBeerName.Name = "txtBeerName";
            this.txtBeerName.Size = new System.Drawing.Size(100, 20);
            this.txtBeerName.TabIndex = 12;
            // 
            // btnAddBeer
            // 
            this.btnAddBeer.Location = new System.Drawing.Point(471, 108);
            this.btnAddBeer.Name = "btnAddBeer";
            this.btnAddBeer.Size = new System.Drawing.Size(75, 23);
            this.btnAddBeer.TabIndex = 13;
            this.btnAddBeer.Text = "Add";
            this.btnAddBeer.UseVisualStyleBackColor = true;
            this.btnAddBeer.Click += new System.EventHandler(this.btnAddBeer_Click);
            // 
            // txtBreweryName
            // 
            this.txtBreweryName.Location = new System.Drawing.Point(446, 82);
            this.txtBreweryName.Name = "txtBreweryName";
            this.txtBreweryName.Size = new System.Drawing.Size(100, 20);
            this.txtBreweryName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Beer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Brewery Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Delete Customer ID:";
            // 
            // txtDeleteCustomer
            // 
            this.txtDeleteCustomer.Location = new System.Drawing.Point(328, 172);
            this.txtDeleteCustomer.Name = "txtDeleteCustomer";
            this.txtDeleteCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteCustomer.TabIndex = 18;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(471, 169);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCustomer.TabIndex = 19;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 281);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.txtDeleteCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBreweryName);
            this.Controls.Add(this.btnAddBeer);
            this.Controls.Add(this.txtBeerName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.quantityBought);
            this.Controls.Add(this.btnBudLight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSearchID);
            this.Controls.Add(label1);
            this.Controls.Add(this.textCustomerID);
            this.Name = "Form1";
            this.Text = "BeersBought";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCustomerID;
        private System.Windows.Forms.Button buttonSearchID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBudLight;
        private System.Windows.Forms.Label quantityBought;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBeerName;
        private System.Windows.Forms.Button btnAddBeer;
        private System.Windows.Forms.TextBox txtBreweryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeleteCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
    }
}

