namespace Airport
{
    partial class EditAirport
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.button_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(75, 15);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(160, 20);
            this.textBox_name.TabIndex = 0;
            this.textBox_name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_name_KeyUp);
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(75, 41);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(160, 20);
            this.textBox_address.TabIndex = 1;
            this.textBox_address.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_address_KeyUp);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 18);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(57, 13);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Название";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(31, 44);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(38, 13);
            this.label_address.TabIndex = 3;
            this.label_address.Text = "Адрес";
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(135, 67);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(100, 23);
            this.button_edit.TabIndex = 4;
            this.button_edit.Text = "Изменить";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // EditAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 101);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditAirport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Аэропорт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Button button_edit;
    }
}