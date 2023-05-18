namespace StackBattle
{
    public partial class Form1 : Form
    {
        ArmyEdit armyEditorForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown_price.Value = (decimal)Battle.Price;
        }

        private void button_army1edit_Click(object sender, EventArgs e)
        {
            Battle battle = Battle.GetBattleInstance();
            battle.IsFirstArmyBeingEdited = true;
            armyEditorForm = new ArmyEdit();
            armyEditorForm.Show();
        }

        private void button_army2edit_Click(object sender, EventArgs e)
        {
            Battle battle = Battle.GetBattleInstance();
            battle.IsFirstArmyBeingEdited = false;
            armyEditorForm = new ArmyEdit();
            armyEditorForm.Show();
        }

        private void numericUpDown_price_ValueChanged(object sender, EventArgs e)
        {
            Battle.Price = (int)numericUpDown_price.Value;
        }
    }
}