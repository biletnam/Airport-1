namespace Airport
{
    partial class MainForm
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
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.flightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showFlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepFToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.addFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAirportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepApToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.addAirportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAirportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAirportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAircraftsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepAcToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.addAircraftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAircraftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAircraftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisAirportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_main = new System.Windows.Forms.DataGridView();
            this.menuStrip_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightsToolStripMenuItem,
            this.airportsToolStripMenuItem,
            this.planesToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(624, 24);
            this.menuStrip_main.TabIndex = 0;
            this.menuStrip_main.Text = "menuStrip_main";
            // 
            // flightsToolStripMenuItem
            // 
            this.flightsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showFlightsToolStripMenuItem,
            this.sepFToolStripMenuItem,
            this.addFlightToolStripMenuItem,
            this.editFlightToolStripMenuItem,
            this.removeFlightToolStripMenuItem});
            this.flightsToolStripMenuItem.Name = "flightsToolStripMenuItem";
            this.flightsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.flightsToolStripMenuItem.Text = "Рейсы";
            // 
            // showFlightsToolStripMenuItem
            // 
            this.showFlightsToolStripMenuItem.Name = "showFlightsToolStripMenuItem";
            this.showFlightsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showFlightsToolStripMenuItem.Text = "Показать";
            this.showFlightsToolStripMenuItem.Click += new System.EventHandler(this.showFlightsToolStripMenuItem_Click);
            // 
            // sepFToolStripMenuItem
            // 
            this.sepFToolStripMenuItem.Name = "sepFToolStripMenuItem";
            this.sepFToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // addFlightToolStripMenuItem
            // 
            this.addFlightToolStripMenuItem.Name = "addFlightToolStripMenuItem";
            this.addFlightToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addFlightToolStripMenuItem.Text = "Добавить";
            this.addFlightToolStripMenuItem.Click += new System.EventHandler(this.addFlightToolStripMenuItem_Click);
            // 
            // editFlightToolStripMenuItem
            // 
            this.editFlightToolStripMenuItem.Name = "editFlightToolStripMenuItem";
            this.editFlightToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editFlightToolStripMenuItem.Text = "Изменить";
            this.editFlightToolStripMenuItem.Click += new System.EventHandler(this.editFlightToolStripMenuItem_Click);
            // 
            // removeFlightToolStripMenuItem
            // 
            this.removeFlightToolStripMenuItem.Name = "removeFlightToolStripMenuItem";
            this.removeFlightToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeFlightToolStripMenuItem.Text = "Удалить";
            this.removeFlightToolStripMenuItem.Click += new System.EventHandler(this.removeFlightToolStripMenuItem_Click);
            // 
            // airportsToolStripMenuItem
            // 
            this.airportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAirportsToolStripMenuItem,
            this.sepApToolStripMenuItem,
            this.addAirportToolStripMenuItem,
            this.editAirportToolStripMenuItem,
            this.removeAirportToolStripMenuItem});
            this.airportsToolStripMenuItem.Name = "airportsToolStripMenuItem";
            this.airportsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.airportsToolStripMenuItem.Text = "Аэропорты";
            // 
            // showAirportsToolStripMenuItem
            // 
            this.showAirportsToolStripMenuItem.Name = "showAirportsToolStripMenuItem";
            this.showAirportsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.showAirportsToolStripMenuItem.Text = "Показать";
            this.showAirportsToolStripMenuItem.Click += new System.EventHandler(this.showAirportsToolStripMenuItem_Click);
            // 
            // sepApToolStripMenuItem
            // 
            this.sepApToolStripMenuItem.Name = "sepApToolStripMenuItem";
            this.sepApToolStripMenuItem.Size = new System.Drawing.Size(125, 6);
            // 
            // addAirportToolStripMenuItem
            // 
            this.addAirportToolStripMenuItem.Name = "addAirportToolStripMenuItem";
            this.addAirportToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addAirportToolStripMenuItem.Text = "Добавить";
            this.addAirportToolStripMenuItem.Click += new System.EventHandler(this.addAirportToolStripMenuItem_Click);
            // 
            // editAirportToolStripMenuItem
            // 
            this.editAirportToolStripMenuItem.Name = "editAirportToolStripMenuItem";
            this.editAirportToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.editAirportToolStripMenuItem.Text = "Изменить";
            this.editAirportToolStripMenuItem.Click += new System.EventHandler(this.editAirportToolStripMenuItem_Click);
            // 
            // removeAirportToolStripMenuItem
            // 
            this.removeAirportToolStripMenuItem.Name = "removeAirportToolStripMenuItem";
            this.removeAirportToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.removeAirportToolStripMenuItem.Text = "Удалить";
            this.removeAirportToolStripMenuItem.Click += new System.EventHandler(this.removeAirportToolStripMenuItem_Click);
            // 
            // planesToolStripMenuItem
            // 
            this.planesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAircraftsToolStripMenuItem,
            this.sepAcToolStripMenuItem,
            this.addAircraftToolStripMenuItem,
            this.editAircraftToolStripMenuItem,
            this.removeAircraftToolStripMenuItem});
            this.planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            this.planesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.planesToolStripMenuItem.Text = "Самолеты";
            // 
            // showAircraftsToolStripMenuItem
            // 
            this.showAircraftsToolStripMenuItem.Name = "showAircraftsToolStripMenuItem";
            this.showAircraftsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.showAircraftsToolStripMenuItem.Text = "Показать";
            this.showAircraftsToolStripMenuItem.Click += new System.EventHandler(this.showAircraftsToolStripMenuItem_Click);
            // 
            // sepAcToolStripMenuItem
            // 
            this.sepAcToolStripMenuItem.Name = "sepAcToolStripMenuItem";
            this.sepAcToolStripMenuItem.Size = new System.Drawing.Size(125, 6);
            // 
            // addAircraftToolStripMenuItem
            // 
            this.addAircraftToolStripMenuItem.Name = "addAircraftToolStripMenuItem";
            this.addAircraftToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addAircraftToolStripMenuItem.Text = "Добавить";
            this.addAircraftToolStripMenuItem.Click += new System.EventHandler(this.addAircraftToolStripMenuItem_Click);
            // 
            // editAircraftToolStripMenuItem
            // 
            this.editAircraftToolStripMenuItem.Name = "editAircraftToolStripMenuItem";
            this.editAircraftToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.editAircraftToolStripMenuItem.Text = "Изменить";
            this.editAircraftToolStripMenuItem.Click += new System.EventHandler(this.editAircraftToolStripMenuItem_Click);
            // 
            // removeAircraftToolStripMenuItem
            // 
            this.removeAircraftToolStripMenuItem.Name = "removeAircraftToolStripMenuItem";
            this.removeAircraftToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.removeAircraftToolStripMenuItem.Text = "Удалить";
            this.removeAircraftToolStripMenuItem.Click += new System.EventHandler(this.removeAircraftToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thisAirportToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.settingsToolStripMenuItem.Text = "Настройки";
            // 
            // thisAirportToolStripMenuItem
            // 
            this.thisAirportToolStripMenuItem.Name = "thisAirportToolStripMenuItem";
            this.thisAirportToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.thisAirportToolStripMenuItem.Text = "Текущий аэропорт";
            this.thisAirportToolStripMenuItem.Click += new System.EventHandler(this.thisAirportToolStripMenuItem_Click);
            // 
            // dataGridView_main
            // 
            this.dataGridView_main.AllowUserToAddRows = false;
            this.dataGridView_main.AllowUserToDeleteRows = false;
            this.dataGridView_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_main.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_main.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_main.Location = new System.Drawing.Point(0, 24);
            this.dataGridView_main.Name = "dataGridView_main";
            this.dataGridView_main.ReadOnly = true;
            this.dataGridView_main.RowHeadersVisible = false;
            this.dataGridView_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_main.Size = new System.Drawing.Size(624, 417);
            this.dataGridView_main.TabIndex = 1;
            this.dataGridView_main.SelectionChanged += new System.EventHandler(this.dataGridView_main_SelectionChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.dataGridView_main);
            this.Controls.Add(this.menuStrip_main);
            this.MainMenuStrip = this.menuStrip_main;
            this.Name = "MainForm";
            this.Text = "Авиаперевозки 0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem flightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_main;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thisAirportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAirportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAirportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAirportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showFlightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator sepFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAirportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator sepApToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAircraftsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator sepAcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAircraftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAircraftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAircraftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFlightToolStripMenuItem;
    }
}

