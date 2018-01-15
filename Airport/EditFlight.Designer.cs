namespace Airport
{
    partial class EditFlight
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
            this.comboBox_flightType = new System.Windows.Forms.ComboBox();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.textBox_departureTime = new System.Windows.Forms.TextBox();
            this.textBox_arrivalTime = new System.Windows.Forms.TextBox();
            this.comboBox_departurePoint = new System.Windows.Forms.ComboBox();
            this.comboBox_arrivalPoint = new System.Windows.Forms.ComboBox();
            this.comboBox_plane = new System.Windows.Forms.ComboBox();
            this.label_flightType = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.label_arrivalTime = new System.Windows.Forms.Label();
            this.label_departureTime = new System.Windows.Forms.Label();
            this.label_departurePoint = new System.Windows.Forms.Label();
            this.label_arrivalPoint = new System.Windows.Forms.Label();
            this.button_edit = new System.Windows.Forms.Button();
            this.label_plane = new System.Windows.Forms.Label();
            this.button_departureTime = new System.Windows.Forms.Button();
            this.button_arrivalTime = new System.Windows.Forms.Button();
            this.groupBox_flight = new System.Windows.Forms.GroupBox();
            this.groupBox_tickets = new System.Windows.Forms.GroupBox();
            this.button_removeTicket = new System.Windows.Forms.Button();
            this.button_sellTicket = new System.Windows.Forms.Button();
            this.dataGridView_tickets = new System.Windows.Forms.DataGridView();
            this.groupBox_flight.SuspendLayout();
            this.groupBox_tickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tickets)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_flightType
            // 
            this.comboBox_flightType.FormattingEnabled = true;
            this.comboBox_flightType.Location = new System.Drawing.Point(150, 18);
            this.comboBox_flightType.Name = "comboBox_flightType";
            this.comboBox_flightType.Size = new System.Drawing.Size(160, 21);
            this.comboBox_flightType.TabIndex = 0;
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(150, 45);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(160, 20);
            this.textBox_number.TabIndex = 2;
            // 
            // textBox_departureTime
            // 
            this.textBox_departureTime.Location = new System.Drawing.Point(150, 71);
            this.textBox_departureTime.Name = "textBox_departureTime";
            this.textBox_departureTime.ReadOnly = true;
            this.textBox_departureTime.Size = new System.Drawing.Size(90, 20);
            this.textBox_departureTime.TabIndex = 3;
            // 
            // textBox_arrivalTime
            // 
            this.textBox_arrivalTime.Location = new System.Drawing.Point(150, 97);
            this.textBox_arrivalTime.Name = "textBox_arrivalTime";
            this.textBox_arrivalTime.ReadOnly = true;
            this.textBox_arrivalTime.Size = new System.Drawing.Size(90, 20);
            this.textBox_arrivalTime.TabIndex = 4;
            // 
            // comboBox_departurePoint
            // 
            this.comboBox_departurePoint.FormattingEnabled = true;
            this.comboBox_departurePoint.Location = new System.Drawing.Point(150, 123);
            this.comboBox_departurePoint.Name = "comboBox_departurePoint";
            this.comboBox_departurePoint.Size = new System.Drawing.Size(160, 21);
            this.comboBox_departurePoint.TabIndex = 5;
            // 
            // comboBox_arrivalPoint
            // 
            this.comboBox_arrivalPoint.FormattingEnabled = true;
            this.comboBox_arrivalPoint.Location = new System.Drawing.Point(150, 150);
            this.comboBox_arrivalPoint.Name = "comboBox_arrivalPoint";
            this.comboBox_arrivalPoint.Size = new System.Drawing.Size(160, 21);
            this.comboBox_arrivalPoint.TabIndex = 6;
            // 
            // comboBox_plane
            // 
            this.comboBox_plane.FormattingEnabled = true;
            this.comboBox_plane.Location = new System.Drawing.Point(150, 177);
            this.comboBox_plane.Name = "comboBox_plane";
            this.comboBox_plane.Size = new System.Drawing.Size(160, 21);
            this.comboBox_plane.TabIndex = 7;
            // 
            // label_flightType
            // 
            this.label_flightType.AutoSize = true;
            this.label_flightType.Location = new System.Drawing.Point(85, 21);
            this.label_flightType.Name = "label_flightType";
            this.label_flightType.Size = new System.Drawing.Size(59, 13);
            this.label_flightType.TabIndex = 11;
            this.label_flightType.Text = "Тип рейса";
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(70, 48);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(74, 13);
            this.label_number.TabIndex = 12;
            this.label_number.Text = "Номер рейса";
            // 
            // label_arrivalTime
            // 
            this.label_arrivalTime.AutoSize = true;
            this.label_arrivalTime.Location = new System.Drawing.Point(22, 100);
            this.label_arrivalTime.Name = "label_arrivalTime";
            this.label_arrivalTime.Size = new System.Drawing.Size(122, 13);
            this.label_arrivalTime.TabIndex = 13;
            this.label_arrivalTime.Text = "Дата/время прибытия";
            // 
            // label_departureTime
            // 
            this.label_departureTime.AutoSize = true;
            this.label_departureTime.Location = new System.Drawing.Point(6, 74);
            this.label_departureTime.Name = "label_departureTime";
            this.label_departureTime.Size = new System.Drawing.Size(138, 13);
            this.label_departureTime.TabIndex = 14;
            this.label_departureTime.Text = "Дата/время отправления";
            // 
            // label_departurePoint
            // 
            this.label_departurePoint.AutoSize = true;
            this.label_departurePoint.Location = new System.Drawing.Point(37, 126);
            this.label_departurePoint.Name = "label_departurePoint";
            this.label_departurePoint.Size = new System.Drawing.Size(107, 13);
            this.label_departurePoint.TabIndex = 15;
            this.label_departurePoint.Text = "Место отправления";
            // 
            // label_arrivalPoint
            // 
            this.label_arrivalPoint.AutoSize = true;
            this.label_arrivalPoint.Location = new System.Drawing.Point(53, 153);
            this.label_arrivalPoint.Name = "label_arrivalPoint";
            this.label_arrivalPoint.Size = new System.Drawing.Size(91, 13);
            this.label_arrivalPoint.TabIndex = 16;
            this.label_arrivalPoint.Text = "Место прибытия";
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(672, 228);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(100, 23);
            this.button_edit.TabIndex = 17;
            this.button_edit.Text = "Изменить";
            this.button_edit.UseVisualStyleBackColor = true;
            // 
            // label_plane
            // 
            this.label_plane.AutoSize = true;
            this.label_plane.Location = new System.Drawing.Point(93, 180);
            this.label_plane.Name = "label_plane";
            this.label_plane.Size = new System.Drawing.Size(51, 13);
            this.label_plane.TabIndex = 18;
            this.label_plane.Text = "Самолет";
            // 
            // button_departureTime
            // 
            this.button_departureTime.Location = new System.Drawing.Point(246, 70);
            this.button_departureTime.Name = "button_departureTime";
            this.button_departureTime.Size = new System.Drawing.Size(64, 22);
            this.button_departureTime.TabIndex = 19;
            this.button_departureTime.Text = "Выбрать";
            this.button_departureTime.UseVisualStyleBackColor = true;
            this.button_departureTime.Click += new System.EventHandler(this.button_departureTime_Click);
            // 
            // button_arrivalTime
            // 
            this.button_arrivalTime.Location = new System.Drawing.Point(246, 96);
            this.button_arrivalTime.Name = "button_arrivalTime";
            this.button_arrivalTime.Size = new System.Drawing.Size(64, 22);
            this.button_arrivalTime.TabIndex = 20;
            this.button_arrivalTime.Text = "Выбрать";
            this.button_arrivalTime.UseVisualStyleBackColor = true;
            this.button_arrivalTime.Click += new System.EventHandler(this.button_arrivalTime_Click);
            // 
            // groupBox_flight
            // 
            this.groupBox_flight.Controls.Add(this.label_departureTime);
            this.groupBox_flight.Controls.Add(this.button_arrivalTime);
            this.groupBox_flight.Controls.Add(this.comboBox_flightType);
            this.groupBox_flight.Controls.Add(this.button_departureTime);
            this.groupBox_flight.Controls.Add(this.textBox_number);
            this.groupBox_flight.Controls.Add(this.label_plane);
            this.groupBox_flight.Controls.Add(this.textBox_departureTime);
            this.groupBox_flight.Controls.Add(this.textBox_arrivalTime);
            this.groupBox_flight.Controls.Add(this.label_arrivalPoint);
            this.groupBox_flight.Controls.Add(this.comboBox_departurePoint);
            this.groupBox_flight.Controls.Add(this.label_departurePoint);
            this.groupBox_flight.Controls.Add(this.comboBox_arrivalPoint);
            this.groupBox_flight.Controls.Add(this.comboBox_plane);
            this.groupBox_flight.Controls.Add(this.label_arrivalTime);
            this.groupBox_flight.Controls.Add(this.label_flightType);
            this.groupBox_flight.Controls.Add(this.label_number);
            this.groupBox_flight.Location = new System.Drawing.Point(12, 12);
            this.groupBox_flight.Name = "groupBox_flight";
            this.groupBox_flight.Size = new System.Drawing.Size(320, 210);
            this.groupBox_flight.TabIndex = 21;
            this.groupBox_flight.TabStop = false;
            this.groupBox_flight.Text = "Рейс";
            // 
            // groupBox_tickets
            // 
            this.groupBox_tickets.Controls.Add(this.dataGridView_tickets);
            this.groupBox_tickets.Controls.Add(this.button_removeTicket);
            this.groupBox_tickets.Controls.Add(this.button_sellTicket);
            this.groupBox_tickets.Location = new System.Drawing.Point(338, 12);
            this.groupBox_tickets.Name = "groupBox_tickets";
            this.groupBox_tickets.Size = new System.Drawing.Size(434, 210);
            this.groupBox_tickets.TabIndex = 24;
            this.groupBox_tickets.TabStop = false;
            this.groupBox_tickets.Text = "Билеты";
            // 
            // button_removeTicket
            // 
            this.button_removeTicket.Location = new System.Drawing.Point(324, 174);
            this.button_removeTicket.Name = "button_removeTicket";
            this.button_removeTicket.Size = new System.Drawing.Size(100, 23);
            this.button_removeTicket.TabIndex = 25;
            this.button_removeTicket.Text = "Удалить";
            this.button_removeTicket.UseVisualStyleBackColor = true;
            // 
            // button_sellTicket
            // 
            this.button_sellTicket.Location = new System.Drawing.Point(218, 174);
            this.button_sellTicket.Name = "button_sellTicket";
            this.button_sellTicket.Size = new System.Drawing.Size(100, 23);
            this.button_sellTicket.TabIndex = 26;
            this.button_sellTicket.Text = "Продать";
            this.button_sellTicket.UseVisualStyleBackColor = true;
            // 
            // dataGridView_tickets
            // 
            this.dataGridView_tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tickets.Location = new System.Drawing.Point(6, 18);
            this.dataGridView_tickets.Name = "dataGridView_tickets";
            this.dataGridView_tickets.Size = new System.Drawing.Size(418, 150);
            this.dataGridView_tickets.TabIndex = 27;
            // 
            // EditFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.groupBox_tickets);
            this.Controls.Add(this.groupBox_flight);
            this.Controls.Add(this.button_edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Рейс";
            this.groupBox_flight.ResumeLayout(false);
            this.groupBox_flight.PerformLayout();
            this.groupBox_tickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_flightType;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.TextBox textBox_departureTime;
        private System.Windows.Forms.TextBox textBox_arrivalTime;
        private System.Windows.Forms.ComboBox comboBox_departurePoint;
        private System.Windows.Forms.ComboBox comboBox_arrivalPoint;
        private System.Windows.Forms.ComboBox comboBox_plane;
        private System.Windows.Forms.Label label_flightType;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Label label_arrivalTime;
        private System.Windows.Forms.Label label_departureTime;
        private System.Windows.Forms.Label label_departurePoint;
        private System.Windows.Forms.Label label_arrivalPoint;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Label label_plane;
        private System.Windows.Forms.Button button_departureTime;
        private System.Windows.Forms.Button button_arrivalTime;
        private System.Windows.Forms.GroupBox groupBox_flight;
        private System.Windows.Forms.GroupBox groupBox_tickets;
        private System.Windows.Forms.DataGridView dataGridView_tickets;
        private System.Windows.Forms.Button button_removeTicket;
        private System.Windows.Forms.Button button_sellTicket;
    }
}