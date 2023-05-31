namespace StackBattle
{
    partial class ArmyEdit
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
            this.comboBox_unitTypeSelection = new System.Windows.Forms.ComboBox();
            this.button_addUnit = new System.Windows.Forms.Button();
            this.comboBox_armyUnitSelection = new System.Windows.Forms.ComboBox();
            this.button_editUnit = new System.Windows.Forms.Button();
            this.label_unitName = new System.Windows.Forms.Label();
            this.label_hitpoints = new System.Windows.Forms.Label();
            this.label_attack = new System.Windows.Forms.Label();
            this.label_defense = new System.Windows.Forms.Label();
            this.label_SAR = new System.Windows.Forms.Label();
            this.label_SAS = new System.Windows.Forms.Label();
            this.numericUpDown_hp = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_attack = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_defense = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_sar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_sas = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel_stats = new System.Windows.Forms.FlowLayoutPanel();
            this.label_armynum = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_removeUnit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_attack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_defense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sas)).BeginInit();
            this.flowLayoutPanel_stats.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_unitTypeSelection
            // 
            this.comboBox_unitTypeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_unitTypeSelection.FormattingEnabled = true;
            this.comboBox_unitTypeSelection.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_unitTypeSelection.Items.AddRange(new object[] {
            "Light Infantry",
            "Heavy Infantry",
            "Knight",
            "Archer",
            "Healer",
            "Warlock"});
            this.comboBox_unitTypeSelection.Location = new System.Drawing.Point(237, 11);
            this.comboBox_unitTypeSelection.Name = "comboBox_unitTypeSelection";
            this.comboBox_unitTypeSelection.Size = new System.Drawing.Size(176, 28);
            this.comboBox_unitTypeSelection.TabIndex = 0;
            this.comboBox_unitTypeSelection.SelectedIndexChanged += new System.EventHandler(this.comboBox_unitTypeSelection_SelectedIndexChanged);
            // 
            // button_addUnit
            // 
            this.button_addUnit.Location = new System.Drawing.Point(419, 10);
            this.button_addUnit.Name = "button_addUnit";
            this.button_addUnit.Size = new System.Drawing.Size(94, 29);
            this.button_addUnit.TabIndex = 1;
            this.button_addUnit.Text = "Add";
            this.button_addUnit.UseVisualStyleBackColor = true;
            this.button_addUnit.Click += new System.EventHandler(this.button_addUnit_Click);
            // 
            // comboBox_armyUnitSelection
            // 
            this.comboBox_armyUnitSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_armyUnitSelection.DropDownWidth = 300;
            this.comboBox_armyUnitSelection.FormattingEnabled = true;
            this.comboBox_armyUnitSelection.Location = new System.Drawing.Point(519, 11);
            this.comboBox_armyUnitSelection.Name = "comboBox_armyUnitSelection";
            this.comboBox_armyUnitSelection.Size = new System.Drawing.Size(176, 28);
            this.comboBox_armyUnitSelection.TabIndex = 2;
            // 
            // button_editUnit
            // 
            this.button_editUnit.Location = new System.Drawing.Point(701, 10);
            this.button_editUnit.Name = "button_editUnit";
            this.button_editUnit.Size = new System.Drawing.Size(94, 29);
            this.button_editUnit.TabIndex = 3;
            this.button_editUnit.Text = "Edit";
            this.button_editUnit.UseVisualStyleBackColor = true;
            this.button_editUnit.Click += new System.EventHandler(this.button_editUnit_Click);
            // 
            // label_unitName
            // 
            this.label_unitName.AutoSize = true;
            this.label_unitName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_unitName.Location = new System.Drawing.Point(25, 58);
            this.label_unitName.Name = "label_unitName";
            this.label_unitName.Size = new System.Drawing.Size(150, 38);
            this.label_unitName.TabIndex = 4;
            this.label_unitName.Text = "Unit Name";
            // 
            // label_hitpoints
            // 
            this.label_hitpoints.BackColor = System.Drawing.Color.Transparent;
            this.label_hitpoints.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_hitpoints.Location = new System.Drawing.Point(3, 0);
            this.label_hitpoints.Name = "label_hitpoints";
            this.label_hitpoints.Size = new System.Drawing.Size(168, 38);
            this.label_hitpoints.TabIndex = 5;
            this.label_hitpoints.Text = "Hit Points";
            this.label_hitpoints.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_attack
            // 
            this.label_attack.BackColor = System.Drawing.Color.Transparent;
            this.label_attack.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_attack.Location = new System.Drawing.Point(3, 49);
            this.label_attack.Name = "label_attack";
            this.label_attack.Size = new System.Drawing.Size(168, 38);
            this.label_attack.TabIndex = 6;
            this.label_attack.Text = "Attack";
            this.label_attack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_defense
            // 
            this.label_defense.BackColor = System.Drawing.Color.Transparent;
            this.label_defense.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_defense.Location = new System.Drawing.Point(3, 98);
            this.label_defense.Name = "label_defense";
            this.label_defense.Size = new System.Drawing.Size(168, 38);
            this.label_defense.TabIndex = 7;
            this.label_defense.Text = "Defense";
            this.label_defense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_SAR
            // 
            this.label_SAR.BackColor = System.Drawing.Color.Transparent;
            this.label_SAR.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SAR.Location = new System.Drawing.Point(3, 147);
            this.label_SAR.Name = "label_SAR";
            this.label_SAR.Size = new System.Drawing.Size(168, 38);
            this.label_SAR.TabIndex = 8;
            this.label_SAR.Text = "SA Range";
            this.label_SAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_SAS
            // 
            this.label_SAS.BackColor = System.Drawing.Color.Transparent;
            this.label_SAS.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SAS.Location = new System.Drawing.Point(3, 196);
            this.label_SAS.Name = "label_SAS";
            this.label_SAS.Size = new System.Drawing.Size(168, 38);
            this.label_SAS.TabIndex = 9;
            this.label_SAS.Text = "SA Strength";
            this.label_SAS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDown_hp
            // 
            this.numericUpDown_hp.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_hp.Location = new System.Drawing.Point(177, 3);
            this.numericUpDown_hp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_hp.Name = "numericUpDown_hp";
            this.numericUpDown_hp.Size = new System.Drawing.Size(96, 43);
            this.numericUpDown_hp.TabIndex = 10;
            this.numericUpDown_hp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_attack
            // 
            this.numericUpDown_attack.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_attack.Location = new System.Drawing.Point(177, 52);
            this.numericUpDown_attack.Name = "numericUpDown_attack";
            this.numericUpDown_attack.Size = new System.Drawing.Size(96, 43);
            this.numericUpDown_attack.TabIndex = 11;
            // 
            // numericUpDown_defense
            // 
            this.numericUpDown_defense.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_defense.Location = new System.Drawing.Point(177, 101);
            this.numericUpDown_defense.Name = "numericUpDown_defense";
            this.numericUpDown_defense.Size = new System.Drawing.Size(96, 43);
            this.numericUpDown_defense.TabIndex = 12;
            // 
            // numericUpDown_sar
            // 
            this.numericUpDown_sar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_sar.Location = new System.Drawing.Point(177, 150);
            this.numericUpDown_sar.Name = "numericUpDown_sar";
            this.numericUpDown_sar.Size = new System.Drawing.Size(96, 43);
            this.numericUpDown_sar.TabIndex = 13;
            // 
            // numericUpDown_sas
            // 
            this.numericUpDown_sas.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_sas.Location = new System.Drawing.Point(177, 199);
            this.numericUpDown_sas.Name = "numericUpDown_sas";
            this.numericUpDown_sas.Size = new System.Drawing.Size(96, 43);
            this.numericUpDown_sas.TabIndex = 14;
            // 
            // flowLayoutPanel_stats
            // 
            this.flowLayoutPanel_stats.Controls.Add(this.label_hitpoints);
            this.flowLayoutPanel_stats.Controls.Add(this.numericUpDown_hp);
            this.flowLayoutPanel_stats.Controls.Add(this.label_attack);
            this.flowLayoutPanel_stats.Controls.Add(this.numericUpDown_attack);
            this.flowLayoutPanel_stats.Controls.Add(this.label_defense);
            this.flowLayoutPanel_stats.Controls.Add(this.numericUpDown_defense);
            this.flowLayoutPanel_stats.Controls.Add(this.label_SAR);
            this.flowLayoutPanel_stats.Controls.Add(this.numericUpDown_sar);
            this.flowLayoutPanel_stats.Controls.Add(this.label_SAS);
            this.flowLayoutPanel_stats.Controls.Add(this.numericUpDown_sas);
            this.flowLayoutPanel_stats.Location = new System.Drawing.Point(25, 99);
            this.flowLayoutPanel_stats.Name = "flowLayoutPanel_stats";
            this.flowLayoutPanel_stats.Size = new System.Drawing.Size(293, 252);
            this.flowLayoutPanel_stats.TabIndex = 16;
            // 
            // label_armynum
            // 
            this.label_armynum.AutoSize = true;
            this.label_armynum.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_armynum.Location = new System.Drawing.Point(25, 1);
            this.label_armynum.Name = "label_armynum";
            this.label_armynum.Size = new System.Drawing.Size(137, 38);
            this.label_armynum.TabIndex = 17;
            this.label_armynum.Text = "Army №1";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_price.Location = new System.Drawing.Point(419, 58);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(163, 38);
            this.label_price.TabIndex = 18;
            this.label_price.Text = "Price: 0/100";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(475, 368);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(141, 56);
            this.button_cancel.TabIndex = 19;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Visible = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(102, 368);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(141, 56);
            this.button_save.TabIndex = 20;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Visible = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_removeUnit
            // 
            this.button_removeUnit.Location = new System.Drawing.Point(289, 368);
            this.button_removeUnit.Name = "button_removeUnit";
            this.button_removeUnit.Size = new System.Drawing.Size(141, 56);
            this.button_removeUnit.TabIndex = 21;
            this.button_removeUnit.Text = "Remove";
            this.button_removeUnit.UseVisualStyleBackColor = true;
            this.button_removeUnit.Visible = false;
            this.button_removeUnit.Click += new System.EventHandler(this.button_removeUnit_Click);
            // 
            // ArmyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_removeUnit);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_armynum);
            this.Controls.Add(this.flowLayoutPanel_stats);
            this.Controls.Add(this.label_unitName);
            this.Controls.Add(this.button_editUnit);
            this.Controls.Add(this.comboBox_armyUnitSelection);
            this.Controls.Add(this.button_addUnit);
            this.Controls.Add(this.comboBox_unitTypeSelection);
            this.Name = "ArmyEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArmyEdit";
            this.Load += new System.EventHandler(this.ArmyEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_attack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_defense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sas)).EndInit();
            this.flowLayoutPanel_stats.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox_unitTypeSelection;
        private Button button_addUnit;
        private ComboBox comboBox_armyUnitSelection;
        private Button button_editUnit;
        private Label label_unitName;
        private Label label_hitpoints;
        private Label label_attack;
        private Label label_defense;
        private Label label_SAR;
        private Label label_SAS;
        private NumericUpDown numericUpDown_hp;
        private NumericUpDown numericUpDown_attack;
        private NumericUpDown numericUpDown_defense;
        private NumericUpDown numericUpDown_sar;
        private NumericUpDown numericUpDown_sas;
        private FlowLayoutPanel flowLayoutPanel_stats;
        private Label label_armynum;
        private Label label_price;
        private Button button_cancel;
        private Button button_save;
        private Button button_removeUnit;
    }
}