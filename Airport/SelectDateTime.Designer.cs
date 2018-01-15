namespace Airport
{
    partial class SelectDateTime
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
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_time = new System.Windows.Forms.DateTimePicker();
            this.button_select = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_date.TabIndex = 0;
            this.dateTimePicker_date.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker_date_KeyUp);
            // 
            // dateTimePicker_time
            // 
            this.dateTimePicker_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_time.Location = new System.Drawing.Point(12, 38);
            this.dateTimePicker_time.Name = "dateTimePicker_time";
            this.dateTimePicker_time.ShowUpDown = true;
            this.dateTimePicker_time.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_time.TabIndex = 1;
            this.dateTimePicker_time.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker_time_KeyUp);
            // 
            // button_select
            // 
            this.button_select.Location = new System.Drawing.Point(112, 64);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(100, 23);
            this.button_select.TabIndex = 2;
            this.button_select.Text = "Выбрать";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // SelectDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 96);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.dateTimePicker_time);
            this.Controls.Add(this.dateTimePicker_date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectDateTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбрать дату и время";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_time;
        private System.Windows.Forms.Button button_select;
    }
}