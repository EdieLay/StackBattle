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
    public partial class BattleForm : Form
    {
        Battle battle = Battle.GetBattleInstance();
        Army FirstArmy, SecondArmy;

        public BattleForm()
        {
            InitializeComponent();
            battle.SetCommand();
            battle.IsFirstArmyBeingEdited = true;
            FirstArmy = battle.GetArmy();
            battle.IsFirstArmyBeingEdited = false;
            SecondArmy = battle.GetArmy();
            UpdateUnitInfo();
        }

        private void radioButton_stack_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_stack.Checked)
            {
                battle.SetStructure(new StackStructure());
            }
        }

        private void radioButton_line_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_line.Checked)
            {
                battle.SetStructure(new LineStructure());
            }
        }

        private void radioButton_3x3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_3x3.Checked)
            {
                battle.SetStructure(new TripletStructure());
            }
        }

        private void button_doTurn_Click(object sender, EventArgs e)
        {
            battle.DoTurn();
            
            UpdateBattleFieldState();
        }

        private void button_undo_Click(object sender, EventArgs e)
        {
            battle.UndoTurn();
            UpdateBattleFieldState();
        }

        private void button_redo_Click(object sender, EventArgs e)
        {
            battle.RedoTurn();
            UpdateBattleFieldState();
        }

        private void button_finishBattle_Click(object sender, EventArgs e)
        {
            battle.DoBattle();
            UpdateBattleFieldState();
        }

        private void UpdateBattleFieldState()
        {
            UpdateUnitInfo();
            if (battle.IsGameFinished)
            {
                button_doTurn.Enabled = false;
                button_finishBattle.Enabled = false;
            }
            else
            {
                button_doTurn.Enabled = true;
                button_finishBattle.Enabled = true;
            }
            if (battle.IsUndoAvailable)
                button_undo.Enabled = true;
            else button_undo.Enabled = false;

            if (battle.IsRedoAvailable)
                button_redo.Enabled = true;
            else button_redo.Enabled = false;
        }

        private void UpdateUnitInfo()
        {
            label_unitCount1.Text = "Unit Count: " + FirstArmy.ArmySize.ToString() + Environment.NewLine;
            for (int i = 0; i < FirstArmy.ArmySize; i++)
            {
                label_unitCount1.Text += FirstArmy[i].GetUnitStats() + Environment.NewLine;
            }
            label_unitCount2.Text = "Unit Count: " + SecondArmy.ArmySize.ToString() + Environment.NewLine;
            for (int i = 0; i < SecondArmy.ArmySize; i++)
            {
                label_unitCount2.Text += SecondArmy[i].GetUnitStats() + Environment.NewLine;
            }
        }
    }
}
