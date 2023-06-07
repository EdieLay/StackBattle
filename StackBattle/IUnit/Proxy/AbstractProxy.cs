using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal abstract class AbstractProxy
    {
        protected readonly string _takeDamageLog = System.IO.Path.GetFullPath(@".\LogFiles\TakeDamageLog.txt");
        protected readonly string _specialAbilityLog = System.IO.Path.GetFullPath(@".\LogFiles\SpecialAbilityLog.txt");
        protected readonly string _deathLog = System.IO.Path.GetFullPath(@".\LogFiles\DeathLog.txt");
        private static bool areLogsCleared = false;
        public AbstractProxy() 
        {
            if (!areLogsCleared)
            {
                using (StreamWriter takeDamageLog = new(_takeDamageLog, false)) 
                {
                    takeDamageLog.WriteLine("--------------------NEW BATTLE--------------------");
                }
                using (StreamWriter deathLog = new(_deathLog, false)) 
                {
                    deathLog.WriteLine("--------------------NEW BATTLE--------------------");
                }
                using (StreamWriter specialAbilityLog = new(_specialAbilityLog, false)) 
                {
                    specialAbilityLog.WriteLine("--------------------NEW BATTLE--------------------");
                }
                areLogsCleared = true;
            }
        }
        protected void LogTakeDamageAndDeath(IUnit defender, IUnit attacker)
        {
            using (StreamWriter takeDamageLog = new(_takeDamageLog, true))
            {
                string defenderInfo = defender.GetUnitStats();
                string attackerInfo = attacker.GetUnitStats();
                int defMod = Battle.DefenseMod;
                int damage = (int)Math.Round((double)attacker.Attack * ((double)defMod / (double)(defMod + defender.Defense)));
                int newDefHP = Math.Max(defender.HitPoints - damage, 0);
                string logLine = $"Turn {Battle.TurnCount:D5} | {attackerInfo} attacks {defenderInfo} dealing {damage} damage from {defender.HitPoints} HP to {newDefHP} HP"; //  From {defender.HitPoints+damage} HP to {defender.HitPoints} HP
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

        protected abstract void LogSpecialAbility(IUnit caster, IUnit target);
    }
}
