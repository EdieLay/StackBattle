using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackBattle
{
    public partial class ArmyEdit : Form
    {
        public ArmyEdit()
        {
            InitializeComponent();
        }

        private void ArmyEdit_Load(object sender, EventArgs e)
        {
            label_armynum.Text = Battle.IsFirstArmyBeingEdited ? "Army №1" : "Army №2";
            Battle battle = Battle.GetBattleInstance();
            Army army = battle.GetArmy();
            
            for (int i = 0; i < army.ArmySize; i++)
            {
                string test = $"{i} {army[i].GetType()} {army[i].HitPoints}/{army[i].Attack}/{army[i].Defense}";
                if (army[i] is ISpecialAbility saunit)
                {
                    test = test + $"/{saunit.Range}/{saunit.Strength}";
                }
                comboBox_armyUnitSelection.Items.Add(test);
            }
        }
    }
}
