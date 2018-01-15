namespace Airport
{
    partial class EditAircraft
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
            this.button_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(143, 186);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(100, 23);
            this.button_edit.TabIndex = 5;
            this.button_edit.Text = "Изменить";
            this.button_edit.UseVisualStyleBackColor = true;
            // 
            // EditAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditAircraft";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Самолет";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_edit;
    }
}