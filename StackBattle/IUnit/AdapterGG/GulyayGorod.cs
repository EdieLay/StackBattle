using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class GulyayGorod
    {
        private readonly int _health;
        private readonly int _defence;
        private readonly int _cost;
        private int _currentHealth;

        public GulyayGorod()
        {
            _defence = 0;
            _health = 0;
            _currentHealth = 0;
            _cost = 0;
        }

        public GulyayGorod(int health, int defence, int cost)
        {
            _defence = defence;
            _health = health;
            _currentHealth = health;
            _cost = cost;
        }

        public int GetDefence()
        {
            return _defence;
        }

        public int GetStrength()
        {
            return 0;
        }

        public int GetHealth()
        {
            return _health;
        }

        public int GetCurrentHealth()
        {
            return _currentHealth;
        }

        public int GetCost()
        {
            return _cost;
        }

        public void TakeDamage(int damage)
        {
            if (_currentHealth == 0)
                throw new Exception("Unit are death!");

            if (damage < 0)
                throw new ArgumentException("Argument must be greater than zero", "damage");

            _currentHealth -= Math.Max(damage - _defence, 0);

            if (_currentHealth < 0)
                _currentHealth = 0;
        }

        public bool IsDead
        {
            get { return _currentHealth <= 0; }
        }
    }
}
