namespace StackBattle
{
    public partial class Form1 : Form
    {
        ArmyEdit armyEditorForm;
        BattleForm battleForm;
        Battle battle = Battle.GetBattleInstance();
        UnitFactory factory= new UnitFactory();
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
                UpdateArmyPrice();
                this.Show();
            }; 
            armyEditorForm.Show();
            this.Hide();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            battleForm = new BattleForm();
            battle.TurnCount = 0;
            battleForm.FormClosing += delegate
            {
                UpdateArmyPrice();
                this.Show();
            };
            battleForm.Show();
            this.Hide();
        }

        private void button_createRandArmy1_Click(object sender, EventArgs e)
        {
            battle.IsFirstArmyBeingEdited = true;
            battle.SetArmy(factory.CreateRandomArmy(Battle.Price));
            UpdateArmyPrice();
        }

        private void button_createRandArmy2_Click(object sender, EventArgs e)
        {
            battle.IsFirstArmyBeingEdited = false;
            battle.SetArmy(factory.CreateRandomArmy(Battle.Price));
            UpdateArmyPrice();
        }

        private void UpdateArmyPrice()
        {
            battle.IsFirstArmyBeingEdited = true;
            Army army = battle.GetArmy();
            label_army1price.Text = army.Price.ToString();
            battle.IsFirstArmyBeingEdited = false;
            army = battle.GetArmy();
            label_army2price.Text = army.Price.ToString();
            if (battle.IsArmyPricesMatch())
                button_start.Enabled = true;
            else button_start.Enabled = false;
        }
    }
}