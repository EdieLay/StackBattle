namespace StackBattle
{
    public partial class Form1 : Form
    {
        ArmyEdit armyEditorForm;
        BattleForm battleForm;
        Battle battle = Battle.GetBattleInstance();
        public Form1()
        {
            InitializeComponent();
            if (battle.IsArmyPricesMatch())
                button_start.Enabled = true;
            else button_start.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown_price.Value = (decimal)Battle.Price;
        }

        private void button_army1edit_Click(object sender, EventArgs e)
        {
            OpenArmyEditor(true);
        }

        private void button_army2edit_Click(object sender, EventArgs e)
        {
            OpenArmyEditor(false);
        }

        private void numericUpDown_price_ValueChanged(object sender, EventArgs e)
        {
            Battle.Price = (int)numericUpDown_price.Value;
        }

        private void OpenArmyEditor(bool isFirstEditing)
        {
            battle.IsFirstArmyBeingEdited = isFirstEditing;
            armyEditorForm = new ArmyEdit();
            armyEditorForm.FormClosing += delegate {
                Army army = battle.GetArmy();
                if (isFirstEditing)
                {
                    label_army1price.Text = army.Price.ToString();
                }
                else label_army2price.Text = army.Price.ToString();
                if (battle.IsArmyPricesMatch())
                    button_start.Enabled = true;
                else button_start.Enabled = false;
                this.Show();
            }; 
            armyEditorForm.Show();
            this.Hide();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            battleForm = new BattleForm();
            battleForm.FormClosing += delegate
            {
                this.Show();
            };
            battleForm.Show();
            this.Hide();
        }
    }
}