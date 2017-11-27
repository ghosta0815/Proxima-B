namespace Prototype_MVCPattern.MVCPattern.View
{
    partial class PlanetView
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
            this.PlanetsGridView = new System.Windows.Forms.DataGridView();
            this.PlanetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanetDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newPlanetName = new System.Windows.Forms.TextBox();
            this.boxRegisterNewPlanet = new System.Windows.Forms.GroupBox();
            this.NewPlanetMass = new System.Windows.Forms.NumericUpDown();
            this.NewPlanetDiameter = new System.Windows.Forms.NumericUpDown();
            this.NewPlanetIDLabel = new System.Windows.Forms.Label();
            this.NewPlanetID = new System.Windows.Forms.TextBox();
            this.NewPlanetMassLabel = new System.Windows.Forms.Label();
            this.NewPlanetDiameterLabel = new System.Windows.Forms.Label();
            this.NewPlanetNameLabel = new System.Windows.Forms.Label();
            this.AddNewPlanetButton = new System.Windows.Forms.Button();
            this.RemovePlanetButton = new System.Windows.Forms.Button();
            this.RegisterPlanetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlanetsGridView)).BeginInit();
            this.boxRegisterNewPlanet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewPlanetMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPlanetDiameter)).BeginInit();
            this.SuspendLayout();
            // 
            // PlanetsGridView
            // 
            this.PlanetsGridView.AllowUserToAddRows = false;
            this.PlanetsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlanetsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlanetID,
            this.PlanetName,
            this.PlanetDiameter,
            this.Mass});
            this.PlanetsGridView.Location = new System.Drawing.Point(12, 145);
            this.PlanetsGridView.Name = "PlanetsGridView";
            this.PlanetsGridView.Size = new System.Drawing.Size(1015, 306);
            this.PlanetsGridView.TabIndex = 0;
            this.PlanetsGridView.SelectionChanged += new System.EventHandler(this.PlanetsGridView_SelectionChanged);
            // 
            // PlanetID
            // 
            this.PlanetID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PlanetID.HeaderText = "Planet ID";
            this.PlanetID.Name = "PlanetID";
            this.PlanetID.Width = 70;
            // 
            // PlanetName
            // 
            this.PlanetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlanetName.HeaderText = "Planet Name";
            this.PlanetName.Name = "PlanetName";
            // 
            // PlanetDiameter
            // 
            this.PlanetDiameter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlanetDiameter.HeaderText = "Planet Diameter";
            this.PlanetDiameter.Name = "PlanetDiameter";
            // 
            // Mass
            // 
            this.Mass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mass.HeaderText = "Mass";
            this.Mass.Name = "Mass";
            // 
            // newPlanetName
            // 
            this.newPlanetName.Location = new System.Drawing.Point(99, 19);
            this.newPlanetName.Name = "newPlanetName";
            this.newPlanetName.Size = new System.Drawing.Size(100, 20);
            this.newPlanetName.TabIndex = 1;
            // 
            // boxRegisterNewPlanet
            // 
            this.boxRegisterNewPlanet.Controls.Add(this.NewPlanetMass);
            this.boxRegisterNewPlanet.Controls.Add(this.NewPlanetDiameter);
            this.boxRegisterNewPlanet.Controls.Add(this.NewPlanetIDLabel);
            this.boxRegisterNewPlanet.Controls.Add(this.NewPlanetID);
            this.boxRegisterNewPlanet.Controls.Add(this.NewPlanetMassLabel);
            this.boxRegisterNewPlanet.Controls.Add(this.NewPlanetDiameterLabel);
            this.boxRegisterNewPlanet.Controls.Add(this.NewPlanetNameLabel);
            this.boxRegisterNewPlanet.Controls.Add(this.newPlanetName);
            this.boxRegisterNewPlanet.Location = new System.Drawing.Point(12, 12);
            this.boxRegisterNewPlanet.Name = "boxRegisterNewPlanet";
            this.boxRegisterNewPlanet.Size = new System.Drawing.Size(217, 127);
            this.boxRegisterNewPlanet.TabIndex = 2;
            this.boxRegisterNewPlanet.TabStop = false;
            this.boxRegisterNewPlanet.Text = "Register new Planet";
            // 
            // NewPlanetMass
            // 
            this.NewPlanetMass.DecimalPlaces = 3;
            this.NewPlanetMass.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NewPlanetMass.Location = new System.Drawing.Point(99, 70);
            this.NewPlanetMass.Name = "NewPlanetMass";
            this.NewPlanetMass.Size = new System.Drawing.Size(100, 20);
            this.NewPlanetMass.TabIndex = 4;
            // 
            // NewPlanetDiameter
            // 
            this.NewPlanetDiameter.DecimalPlaces = 3;
            this.NewPlanetDiameter.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NewPlanetDiameter.Location = new System.Drawing.Point(99, 45);
            this.NewPlanetDiameter.Name = "NewPlanetDiameter";
            this.NewPlanetDiameter.Size = new System.Drawing.Size(100, 20);
            this.NewPlanetDiameter.TabIndex = 4;
            // 
            // NewPlanetIDLabel
            // 
            this.NewPlanetIDLabel.AutoSize = true;
            this.NewPlanetIDLabel.Location = new System.Drawing.Point(6, 101);
            this.NewPlanetIDLabel.Name = "NewPlanetIDLabel";
            this.NewPlanetIDLabel.Size = new System.Drawing.Size(54, 13);
            this.NewPlanetIDLabel.TabIndex = 8;
            this.NewPlanetIDLabel.Text = "Planet ID:";
            // 
            // NewPlanetID
            // 
            this.NewPlanetID.Location = new System.Drawing.Point(99, 96);
            this.NewPlanetID.Name = "NewPlanetID";
            this.NewPlanetID.Size = new System.Drawing.Size(100, 20);
            this.NewPlanetID.TabIndex = 7;
            // 
            // NewPlanetMassLabel
            // 
            this.NewPlanetMassLabel.AutoSize = true;
            this.NewPlanetMassLabel.Location = new System.Drawing.Point(6, 73);
            this.NewPlanetMassLabel.Name = "NewPlanetMassLabel";
            this.NewPlanetMassLabel.Size = new System.Drawing.Size(68, 13);
            this.NewPlanetMassLabel.TabIndex = 6;
            this.NewPlanetMassLabel.Text = "Planet Mass:";
            // 
            // NewPlanetDiameterLabel
            // 
            this.NewPlanetDiameterLabel.AutoSize = true;
            this.NewPlanetDiameterLabel.Location = new System.Drawing.Point(6, 47);
            this.NewPlanetDiameterLabel.Name = "NewPlanetDiameterLabel";
            this.NewPlanetDiameterLabel.Size = new System.Drawing.Size(82, 13);
            this.NewPlanetDiameterLabel.TabIndex = 4;
            this.NewPlanetDiameterLabel.Text = "Planet Diameter";
            // 
            // NewPlanetNameLabel
            // 
            this.NewPlanetNameLabel.AutoSize = true;
            this.NewPlanetNameLabel.Location = new System.Drawing.Point(6, 22);
            this.NewPlanetNameLabel.Name = "NewPlanetNameLabel";
            this.NewPlanetNameLabel.Size = new System.Drawing.Size(71, 13);
            this.NewPlanetNameLabel.TabIndex = 2;
            this.NewPlanetNameLabel.Text = "Planet Name:";
            // 
            // AddNewPlanetButton
            // 
            this.AddNewPlanetButton.Location = new System.Drawing.Point(248, 28);
            this.AddNewPlanetButton.Name = "AddNewPlanetButton";
            this.AddNewPlanetButton.Size = new System.Drawing.Size(100, 23);
            this.AddNewPlanetButton.TabIndex = 3;
            this.AddNewPlanetButton.Text = "Add new Planet";
            this.AddNewPlanetButton.UseVisualStyleBackColor = true;
            this.AddNewPlanetButton.Click += new System.EventHandler(this.AddNewPlanetButton_Click);
            // 
            // RemovePlanetButton
            // 
            this.RemovePlanetButton.Location = new System.Drawing.Point(248, 57);
            this.RemovePlanetButton.Name = "RemovePlanetButton";
            this.RemovePlanetButton.Size = new System.Drawing.Size(100, 23);
            this.RemovePlanetButton.TabIndex = 3;
            this.RemovePlanetButton.Text = "Remove Planet";
            this.RemovePlanetButton.UseVisualStyleBackColor = true;
            this.RemovePlanetButton.Click += new System.EventHandler(this.RemovePlanetButton_Click);
            // 
            // RegisterPlanetButton
            // 
            this.RegisterPlanetButton.Location = new System.Drawing.Point(248, 86);
            this.RegisterPlanetButton.Name = "RegisterPlanetButton";
            this.RegisterPlanetButton.Size = new System.Drawing.Size(100, 23);
            this.RegisterPlanetButton.TabIndex = 3;
            this.RegisterPlanetButton.Text = "Register Planet";
            this.RegisterPlanetButton.UseVisualStyleBackColor = true;
            this.RegisterPlanetButton.Click += new System.EventHandler(this.RegisterPlanetButton_Click);
            // 
            // PlanetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 462);
            this.Controls.Add(this.RegisterPlanetButton);
            this.Controls.Add(this.RemovePlanetButton);
            this.Controls.Add(this.AddNewPlanetButton);
            this.Controls.Add(this.boxRegisterNewPlanet);
            this.Controls.Add(this.PlanetsGridView);
            this.Name = "PlanetView";
            this.Text = "PlanetView";
            ((System.ComponentModel.ISupportInitialize)(this.PlanetsGridView)).EndInit();
            this.boxRegisterNewPlanet.ResumeLayout(false);
            this.boxRegisterNewPlanet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewPlanetMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPlanetDiameter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PlanetsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanetDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mass;
        private System.Windows.Forms.TextBox newPlanetName;
        private System.Windows.Forms.GroupBox boxRegisterNewPlanet;
        private System.Windows.Forms.Label NewPlanetIDLabel;
        private System.Windows.Forms.TextBox NewPlanetID;
        private System.Windows.Forms.Label NewPlanetMassLabel;
        private System.Windows.Forms.Label NewPlanetDiameterLabel;
        private System.Windows.Forms.Label NewPlanetNameLabel;
        private System.Windows.Forms.Button AddNewPlanetButton;
        private System.Windows.Forms.Button RemovePlanetButton;
        private System.Windows.Forms.Button RegisterPlanetButton;
        private System.Windows.Forms.NumericUpDown NewPlanetMass;
        private System.Windows.Forms.NumericUpDown NewPlanetDiameter;
    }
}