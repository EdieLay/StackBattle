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
            this.pictureBox_Unit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_attack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_defense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sas)).BeginInit();
            this.flowLayoutPanel_stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Unit)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_unitTypeSelection
            // 
            this.comboBox_unitTypeSelection.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox_unitTypeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_unitTypeSelection.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_unitTypeSelection.FormattingEnabled = true;
            this.comboBox_unitTypeSelection.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_unitTypeSelection.Items.AddRange(new object[] {
            "Light Infantry",
            "Heavy Infantry",
            "Knight",
            "Archer",
            "Healer",
            "Warlock",
            "Gulyay Gorod"});
            this.comboBox_unitTypeSelection.Location = new System.Drawing.Point(209, 5);
            this.comboBox_unitTypeSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_unitTypeSelection.Name = "comboBox_unitTypeSelection";
            this.comboBox_unitTypeSelection.Size = new System.Drawing.Size(141, 26);
            this.comboBox_unitTypeSelection.TabIndex = 0;
            this.comboBox_unitTypeSelection.SelectedIndexChanged += new System.EventHandler(this.comboBox_unitTypeSelection_SelectedIndexChanged);
            // 
            // button_addUnit
            // 
            this.button_addUnit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_addUnit.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_addUnit.Location = new System.Drawing.Point(356, 5);
            this.button_addUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_addUnit.Name = "button_addUnit";
            this.button_addUnit.Size = new System.Drawing.Size(82, 26);
            this.button_addUnit.TabIndex = 1;
            this.button_addUnit.Text = "Add";
            this.button_addUnit.UseVisualStyleBackColor = false;
            this.button_addUnit.Click += new System.EventHandler(this.button_addUnit_Click);
            // 
            // comboBox_armyUnitSelection
            // 
            this.comboBox_armyUnitSelection.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox_armyUnitSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_armyUnitSelection.DropDownWidth = 300;
            this.comboBox_armyUnitSelection.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_armyUnitSelection.FormattingEnabled = true;
            this.comboBox_armyUnitSelection.Location = new System.Drawing.Point(443, 5);
            this.comboBox_armyUnitSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_armyUnitSelection.Name = "comboBox_armyUnitSelection";
            this.comboBox_armyUnitSelection.Size = new System.Drawing.Size(154, 26);
            this.comboBox_armyUnitSelection.TabIndex = 2;
            // 
            // button_editUnit
            // 
            this.button_editUnit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_editUnit.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_editUnit.Location = new System.Drawing.Point(602, 5);
            this.button_editUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_editUnit.Name = "button_editUnit";
            this.button_editUnit.Size = new System.Drawing.Size(82, 26);
            this.button_editUnit.TabIndex = 3;
            this.button_editUnit.Text = "Edit";
            this.button_editUnit.UseVisualStyleBackColor = false;
            this.button_editUnit.Click += new System.EventHandler(this.button_editUnit_Click);
            // 
            // label_unitName
            // 
            this.label_unitName.AutoSize = true;
            this.label_unitName.BackColor = System.Drawing.Color.Transparent;
            this.label_unitName.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_unitName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_unitName.Location = new System.Drawing.Point(22, 44);
            this.label_unitName.Name = "label_unitName";
            this.label_unitName.Size = new System.Drawing.Size(125, 29);
            this.label_unitName.TabIndex = 4;
            this.label_unitName.Text = "Unit Name";
            this.label_unitName.Click += new System.EventHandler(this.label_unitName_Click);
            // 
            // label_hitpoints
            // 
            this.label_hitpoints.BackColor = System.Drawing.Color.Transparent;
            this.label_hitpoints.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_hitpoints.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_hitpoints.Location = new System.Drawing.Point(3, 0);
            this.label_hitpoints.Name = "label_hitpoints";
            this.label_hitpoints.Size = new System.Drawing.Size(147, 40);
            this.label_hitpoints.TabIndex = 5;
            this.label_hitpoints.Text = "Hit Points";
            this.label_hitpoints.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_hitpoints.Click += new System.EventHandler(this.label_hitpoints_Click);
            // 
            // label_attack
            // 
            this.label_attack.BackColor = System.Drawing.Color.Transparent;
            this.label_attack.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_attack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_attack.Location = new System.Drawing.Point(3, 40);
            this.label_attack.Name = "label_attack";
            this.label_attack.Size = new System.Drawing.Size(147, 38);
            this.label_attack.TabIndex = 6;
            this.label_attack.Text = "Attack";
            this.label_attack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_attack.Click += new System.EventHandler(this.label_attack_Click);
            // 
            // label_defense
            // 
            this.label_defense.BackColor = System.Drawing.Color.Transparent;
            this.label_defense.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_defense.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_defense.Location = new System.Drawing.Point(3, 80);
            this.label_defense.Name = "label_defense";
            this.label_defense.Size = new System.Drawing.Size(147, 38);
            this.label_defense.TabIndex = 7;
            this.label_defense.Text = "Defense";
            this.label_defense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_defense.Click += new System.EventHandler(this.label_defense_Click);
            // 
            // label_SAR
            // 
            this.label_SAR.BackColor = System.Drawing.Color.Transparent;
            this.label_SAR.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SAR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_SAR.Location = new System.Drawing.Point(3, 120);
            this.label_SAR.Name = "label_SAR";
            this.label_SAR.Size = new System.Drawing.Size(147, 38);
            this.label_SAR.TabIndex = 8;
            this.label_SAR.Text = "SA Range";
            this.label_SAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_SAR.Click += new System.EventHandler(this.label_SAR_Click);
            // 
            // label_SAS
            // 
            this.label_SAS.BackColor = System.Drawing.Color.Transparent;
            this.label_SAS.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SAS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_SAS.Location = new System.Drawing.Point(3, 160);
            this.label_SAS.Name = "label_SAS";
            this.label_SAS.Size = new System.Drawing.Size(147, 45);
            this.label_SAS.TabIndex = 9;
            this.label_SAS.Text = "SA Strength";
            this.label_SAS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_SAS.Click += new System.EventHandler(this.label_SAS_Click);
            // 
            // numericUpDown_hp
            // 
            this.numericUpDown_hp.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_hp.Location = new System.Drawing.Point(156, 2);
            this.numericUpDown_hp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_hp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_hp.Name = "numericUpDown_hp";
            this.numericUpDown_hp.Size = new System.Drawing.Size(84, 36);
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
            this.numericUpDown_attack.Location = new System.Drawing.Point(156, 42);
            this.numericUpDown_attack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_attack.Name = "numericUpDown_attack";
            this.numericUpDown_attack.Size = new System.Drawing.Size(84, 36);
            this.numericUpDown_attack.TabIndex = 11;
            // 
            // numericUpDown_defense
            // 
            this.numericUpDown_defense.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_defense.Location = new System.Drawing.Point(156, 82);
            this.numericUpDown_defense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_defense.Name = "numericUpDown_defense";
            this.numericUpDown_defense.Size = new System.Drawing.Size(84, 36);
            this.numericUpDown_defense.TabIndex = 12;
            // 
            // numericUpDown_sar
            // 
            this.numericUpDown_sar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_sar.Location = new System.Drawing.Point(156, 122);
            this.numericUpDown_sar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_sar.Name = "numericUpDown_sar";
            this.numericUpDown_sar.Size = new System.Drawing.Size(84, 36);
            this.numericUpDown_sar.TabIndex = 13;
            // 
            // numericUpDown_sas
            // 
            this.numericUpDown_sas.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_sas.Location = new System.Drawing.Point(156, 162);
            this.numericUpDown_sas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_sas.Name = "numericUpDown_sas";
            this.numericUpDown_sas.Size = new System.Drawing.Size(84, 36);
            this.numericUpDown_sas.TabIndex = 14;
            // 
            // flowLayoutPanel_stats
            // 
            this.flowLayoutPanel_stats.BackColor = System.Drawing.Color.Transparent;
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
            this.flowLayoutPanel_stats.Location = new System.Drawing.Point(22, 76);
            this.flowLayoutPanel_stats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel_stats.Name = "flowLayoutPanel_stats";
            this.flowLayoutPanel_stats.Size = new System.Drawing.Size(256, 205);
            this.flowLayoutPanel_stats.TabIndex = 16;
            // 
            // label_armynum
            // 
            this.label_armynum.AutoSize = true;
            this.label_armynum.BackColor = System.Drawing.Color.Transparent;
            this.label_armynum.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_armynum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_armynum.Location = new System.Drawing.Point(22, 1);
            this.label_armynum.Name = "label_armynum";
            this.label_armynum.Size = new System.Drawing.Size(83, 29);
            this.label_armynum.TabIndex = 17;
            this.label_armynum.Text = "Army 1";
            this.label_armynum.Click += new System.EventHandler(this.label_armynum_Click);
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.BackColor = System.Drawing.Color.Transparent;
            this.label_price.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_price.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_price.Location = new System.Drawing.Point(367, 44);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(137, 29);
            this.label_price.TabIndex = 18;
            this.label_price.Text = "Price: 0/100";
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Kristen ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_cancel.Location = new System.Drawing.Point(424, 293);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 34);
            this.button_cancel.TabIndex = 19;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Visible = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Kristen ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_save.Location = new System.Drawing.Point(191, 293);
            this.button_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 34);
            this.button_save.TabIndex = 20;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Visible = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_removeUnit
            // 
            this.button_removeUnit.Font = new System.Drawing.Font("Kristen ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_removeUnit.Location = new System.Drawing.Point(308, 293);
            this.button_removeUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_removeUnit.Name = "button_removeUnit";
            this.button_removeUnit.Size = new System.Drawing.Size(100, 34);
            this.button_removeUnit.TabIndex = 21;
            this.button_removeUnit.Text = "Remove";
            this.button_removeUnit.UseVisualStyleBackColor = true;
            this.button_removeUnit.Visible = false;
            this.button_removeUnit.Click += new System.EventHandler(this.button_removeUnit_Click);
            // 
            // pictureBox_Unit
            // 
            this.pictureBox_Unit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Unit.Location = new System.Drawing.Point(367, 92);
            this.pictureBox_Unit.Name = "pictureBox_Unit";
            this.pictureBox_Unit.Size = new System.Drawing.Size(92, 90);
            this.pictureBox_Unit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Unit.TabIndex = 22;
            this.pictureBox_Unit.TabStop = false;
            // 
            // ArmyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StackBattle.Properties.Resources.papyrus;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.pictureBox_Unit);
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
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Unit)).EndInit();
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
        private PictureBox pictureBox_Unit;
    }
}