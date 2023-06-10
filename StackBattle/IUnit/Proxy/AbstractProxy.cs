using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal abstract class AbstractProxy
    {
        protected static readonly string _takeDamageLog = System.IO.Path.GetFullPath(@"..\..\..\IUnit\Proxy\LogFiles\TakeDamageLog.txt");
        protected static readonly string _specialAbilityLog = System.IO.Path.GetFullPath(@"..\..\..\IUnit\Proxy\LogFiles\SpecialAbilityLog.txt");
        protected static readonly string _deathLog = System.IO.Path.GetFullPath(@"..\..\..\IUnit\Proxy\LogFiles\DeathLog.txt");
        private static bool areLogsCleared = false;
        public AbstractProxy() 
        {
            if (!areLogsCleared)
            {
                using (StreamWriter takeDamageLog = new(_takeDamageLog, false)) { }
                using (StreamWriter deathLog = new(_deathLog, false)) { }
                using (StreamWriter specialAbilityLog = new(_specialAbilityLog, false)) { }
                areLogsCleared = true;
            }
        }
        protected void LogTakeDamage(IUnit defender, IUnit attacker)
        {
            if (attacker.Attack == 0) return;
            using (StreamWriter takeDamageLog = new(_takeDamageLog, true))
            {
                string defenderInfo = defender.GetUnitStats();
                string attackerInfo = attacker.GetUnitStats();
                int defMod = Battle.DefenseMod;
                int damage = (int)Math.Round((double)attacker.Attack * ((double)defMod / (double)(defMod + defender.Defense)));
                string logLine = $"Turn {Battle.TurnCount:D5} | {attackerInfo} attacks {defenderInfo} dealing {damage} damage";
                takeDamageLog.WriteLine(logLine);
            }
        }

        protected void LogDeath(IUnit defender, IUnit attacker)
        {
            using (StreamWriter deathLog = new(_deathLog, true))
            {
                string defenderInfo = defender.GetUnitStats();
                string attackerInfo = attacker.GetUnitStats();
                string logLine = $"Turn {Battle.TurnCount:D5} | {defenderInfo} was KILLED by {attackerInfo}";
                deathLog.WriteLine(logLine);
            }
        }

        protected abstract void LogSpecialAbility(IUnit target);

        public static void LogUndoRedo(bool isUndo)
        {
            string logLine = isUndo ? $"UNDO to turn {Battle.TurnCount}" : $"REDO to turn {Battle.TurnCount}";
            using (StreamWriter takeDamageLog = new(_takeDamageLog, true))
            {
                takeDamageLog.WriteLine(logLine);
            }
            using (StreamWriter deathLog = new(_deathLog, true))
            {
                deathLog.WriteLine(logLine);
            }
            using (StreamWriter specialAbilityLog = new(_specialAbilityLog, true))
            {
                specialAbilityLog.WriteLine(logLine);
            }
        }
    }
}
