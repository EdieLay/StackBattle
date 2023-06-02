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
            this.label_unitCount1 = new System.Windows.Forms.Label();
            this.label_unitCount2 = new System.Windows.Forms.Label();
            this.groupBox_structures.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_structures
            // 
            this.groupBox_structures.Controls.Add(this.radioButton_3x3);
            this.groupBox_structures.Controls.Add(this.radioButton_line);
            this.groupBox_structures.Controls.Add(this.radioButton_stack);
            this.groupBox_structures.Location = new System.Drawing.Point(292, 3);
            this.groupBox_structures.Name = "groupBox_structures";
            this.groupBox_structures.Size = new System.Drawing.Size(201, 53);
            this.groupBox_structures.TabIndex = 0;
            this.groupBox_structures.TabStop = false;
            // 
            // radioButton_3x3
            // 
            this.radioButton_3x3.AutoSize = true;
            this.radioButton_3x3.Location = new System.Drawing.Point(140, 23);
            this.radioButton_3x3.Name = "radioButton_3x3";
            this.radioButton_3x3.Size = new System.Drawing.Size(53, 24);
            this.radioButton_3x3.TabIndex = 2;
            this.radioButton_3x3.Text = "3x3";
            this.radioButton_3x3.UseVisualStyleBackColor = true;
            this.radioButton_3x3.CheckedChanged += new System.EventHandler(this.radioButton_3x3_CheckedChanged);
            // 
            // radioButton_line
            // 
            this.radioButton_line.AutoSize = true;
            this.radioButton_line.Location = new System.Drawing.Point(77, 23);
            this.radioButton_line.Name = "radioButton_line";
            this.radioButton_line.Size = new System.Drawing.Size(57, 24);
            this.radioButton_line.TabIndex = 1;
            this.radioButton_line.Text = "Line";
            this.radioButton_line.UseVisualStyleBackColor = true;
            this.radioButton_line.CheckedChanged += new System.EventHandler(this.radioButton_line_CheckedChanged);
            // 
            // radioButton_stack
            // 
            this.radioButton_stack.AutoSize = true;
            this.radioButton_stack.Checked = true;
            this.radioButton_stack.Location = new System.Drawing.Point(6, 23);
            this.radioButton_stack.Name = "radioButton_stack";
            this.radioButton_stack.Size = new System.Drawing.Size(65, 24);
            this.radioButton_stack.TabIndex = 0;
            this.radioButton_stack.TabStop = true;
            this.radioButton_stack.Text = "Stack";
            this.radioButton_stack.UseVisualStyleBackColor = true;
            this.radioButton_stack.CheckedChanged += new System.EventHandler(this.radioButton_stack_CheckedChanged);
            // 
            // button_undo
            // 
            this.button_undo.Enabled = false;
            this.button_undo.Location = new System.Drawing.Point(24, 398);
            this.button_undo.Name = "button_undo";
            this.button_undo.Size = new System.Drawing.Size(54, 29);
            this.button_undo.TabIndex = 1;
            this.button_undo.Text = "Undo";
            this.button_undo.UseVisualStyleBackColor = true;
            this.button_undo.Click += new System.EventHandler(this.button_undo_Click);
            // 
            // button_redo
            // 
            this.button_redo.Enabled = false;
            this.button_redo.Location = new System.Drawing.Point(184, 398);
            this.button_redo.Name = "button_redo";
            this.button_redo.Size = new System.Drawing.Size(54, 29);
            this.button_redo.TabIndex = 2;
            this.button_redo.Text = "Redo";
            this.button_redo.UseVisualStyleBackColor = true;
            this.button_redo.Click += new System.EventHandler(this.button_redo_Click);
            // 
            // button_finishBattle
            // 
            this.button_finishBattle.Location = new System.Drawing.Point(663, 397);
            this.button_finishBattle.Name = "button_finishBattle";
            this.button_finishBattle.Size = new System.Drawing.Size(100, 29);
            this.button_finishBattle.TabIndex = 3;
            this.button_finishBattle.Text = "Finish Battle";
            this.button_finishBattle.UseVisualStyleBackColor = true;
            this.button_finishBattle.Click += new System.EventHandler(this.button_finishBattle_Click);
            // 
            // button_doTurn
            // 
            this.button_doTurn.Location = new System.Drawing.Point(84, 384);
            this.button_doTurn.Name = "button_doTurn";
            this.button_doTurn.Size = new System.Drawing.Size(94, 54);
            this.button_doTurn.TabIndex = 4;
            this.button_doTurn.Text = "Do Turn";
            this.button_doTurn.UseVisualStyleBackColor = true;
            this.button_doTurn.Click += new System.EventHandler(this.button_doTurn_Click);
            // 
            // label_unitCount1
            // 
            this.label_unitCount1.AutoSize = true;
            this.label_unitCount1.Location = new System.Drawing.Point(43, 90);
            this.label_unitCount1.Name = "label_unitCount1";
            this.label_unitCount1.Size = new System.Drawing.Size(82, 20);
            this.label_unitCount1.TabIndex = 5;
            this.label_unitCount1.Text = "Unit Count:";
            // 
            // label_unitCount2
            // 
            this.label_unitCount2.AutoSize = true;
            this.label_unitCount2.Location = new System.Drawing.Point(571, 90);
            this.label_unitCount2.Name = "label_unitCount2";
            this.label_unitCount2.Size = new System.Drawing.Size(82, 20);
            this.label_unitCount2.TabIndex = 6;
            this.label_unitCount2.Text = "Unit Count:";
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_unitCount2);
            this.Controls.Add(this.label_unitCount1);
            this.Controls.Add(this.button_doTurn);
            this.Controls.Add(this.button_finishBattle);
            this.Controls.Add(this.button_redo);
            this.Controls.Add(this.button_undo);
            this.Controls.Add(this.groupBox_structures);
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
        private Label label_unitCount1;
        private Label label_unitCount2;
    }
}