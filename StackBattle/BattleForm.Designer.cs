namespace StackBattle
{
    partial class BattleForm
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
            this.groupBox_structures = new System.Windows.Forms.GroupBox();
            this.radioButton_3x3 = new System.Windows.Forms.RadioButton();
            this.radioButton_line = new System.Windows.Forms.RadioButton();
            this.radioButton_stack = new System.Windows.Forms.RadioButton();
            this.button_undo = new System.Windows.Forms.Button();
            this.button_redo = new System.Windows.Forms.Button();
            this.button_finishBattle = new System.Windows.Forms.Button();
            this.button_doTurn = new System.Windows.Forms.Button();
            this.label_turnCounter = new System.Windows.Forms.Label();
            this.textBox_unitCount1 = new System.Windows.Forms.TextBox();
            this.textBox_unitCount2 = new System.Windows.Forms.TextBox();
            this.label_unitCount2 = new System.Windows.Forms.Label();
            this.label_unitCount1 = new System.Windows.Forms.Label();
            this.groupBox_structures.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_structures
            // 
            this.groupBox_structures.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_structures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox_structures.Controls.Add(this.radioButton_3x3);
            this.groupBox_structures.Controls.Add(this.radioButton_line);
            this.groupBox_structures.Controls.Add(this.radioButton_stack);
            this.groupBox_structures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_structures.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_structures.Location = new System.Drawing.Point(249, -2);
            this.groupBox_structures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_structures.Name = "groupBox_structures";
            this.groupBox_structures.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_structures.Size = new System.Drawing.Size(187, 44);
            this.groupBox_structures.TabIndex = 0;
            this.groupBox_structures.TabStop = false;
            // 
            // radioButton_3x3
            // 
            this.radioButton_3x3.AutoSize = true;
            this.radioButton_3x3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_3x3.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton_3x3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_3x3.Location = new System.Drawing.Point(132, 13);
            this.radioButton_3x3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_3x3.Name = "radioButton_3x3";
            this.radioButton_3x3.Size = new System.Drawing.Size(49, 22);
            this.radioButton_3x3.TabIndex = 2;
            this.radioButton_3x3.Text = "3x3";
            this.radioButton_3x3.UseVisualStyleBackColor = true;
            this.radioButton_3x3.CheckedChanged += new System.EventHandler(this.radioButton_3x3_CheckedChanged);
            // 
            // radioButton_line
            // 
            this.radioButton_line.AutoSize = true;
            this.radioButton_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_line.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton_line.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_line.Location = new System.Drawing.Point(74, 13);
            this.radioButton_line.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_line.Name = "radioButton_line";
            this.radioButton_line.Size = new System.Drawing.Size(58, 22);
            this.radioButton_line.TabIndex = 1;
            this.radioButton_line.Text = "Line";
            this.radioButton_line.UseVisualStyleBackColor = true;
            this.radioButton_line.CheckedChanged += new System.EventHandler(this.radioButton_line_CheckedChanged);
            // 
            // radioButton_stack
            // 
            this.radioButton_stack.AutoSize = true;
            this.radioButton_stack.Checked = true;
            this.radioButton_stack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_stack.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton_stack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_stack.Location = new System.Drawing.Point(6, 13);
            this.radioButton_stack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_stack.Name = "radioButton_stack";
            this.radioButton_stack.Size = new System.Drawing.Size(67, 22);
            this.radioButton_stack.TabIndex = 0;
            this.radioButton_stack.TabStop = true;
            this.radioButton_stack.Text = "Stack";
            this.radioButton_stack.UseVisualStyleBackColor = true;
            this.radioButton_stack.CheckedChanged += new System.EventHandler(this.radioButton_stack_CheckedChanged);
            // 
            // button_undo
            // 
            this.button_undo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_undo.Enabled = false;
            this.button_undo.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_undo.Location = new System.Drawing.Point(21, 294);
            this.button_undo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_undo.Name = "button_undo";
            this.button_undo.Size = new System.Drawing.Size(60, 29);
            this.button_undo.TabIndex = 1;
            this.button_undo.Text = "Undo";
            this.button_undo.UseVisualStyleBackColor = true;
            this.button_undo.Click += new System.EventHandler(this.button_undo_Click);
            // 
            // button_redo
            // 
            this.button_redo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_redo.Enabled = false;
            this.button_redo.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_redo.Location = new System.Drawing.Point(190, 294);
            this.button_redo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_redo.Name = "button_redo";
            this.button_redo.Size = new System.Drawing.Size(61, 29);
            this.button_redo.TabIndex = 2;
            this.button_redo.Text = "Redo";
            this.button_redo.UseVisualStyleBackColor = true;
            this.button_redo.Click += new System.EventHandler(this.button_redo_Click);
            // 
            // button_finishBattle
            // 
            this.button_finishBattle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_finishBattle.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_finishBattle.Location = new System.Drawing.Point(580, 294);
            this.button_finishBattle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_finishBattle.Name = "button_finishBattle";
            this.button_finishBattle.Size = new System.Drawing.Size(88, 29);
            this.button_finishBattle.TabIndex = 3;
            this.button_finishBattle.Text = "Finish Battle";
            this.button_finishBattle.UseVisualStyleBackColor = true;
            this.button_finishBattle.Click += new System.EventHandler(this.button_finishBattle_Click);
            // 
            // button_doTurn
            // 
            this.button_doTurn.BackColor = System.Drawing.Color.Gold;
            this.button_doTurn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_doTurn.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_doTurn.Location = new System.Drawing.Point(87, 288);
            this.button_doTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_doTurn.Name = "button_doTurn";
            this.button_doTurn.Size = new System.Drawing.Size(97, 40);
            this.button_doTurn.TabIndex = 4;
            this.button_doTurn.Text = "Do Turn";
            this.button_doTurn.UseVisualStyleBackColor = false;
            this.button_doTurn.Click += new System.EventHandler(this.button_doTurn_Click);
            // 
            // label_turnCounter
            // 
            this.label_turnCounter.AutoSize = true;
            this.label_turnCounter.BackColor = System.Drawing.Color.Transparent;
            this.label_turnCounter.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_turnCounter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_turnCounter.Location = new System.Drawing.Point(323, 302);
            this.label_turnCounter.Name = "label_turnCounter";
            this.label_turnCounter.Size = new System.Drawing.Size(54, 18);
            this.label_turnCounter.TabIndex = 7;
            this.label_turnCounter.Text = "Turn: ";
            // 
            // textBox_unitCount1
            // 
            this.textBox_unitCount1.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_unitCount1.Location = new System.Drawing.Point(21, 62);
            this.textBox_unitCount1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_unitCount1.Multiline = true;
            this.textBox_unitCount1.Name = "textBox_unitCount1";
            this.textBox_unitCount1.ReadOnly = true;
            this.textBox_unitCount1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_unitCount1.Size = new System.Drawing.Size(289, 223);
            this.textBox_unitCount1.TabIndex = 8;
            // 
            // textBox_unitCount2
            // 
            this.textBox_unitCount2.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_unitCount2.Location = new System.Drawing.Point(387, 62);
            this.textBox_unitCount2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_unitCount2.Multiline = true;
            this.textBox_unitCount2.Name = "textBox_unitCount2";
            this.textBox_unitCount2.ReadOnly = true;
            this.textBox_unitCount2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_unitCount2.Size = new System.Drawing.Size(294, 223);
            this.textBox_unitCount2.TabIndex = 9;
            // 
            // label_unitCount2
            // 
            this.label_unitCount2.AutoSize = true;
            this.label_unitCount2.BackColor = System.Drawing.Color.Transparent;
            this.label_unitCount2.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_unitCount2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_unitCount2.Location = new System.Drawing.Point(387, 44);
            this.label_unitCount2.Name = "label_unitCount2";
            this.label_unitCount2.Size = new System.Drawing.Size(97, 18);
            this.label_unitCount2.TabIndex = 6;
            this.label_unitCount2.Text = "Unit Count:";
            // 
            // label_unitCount1
            // 
            this.label_unitCount1.AutoSize = true;
            this.label_unitCount1.BackColor = System.Drawing.Color.Transparent;
            this.label_unitCount1.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_unitCount1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_unitCount1.Location = new System.Drawing.Point(21, 44);
            this.label_unitCount1.Name = "label_unitCount1";
            this.label_unitCount1.Size = new System.Drawing.Size(97, 18);
            this.label_unitCount1.TabIndex = 5;
            this.label_unitCount1.Text = "Unit Count:";
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StackBattle.Properties.Resources.menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.textBox_unitCount2);
            this.Controls.Add(this.textBox_unitCount1);
            this.Controls.Add(this.label_turnCounter);
            this.Controls.Add(this.label_unitCount2);
            this.Controls.Add(this.label_unitCount1);
            this.Controls.Add(this.button_doTurn);
            this.Controls.Add(this.button_finishBattle);
            this.Controls.Add(this.button_redo);
            this.Controls.Add(this.button_undo);
            this.Controls.Add(this.groupBox_structures);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BattleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BattleForm";
            this.groupBox_structures.ResumeLayout(false);
            this.groupBox_structures.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox_structures;
        private RadioButton radioButton_3x3;
        private RadioButton radioButton_line;
        private RadioButton radioButton_stack;
        private Button button_undo;
        private Button button_redo;
        private Button button_finishBattle;
        private Button button_doTurn;
        private Label label_turnCounter;
        private TextBox textBox_unitCount1;
        private TextBox textBox_unitCount2;
        private Label label_unitCount2;
        private Label label_unitCount1;
    }
}