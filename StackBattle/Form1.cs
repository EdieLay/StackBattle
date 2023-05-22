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
            Battle battle = Battle.GetBattleInstance();
            battle.IsFirstArmyBeingEdited = isFirstEditing;
            armyEditorForm = new ArmyEdit();
            armyEditorForm.FormClosing += delegate { this.Show(); }; // ƒобавить обновление стоимости армии
            armyEditorForm.Show();
            this.Hide();
        }
    }
}