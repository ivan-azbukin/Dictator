using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictator
{
    public class Rocket
    {
        /// <summary>
        /// Коллекция всех боеприпасов
        /// </summary>
        private List<int> _ammo;
        
        /// <summary>
        /// Массив с максимальным номером боеприпаса на каждом из уровней
        /// </summary>
        private List<int> _borders;
        
        private readonly int _maxValue = 108; 
        public Rocket()
        {
            _ammo = Enumerable.Range(1, _maxValue).ToList();
            GetBorders();
        }

        /// <summary>
        /// Вычисляем значение максимального элемента на каждом из уровней
        /// </summary>
        private void GetBorders()
        {
            _borders = new List<int>();
            var acc = 2;
            _borders.Add(1);
            while (_borders.Last() < _maxValue)
            {
                _borders.Add(_borders[^1] + acc);
                acc++;
            }
        }

        /// <summary>
        /// Возвращает номер отсека, в котором находится боеприпас.
        /// Отсеки нумеруются с 1
        /// </summary>
        /// <param name="ammoNumber">Номер боеприпаса</param>
        /// <returns></returns>
        public int GetAmmoLevel(int ammoNumber)
        {
            if (ammoNumber < 1)
                throw new ArgumentException("Ammo number must be greater or equal then 1");
            if (ammoNumber > 108)
                throw new ArgumentException("Ammo number must be less or equal then 108");
            
            return _borders.FindIndex(item => item >= ammoNumber) + 1;
        }
    }
}