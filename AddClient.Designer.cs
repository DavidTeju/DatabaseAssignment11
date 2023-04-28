using System.ComponentModel;

namespace DatabaseAssignment11
{
    partial class AddClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.nameLabel = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(43, 54);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(196, 44);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Full Name:";
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(279, 51);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(244, 31);
            this.fullName.TabIndex = 1;
            this.fullName.TextChanged += new System.EventHandler(this.UpdateSubmitButtonState);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(279, 121);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(244, 31);
            this.ageTextBox.TabIndex = 5;
            this.ageTextBox.TextChanged += new System.EventHandler(this.UpdateSubmitButtonState);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(43, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age:";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] { "M", "F", "N" });
            this.genderComboBox.Location = new System.Drawing.Point(279, 193);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(244, 33);
            this.genderComboBox.TabIndex = 6;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.UpdateSubmitButtonState);
            // 
            // submitButton
            // 
            this.submitButton.Enabled = false;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(188, 290);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(170, 64);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 408);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button submitButton;

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox genderComboBox;

        #endregion
    }
}