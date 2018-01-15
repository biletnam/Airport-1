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
            this.textBox_aircraftModel = new System.Windows.Forms.TextBox();
            this.textBox_aircraftSerialNumber = new System.Windows.Forms.TextBox();
            this.numericUpDown_aircraftSeats = new System.Windows.Forms.NumericUpDown();
            this.textBox_pilotFullName = new System.Windows.Forms.TextBox();
            this.textBox_pilotPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_pilotHomeAddress = new System.Windows.Forms.TextBox();
            this.textBox_pilotLicenseNumber = new System.Windows.Forms.TextBox();
            this.groupBox_aircraft = new System.Windows.Forms.GroupBox();
            this.groupBox_pilot = new System.Windows.Forms.GroupBox();
            this.label_aircraftModel = new System.Windows.Forms.Label();
            this.label_aircraftSerialNumber = new System.Windows.Forms.Label();
            this.label_aircraftSeats = new System.Windows.Forms.Label();
            this.label_pilotFullName = new System.Windows.Forms.Label();
            this.label_pilotHomeAddress = new System.Windows.Forms.Label();
            this.label_pilotPhoneNumber = new System.Windows.Forms.Label();
            this.label_pilotLicenseNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_aircraftSeats)).BeginInit();
            this.groupBox_aircraft.SuspendLayout();
            this.groupBox_pilot.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(428, 147);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(100, 23);
            this.button_edit.TabIndex = 5;
            this.button_edit.Text = "Изменить";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // textBox_aircraftModel
            // 
            this.textBox_aircraftModel.Location = new System.Drawing.Point(58, 19);
            this.textBox_aircraftModel.Name = "textBox_aircraftModel";
            this.textBox_aircraftModel.Size = new System.Drawing.Size(160, 20);
            this.textBox_aircraftModel.TabIndex = 6;
            this.textBox_aircraftModel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_aircraftModel_KeyUp);
            // 
            // textBox_aircraftSerialNumber
            // 
            this.textBox_aircraftSerialNumber.Location = new System.Drawing.Point(58, 45);
            this.textBox_aircraftSerialNumber.Name = "textBox_aircraftSerialNumber";
            this.textBox_aircraftSerialNumber.Size = new System.Drawing.Size(160, 20);
            this.textBox_aircraftSerialNumber.TabIndex = 7;
            this.textBox_aircraftSerialNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_aircraftSerialNumber_KeyUp);
            // 
            // numericUpDown_aircraftSeats
            // 
            this.numericUpDown_aircraftSeats.Location = new System.Drawing.Point(58, 71);
            this.numericUpDown_aircraftSeats.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_aircraftSeats.Name = "numericUpDown_aircraftSeats";
            this.numericUpDown_aircraftSeats.Size = new System.Drawing.Size(160, 20);
            this.numericUpDown_aircraftSeats.TabIndex = 8;
            this.numericUpDown_aircraftSeats.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_aircraftSeats_KeyUp);
            // 
            // textBox_pilotFullName
            // 
            this.textBox_pilotFullName.Location = new System.Drawing.Point(107, 18);
            this.textBox_pilotFullName.Name = "textBox_pilotFullName";
            this.textBox_pilotFullName.Size = new System.Drawing.Size(160, 20);
            this.textBox_pilotFullName.TabIndex = 9;
            this.textBox_pilotFullName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_pilotFullName_KeyUp);
            // 
            // textBox_pilotPhoneNumber
            // 
            this.textBox_pilotPhoneNumber.Location = new System.Drawing.Point(107, 44);
            this.textBox_pilotPhoneNumber.Name = "textBox_pilotPhoneNumber";
            this.textBox_pilotPhoneNumber.Size = new System.Drawing.Size(160, 20);
            this.textBox_pilotPhoneNumber.TabIndex = 10;
            this.textBox_pilotPhoneNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_pilotPhoneNumber_KeyUp);
            // 
            // textBox_pilotHomeAddress
            // 
            this.textBox_pilotHomeAddress.Location = new System.Drawing.Point(107, 70);
            this.textBox_pilotHomeAddress.Name = "textBox_pilotHomeAddress";
            this.textBox_pilotHomeAddress.Size = new System.Drawing.Size(160, 20);
            this.textBox_pilotHomeAddress.TabIndex = 11;
            this.textBox_pilotHomeAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_pilotHomeAddress_KeyUp);
            // 
            // textBox_pilotLicenseNumber
            // 
            this.textBox_pilotLicenseNumber.Location = new System.Drawing.Point(107, 96);
            this.textBox_pilotLicenseNumber.Name = "textBox_pilotLicenseNumber";
            this.textBox_pilotLicenseNumber.Size = new System.Drawing.Size(160, 20);
            this.textBox_pilotLicenseNumber.TabIndex = 12;
            this.textBox_pilotLicenseNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_pilotLicenseNumber_KeyUp);
            // 
            // groupBox_aircraft
            // 
            this.groupBox_aircraft.Controls.Add(this.label_aircraftSeats);
            this.groupBox_aircraft.Controls.Add(this.label_aircraftSerialNumber);
            this.groupBox_aircraft.Controls.Add(this.label_aircraftModel);
            this.groupBox_aircraft.Controls.Add(this.textBox_aircraftModel);
            this.groupBox_aircraft.Controls.Add(this.textBox_aircraftSerialNumber);
            this.groupBox_aircraft.Controls.Add(this.numericUpDown_aircraftSeats);
            this.groupBox_aircraft.Location = new System.Drawing.Point(12, 12);
            this.groupBox_aircraft.Name = "groupBox_aircraft";
            this.groupBox_aircraft.Size = new System.Drawing.Size(230, 129);
            this.groupBox_aircraft.TabIndex = 13;
            this.groupBox_aircraft.TabStop = false;
            this.groupBox_aircraft.Text = "Самолет";
            // 
            // groupBox_pilot
            // 
            this.groupBox_pilot.Controls.Add(this.label_pilotLicenseNumber);
            this.groupBox_pilot.Controls.Add(this.label_pilotPhoneNumber);
            this.groupBox_pilot.Controls.Add(this.label_pilotHomeAddress);
            this.groupBox_pilot.Controls.Add(this.label_pilotFullName);
            this.groupBox_pilot.Controls.Add(this.textBox_pilotFullName);
            this.groupBox_pilot.Controls.Add(this.textBox_pilotPhoneNumber);
            this.groupBox_pilot.Controls.Add(this.textBox_pilotLicenseNumber);
            this.groupBox_pilot.Controls.Add(this.textBox_pilotHomeAddress);
            this.groupBox_pilot.Location = new System.Drawing.Point(248, 12);
            this.groupBox_pilot.Name = "groupBox_pilot";
            this.groupBox_pilot.Size = new System.Drawing.Size(280, 129);
            this.groupBox_pilot.TabIndex = 14;
            this.groupBox_pilot.TabStop = false;
            this.groupBox_pilot.Text = "Главный пилот";
            // 
            // label_aircraftModel
            // 
            this.label_aircraftModel.AutoSize = true;
            this.label_aircraftModel.Location = new System.Drawing.Point(6, 22);
            this.label_aircraftModel.Name = "label_aircraftModel";
            this.label_aircraftModel.Size = new System.Drawing.Size(46, 13);
            this.label_aircraftModel.TabIndex = 9;
            this.label_aircraftModel.Text = "Модель";
            // 
            // label_aircraftSerialNumber
            // 
            this.label_aircraftSerialNumber.AutoSize = true;
            this.label_aircraftSerialNumber.Location = new System.Drawing.Point(11, 48);
            this.label_aircraftSerialNumber.Name = "label_aircraftSerialNumber";
            this.label_aircraftSerialNumber.Size = new System.Drawing.Size(41, 13);
            this.label_aircraftSerialNumber.TabIndex = 10;
            this.label_aircraftSerialNumber.Text = "Номер";
            // 
            // label_aircraftSeats
            // 
            this.label_aircraftSeats.AutoSize = true;
            this.label_aircraftSeats.Location = new System.Drawing.Point(19, 73);
            this.label_aircraftSeats.Name = "label_aircraftSeats";
            this.label_aircraftSeats.Size = new System.Drawing.Size(33, 13);
            this.label_aircraftSeats.TabIndex = 11;
            this.label_aircraftSeats.Text = "Мест";
            // 
            // label_pilotFullName
            // 
            this.label_pilotFullName.AutoSize = true;
            this.label_pilotFullName.Location = new System.Drawing.Point(67, 21);
            this.label_pilotFullName.Name = "label_pilotFullName";
            this.label_pilotFullName.Size = new System.Drawing.Size(34, 13);
            this.label_pilotFullName.TabIndex = 13;
            this.label_pilotFullName.Text = "ФИО";
            // 
            // label_pilotHomeAddress
            // 
            this.label_pilotHomeAddress.AutoSize = true;
            this.label_pilotHomeAddress.Location = new System.Drawing.Point(6, 73);
            this.label_pilotHomeAddress.Name = "label_pilotHomeAddress";
            this.label_pilotHomeAddress.Size = new System.Drawing.Size(95, 13);
            this.label_pilotHomeAddress.TabIndex = 14;
            this.label_pilotHomeAddress.Text = "Домашний адрес";
            // 
            // label_pilotPhoneNumber
            // 
            this.label_pilotPhoneNumber.AutoSize = true;
            this.label_pilotPhoneNumber.Location = new System.Drawing.Point(8, 47);
            this.label_pilotPhoneNumber.Name = "label_pilotPhoneNumber";
            this.label_pilotPhoneNumber.Size = new System.Drawing.Size(93, 13);
            this.label_pilotPhoneNumber.TabIndex = 15;
            this.label_pilotPhoneNumber.Text = "Номер телефона";
            // 
            // label_pilotLicenseNumber
            // 
            this.label_pilotLicenseNumber.AutoSize = true;
            this.label_pilotLicenseNumber.Location = new System.Drawing.Point(9, 99);
            this.label_pilotLicenseNumber.Name = "label_pilotLicenseNumber";
            this.label_pilotLicenseNumber.Size = new System.Drawing.Size(92, 13);
            this.label_pilotLicenseNumber.TabIndex = 16;
            this.label_pilotLicenseNumber.Text = "Номер лицензии";
            // 
            // EditAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 181);
            this.Controls.Add(this.groupBox_pilot);
            this.Controls.Add(this.groupBox_aircraft);
            this.Controls.Add(this.button_edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditAircraft";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Самолет";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_aircraftSeats)).EndInit();
            this.groupBox_aircraft.ResumeLayout(false);
            this.groupBox_aircraft.PerformLayout();
            this.groupBox_pilot.ResumeLayout(false);
            this.groupBox_pilot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.TextBox textBox_aircraftModel;
        private System.Windows.Forms.TextBox textBox_aircraftSerialNumber;
        private System.Windows.Forms.NumericUpDown numericUpDown_aircraftSeats;
        private System.Windows.Forms.TextBox textBox_pilotFullName;
        private System.Windows.Forms.TextBox textBox_pilotPhoneNumber;
        private System.Windows.Forms.TextBox textBox_pilotHomeAddress;
        private System.Windows.Forms.TextBox textBox_pilotLicenseNumber;
        private System.Windows.Forms.GroupBox groupBox_aircraft;
        private System.Windows.Forms.GroupBox groupBox_pilot;
        private System.Windows.Forms.Label label_aircraftSeats;
        private System.Windows.Forms.Label label_aircraftSerialNumber;
        private System.Windows.Forms.Label label_aircraftModel;
        private System.Windows.Forms.Label label_pilotLicenseNumber;
        private System.Windows.Forms.Label label_pilotPhoneNumber;
        private System.Windows.Forms.Label label_pilotHomeAddress;
        private System.Windows.Forms.Label label_pilotFullName;
    }
}