namespace StackBattle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_start = new System.Windows.Forms.Button();
            this.button_army1edit = new System.Windows.Forms.Button();
            this.label_army1 = new System.Windows.Forms.Label();
            this.label_army2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_price = new System.Windows.Forms.NumericUpDown();
            this.label_price1 = new System.Windows.Forms.Label();
            this.label_price2 = new System.Windows.Forms.Label();
            this.label_army1price = new System.Windows.Forms.Label();
            this.label_army2price = new System.Windows.Forms.Label();
            this.button_army2edit = new System.Windows.Forms.Button();
            this.button_createRandArmy1 = new System.Windows.Forms.Button();
            this.button_createRandArmy2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_price)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Gold;
            this.button_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_start.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_start.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_start.Location = new System.Drawing.Point(301, 69);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(202, 84);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "BATTLE!!!";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_army1edit
            // 
            this.button_army1edit.BackColor = System.Drawing.Color.LightGray;
            this.button_army1edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_army1edit.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_army1edit.Location = new System.Drawing.Point(11, 193);
            this.button_army1edit.Name = "button_army1edit";
            this.button_army1edit.Size = new System.Drawing.Size(206, 84);
            this.button_army1edit.TabIndex = 1;
            this.button_army1edit.Text = "Edit Army 1";
            this.button_army1edit.UseVisualStyleBackColor = false;
            this.button_army1edit.Click += new System.EventHandler(this.button_army1edit_Click);
            // 
            // label_army1
            // 
            this.label_army1.AutoSize = true;
            this.label_army1.BackColor = System.Drawing.Color.Transparent;
            this.label_army1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_army1.ForeColor = System.Drawing.Color.White;
            this.label_army1.Location = new System.Drawing.Point(11, 77);
            this.label_army1.Name = "label_army1";
            this.label_army1.Size = new System.Drawing.Size(186, 59);
            this.label_army1.TabIndex = 2;
            this.label_army1.Text = "Army 1";
            // 
            // label_army2
            // 
            this.label_army2.AutoSize = true;
            this.label_army2.BackColor = System.Drawing.Color.Transparent;
            this.label_army2.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_army2.ForeColor = System.Drawing.Color.White;
            this.label_army2.Location = new System.Drawing.Point(586, 77);
            this.label_army2.Name = "label_army2";
            this.label_army2.Size = new System.Drawing.Size(188, 59);
            this.label_army2.TabIndex = 3;
            this.label_army2.Text = "Army 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(330, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 59);
            this.label1.TabIndex = 4;
            this.label1.Text = "Price:";
            // 
            // numericUpDown_price
            // 
            this.numericUpDown_price.BackColor = System.Drawing.Color.White;
            this.numericUpDown_price.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_price.Location = new System.Drawing.Point(342, 244);
            this.numericUpDown_price.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_price.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_price.Name = "numericUpDown_price";
            this.numericUpDown_price.Size = new System.Drawing.Size(135, 66);
            this.numericUpDown_price.TabIndex = 5;
            this.numericUpDown_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_price.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_price.ValueChanged += new System.EventHandler(this.numericUpDown_price_ValueChanged);
            // 
            // label_price1
            // 
            this.label_price1.AutoSize = true;
            this.label_price1.BackColor = System.Drawing.Color.Transparent;
            this.label_price1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_price1.ForeColor = System.Drawing.Color.White;
            this.label_price1.Location = new System.Drawing.Point(11, 139);
            this.label_price1.Name = "label_price1";
            this.label_price1.Size = new System.Drawing.Size(121, 37);
            this.label_price1.TabIndex = 6;
            this.label_price1.Text = "Price: ";
            // 
            // label_price2
            // 
            this.label_price2.AutoSize = true;
            this.label_price2.BackColor = System.Drawing.Color.Transparent;
            this.label_price2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_price2.ForeColor = System.Drawing.Color.White;
            this.label_price2.Location = new System.Drawing.Point(586, 139);
            this.label_price2.Name = "label_price2";
            this.label_price2.Size = new System.Drawing.Size(121, 37);
            this.label_price2.TabIndex = 7;
            this.label_price2.Text = "Price: ";
            // 
            // label_army1price
            // 
            this.label_army1price.AutoSize = true;
            this.label_army1price.BackColor = System.Drawing.Color.Transparent;
            this.label_army1price.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_army1price.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_army1price.Location = new System.Drawing.Point(106, 139);
            this.label_army1price.Name = "label_army1price";
            this.label_army1price.Size = new System.Drawing.Size(35, 37);
            this.label_army1price.TabIndex = 8;
            this.label_army1price.Text = "0";
            // 
            // label_army2price
            // 
            this.label_army2price.AutoSize = true;
            this.label_army2price.BackColor = System.Drawing.Color.Transparent;
            this.label_army2price.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_army2price.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_army2price.Location = new System.Drawing.Point(680, 139);
            this.label_army2price.Name = "label_army2price";
            this.label_army2price.Size = new System.Drawing.Size(35, 37);
            this.label_army2price.TabIndex = 9;
            this.label_army2price.Text = "0";
            // 
            // button_army2edit
            // 
            this.button_army2edit.BackColor = System.Drawing.Color.LightGray;
            this.button_army2edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_army2edit.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_army2edit.Location = new System.Drawing.Point(581, 193);
            this.button_army2edit.Name = "button_army2edit";
            this.button_army2edit.Size = new System.Drawing.Size(207, 84);
            this.button_army2edit.TabIndex = 10;
            this.button_army2edit.Text = "Edit Army 2";
            this.button_army2edit.UseVisualStyleBackColor = false;
            this.button_army2edit.Click += new System.EventHandler(this.button_army2edit_Click);
            // 
            // button_createRandArmy1
            // 
            this.button_createRandArmy1.BackColor = System.Drawing.Color.LightGray;
            this.button_createRandArmy1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_createRandArmy1.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_createRandArmy1.Location = new System.Drawing.Point(61, 283);
            this.button_createRandArmy1.Name = "button_createRandArmy1";
            this.button_createRandArmy1.Size = new System.Drawing.Size(105, 87);
            this.button_createRandArmy1.TabIndex = 11;
            this.button_createRandArmy1.Text = "Create Random \r\nArmy";
            this.button_createRandArmy1.UseVisualStyleBackColor = false;
            this.button_createRandArmy1.Click += new System.EventHandler(this.button_createRandArmy1_Click);
            // 
            // button_createRandArmy2
            // 
            this.button_createRandArmy2.BackColor = System.Drawing.Color.LightGray;
            this.button_createRandArmy2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_createRandArmy2.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_createRandArmy2.Location = new System.Drawing.Point(637, 283);
            this.button_createRandArmy2.Name = "button_createRandArmy2";
            this.button_createRandArmy2.Size = new System.Drawing.Size(105, 87);
            this.button_createRandArmy2.TabIndex = 12;
            this.button_createRandArmy2.Text = "Create Random \r\nArmy";
            this.button_createRandArmy2.UseVisualStyleBackColor = false;
            this.button_createRandArmy2.Click += new System.EventHandler(this.button_createRandArmy2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.button_createRandArmy2);
            this.Controls.Add(this.button_createRandArmy1);
            this.Controls.Add(this.button_army2edit);
            this.Controls.Add(this.label_army2price);
            this.Controls.Add(this.label_army1price);
            this.Controls.Add(this.label_price2);
            this.Controls.Add(this.label_price1);
            this.Controls.Add(this.numericUpDown_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_army2);
            this.Controls.Add(this.label_army1);
            this.Controls.Add(this.button_army1edit);
            this.Controls.Add(this.button_start);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stack Battle";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_start;
        private Button button_army1edit;
        private Label label_army1;
        private Label label_army2;
        private Label label1;
        private NumericUpDown numericUpDown_price;
        private Label label_price1;
        private Label label_price2;
        private Label label_army1price;
        private Label label_army2price;
        private Button button_army2edit;
        private Button button_createRandArmy1;
        private Button button_createRandArmy2;
    }
}