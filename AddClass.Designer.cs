using System.ComponentModel;

namespace DatabaseAssignment11
{
    partial class AddClass
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
            this.instructorNameCombo = new System.Windows.Forms.ComboBox();
            this.instructorNameLabel = new System.Windows.Forms.Label();
            this.classDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructorNameCombo
            // 
            this.instructorNameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instructorNameCombo.FormattingEnabled = true;
            this.instructorNameCombo.Location = new System.Drawing.Point(249, 44);
            this.instructorNameCombo.Name = "instructorNameCombo";
            this.instructorNameCombo.Size = new System.Drawing.Size(250, 33);
            this.instructorNameCombo.TabIndex = 0;
            this.instructorNameCombo.SelectedIndexChanged += new System.EventHandler(this.ClearError);
            // 
            // instructorNameLabel
            // 
            this.instructorNameLabel.Location = new System.Drawing.Point(53, 47);
            this.instructorNameLabel.Name = "instructorNameLabel";
            this.instructorNameLabel.Size = new System.Drawing.Size(190, 34);
            this.instructorNameLabel.TabIndex = 1;
            this.instructorNameLabel.Text = "Instructor Name:";
            // 
            // classDatePicker
            // 
            this.classDatePicker.Location = new System.Drawing.Point(249, 105);
            this.classDatePicker.Name = "classDatePicker";
            this.classDatePicker.Size = new System.Drawing.Size(296, 31);
            this.classDatePicker.TabIndex = 2;
            this.classDatePicker.ValueChanged += new System.EventHandler(this.ClearError);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(53, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(53, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time:";
            // 
            // timePicker
            // 
            this.timePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timePicker.FormattingEnabled = true;
            this.timePicker.Location = new System.Drawing.Point(249, 164);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(135, 33);
            this.timePicker.TabIndex = 5;
            this.timePicker.SelectedIndexChanged += new System.EventHandler(this.ClearError);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(65, 285);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(160, 46);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Add";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classDatePicker);
            this.Controls.Add(this.instructorNameLabel);
            this.Controls.Add(this.instructorNameCombo);
            this.Name = "AddClass";
            this.Text = "AddClass";
            this.Load += new System.EventHandler(this.AddClass_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button submitButton;

        private System.Windows.Forms.ComboBox instructorNameCombo;
        private System.Windows.Forms.Label instructorNameLabel;
        private System.Windows.Forms.DateTimePicker classDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox timePicker;

        #endregion
    }
}