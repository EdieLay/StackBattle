﻿using StackBattle.Properties;
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
        Battle battle;
        Army army;
        int price;
        int armyNum;
        public ArmyEdit()
        {
            battle = Battle.GetBattleInstance();
            army = battle.GetArmy();
            price = army.Price;
            armyNum = battle.IsFirstArmyBeingEdited ? 1 : 2;
            InitializeComponent();
            SetNumericsMaxValue();
        }

        private void ArmyEdit_Load(object sender, EventArgs e) // загрузка формы
        {
            label_armynum.Text = battle.IsFirstArmyBeingEdited ? "Army 1" : "Army 2";
            comboBox_unitTypeSelection.SelectedItem = comboBox_unitTypeSelection.Items[0];

            SetUnitsSelectionList();
        }

        private void comboBox_unitTypeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            int unitType = comboBox_unitTypeSelection.SelectedIndex; // в комбоБоксе до 3 индекса идут юниты без спешл абилити
            if (unitType < 3)
                HideSA(true, false);
            else if (unitType < 6) HideSA(false, false);
            else
                HideSA(true, true);

            switch (unitType) 
            {
                case 0: // Light Infantry
                    pictureBox_Unit.Image = Resources.lightInfantry;
                    break;
                case 1: // Heavy Infantry
                    pictureBox_Unit.Image = Resources.heavyInfantry;
                    break;
                case 2: // Knight
                    pictureBox_Unit.Image = Resources.knight;
                    break;
                case 3: // Archer
                    pictureBox_Unit.Image = Resources.archer;
                    break;
                case 4: // Healer
                    pictureBox_Unit.Image = Resources.healer;
                    break;
                case 5: // Warlock
                    pictureBox_Unit.Image = Resources.warlock;
                    break;
                case 6: // Gulyay Gorod
                    //pictureBox_Unit.Image = Resources.gulyayGorod;
                    break;
            }
        }

        private void HideSA(bool isNotSAUnit, bool isGG) // скрытие ненужных характеристик для юнитов без спешл абилити
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
            if (isGG)
            {
                numericUpDown_attack.Value = 0;
                numericUpDown_attack.Enabled = false;
            }
            else
            {
                numericUpDown_attack.Enabled = true;
            }
        }

        void SetUnitsSelectionList() 
        {
            comboBox_armyUnitSelection.Items.Clear();
            for (int i = 0; i < army.ArmySize; i++)
            {
                string test = $"{army[i].GetUnitStats()}";
                comboBox_armyUnitSelection.Items.Add(test);
            }
            label_price.Text = "Price: " + price + "/" + Battle.Price; // обновляем цену армии
        }

        private void button_addUnit_Click(object sender, EventArgs e) // добавление юнита в армию
        {
            int unitType = comboBox_unitTypeSelection.SelectedIndex;

            // берём хар-ики из намериков
            int hp = (int)numericUpDown_hp.Value;
            int attack = (int)numericUpDown_attack.Value;
            int defense = (int)numericUpDown_defense.Value;
            int sar = (int)numericUpDown_sar.Value;
            int sas = (int)numericUpDown_sas.Value;
            price += hp + attack + defense;
            string id = $"{armyNum}#{army.NextIndex++}";

            switch(unitType) // добавляем юнита (наверное, можно сделать как-то покрасивее, мб через абстрактную фабрику)
            {
                case UnitType.LightInfantry: // Light Infantry
                    army.AddUnit(new LightInfantry(attack, defense, hp, sas, id));
                    price += 2 * (sar + sas);
                    break;
                case UnitType.HeavyInfantry: // Heavy Infantry
                    army.AddUnit(new HeavyInfantry(attack, defense, hp, id));
                    break;
                case UnitType.Knight: // Knight
                    army.AddUnit(new Knight(attack, defense, hp, id));
                    break;
                case UnitType.Archer: // Archer
                    army.AddUnit(new Archer(attack, defense, hp, sar, sas, id));
                    price += 2 * (sar + sas);
                    break;
                case UnitType.Healer: // Healer
                    army.AddUnit(new Healer(attack, defense, hp, sar, sas, id));
                    price += 2 * (sar + sas);
                    break;
                case UnitType.Warlock: // Warlock
                    army.AddUnit(new Warlock(attack, defense, hp, sar, sas, id));
                    price += 2 * (sar + sas);
                    break;
                case 6: // Gulyay Gorod
                    GulyayGorod gg = new GulyayGorod(hp, defense, 0);
                    army.AddUnit(new GulyayGorodAdapter(gg, id));
                    break;
            }
            price += hp + attack + defense;
            if (unitType > 2 && unitType < 6)
                price += 2 * (sar + sas);
            SetUnitsSelectionList(); // обновляем комбоБокс с выбором юнита из армии
        }

        private void button_editUnit_Click(object sender, EventArgs e)
        {
            if (comboBox_armyUnitSelection.SelectedIndex == -1) 
            {
                MessageBox.Show("Select a unit please!");
                return;
            }
            int index = comboBox_armyUnitSelection.SelectedIndex;

            IUnit unit = army[index];

            int unitType = (int)unit.Type;
            comboBox_unitTypeSelection.SelectedIndex = unitType;

            ToggleEditingMode();

            if (unit is ISpecialAbility saunit)
            {
                numericUpDown_sar.Value = (decimal)saunit.Range;
                numericUpDown_sas.Value = (decimal)saunit.Strength;
            }

            numericUpDown_hp.Value = (decimal)unit.HitPoints;
            numericUpDown_attack.Value = (decimal)unit.Attack;
            numericUpDown_defense.Value = (decimal)unit.Defense;

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            int index = comboBox_armyUnitSelection.SelectedIndex;

            IUnit unit = army[index];
            price -= unit.HitPoints + unit.Attack + unit.Defense; // вычитаем текущие статы
            unit.HitPoints = (int)numericUpDown_hp.Value;
            unit.Attack = (int)numericUpDown_attack.Value;
            unit.Defense = (int)numericUpDown_defense.Value;
            price += unit.HitPoints + unit.Attack + unit.Defense; // прибавляем новые
            if (unit is ISpecialAbility saunit)
            {
                price -= 2 * (saunit.Range + saunit.Strength);
                saunit.Range = (int)numericUpDown_sar.Value;
                saunit.Strength = (int)numericUpDown_sas.Value;
                price += 2 * (saunit.Range + saunit.Strength);
            }
            ToggleEditingMode();
            SetUnitsSelectionList();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            ToggleEditingMode();
        }

        private void button_removeUnit_Click(object sender, EventArgs e)
        {
            int index = comboBox_armyUnitSelection.SelectedIndex;
            IUnit unit = army[index];
            price -= unit.HitPoints + unit.Attack + unit.Defense;
            if (unit is ISpecialAbility saunit)
                price -= 2 * (saunit.Range + saunit.Strength);
            army.Units.RemoveAt(index);
            ToggleEditingMode();
            SetUnitsSelectionList();
        }

        private void ToggleEditingMode()
        {
            comboBox_unitTypeSelection.Enabled ^= true;
            button_addUnit.Enabled ^= true;
            comboBox_armyUnitSelection.Enabled ^= true;
            button_editUnit.Enabled ^= true;
            button_cancel.Visible ^= true;
            button_save.Visible ^= true;
            button_removeUnit.Visible ^= true;
        }

        private void SetNumericsMaxValue()
        {
            numericUpDown_hp.Maximum = Battle.Price;
            numericUpDown_attack.Maximum = Battle.Price;
            numericUpDown_defense.Maximum = Battle.Price;
            numericUpDown_sar.Maximum = Battle.Price;
            numericUpDown_sas.Maximum = Battle.Price;
        }

        private void label_attack_Click(object sender, EventArgs e)
        {

        }

        private void label_hitpoints_Click(object sender, EventArgs e)
        {

        }

        private void label_armynum_Click(object sender, EventArgs e)
        {

        }

        private void label_unitName_Click(object sender, EventArgs e)
        {

        }

        private void label_defense_Click(object sender, EventArgs e)
        {

        }

        private void label_SAR_Click(object sender, EventArgs e)
        {

        }

        private void label_SAS_Click(object sender, EventArgs e)
        {

        }
    }
}
