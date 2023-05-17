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
            Battle battle = Battle.GetBattleInstance();
            label_armynum.Text = battle.IsFirstArmyBeingEdited ? "Army №1" : "Army №2";
            Army army = battle.GetArmy();
            comboBox_unitTypeSelection.SelectedItem = comboBox_unitTypeSelection.Items[0];

            GetUnitsString(army);
            if (army.ArmySize != 0)
                comboBox_armyUnitSelection.SelectedItem = comboBox_armyUnitSelection.Items[0];
        }

        private void comboBox_unitTypeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            int unitType = comboBox_unitTypeSelection.SelectedIndex;
            if (unitType < 3)
                HideSA(true);
            else HideSA(false);
        }

        private void HideSA(bool isNotSAUnit) // скрытие ненужных характеристик для юнитов без спешл абилити
        {
            if (isNotSAUnit)
            {
                label_SAR.Hide();
                label_SAS.Hide();
                numericUpDown_sar.Hide();
                numericUpDown_sas.Hide();
            }
            else
            {
                label_SAR.Show();
                label_SAS.Show();
                numericUpDown_sar.Show();
                numericUpDown_sas.Show();
            }
        }

        void GetUnitsString(Army army)
        {
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
