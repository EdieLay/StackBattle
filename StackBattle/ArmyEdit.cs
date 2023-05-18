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

            SetUnitsSelectionList(army);
            if (army.ArmySize != 0)
                comboBox_armyUnitSelection.SelectedItem = comboBox_armyUnitSelection.Items[0];

            label_price.Text = "Price: " + army.Price + "/" + Battle.Price;
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

        // мб добавить в IUnit метод UnitStatsToString, который будет возвращать строку:
        // UnitName HP/Attack/Defense/SAR/SAS
        void SetUnitsSelectionList(Army army) 
        {
            comboBox_armyUnitSelection.Items.Clear();
            for (int i = 0; i < army.ArmySize; i++)
            {
                string test = $"{i+1} {army[i].GetType()} {army[i].HitPoints}/{army[i].Attack}/{army[i].Defense}";
                if (army[i] is ISpecialAbility saunit)
                {
                    test = test + $"/{saunit.Range}/{saunit.Strength}";
                }
                comboBox_armyUnitSelection.Items.Add(test);
            }
        }

        private void button_addUnit_Click(object sender, EventArgs e)
        {
            int unitType = comboBox_unitTypeSelection.SelectedIndex;

            int hp = (int)numericUpDown_hp.Value;
            int attack = (int)numericUpDown_attack.Value;
            int defense = (int)numericUpDown_defense.Value;
            int sar = (int)numericUpDown_sar.Value;
            int sas = (int)numericUpDown_sas.Value;

            Battle battle = Battle.GetBattleInstance();
            Army army = battle.GetArmy();

            switch(unitType)
            {
                case 0: // Light Infantry
                    army.AddUnit(new LightInfantry(attack, defense, hp));
                    break;
                case 1: // Heavy Infantry
                    army.AddUnit(new HeavyInfantry(attack, defense, hp));
                    break;
                case 2: // Knight
                    army.AddUnit(new Knight(attack, defense, hp));
                    break;
                case 3: // Archer
                    army.AddUnit(new Archer(attack, defense, hp, sar, sas));
                    break;
                case 4: // Healer
                    army.AddUnit(new Healer(attack, defense, hp, sar, sas));
                    break;
                case 5: // Warlock
                    army.AddUnit(new Warlock(attack, defense, hp, sar, sas));
                    break;
            }
            SetUnitsSelectionList(army);
            label_price.Text = "Price: " + army.Price + "/" + Battle.Price;
        }
    }
}
