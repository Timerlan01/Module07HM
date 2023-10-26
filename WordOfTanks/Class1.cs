using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordOfTanks
{
    public class Tank
    {
        public string tankName;
        public int ammunitionLevel;
        public int armorLevel;
        public int agilityLevel;
        public Random random;

        public Tank(string name)
        {
            tankName = name;
            random = new Random();

            // Инициализация случайными значениями от 0 до 100 для параметров танка
            ammunitionLevel = random.Next(101);
            armorLevel = random.Next(101);
            agilityLevel = random.Next(101);
        }
        public string GetTankParameters()
        {
            return $"{tankName}: Боекомплект - {ammunitionLevel}%, Броня - {armorLevel}%, Маневренность - {agilityLevel}%";
        }
        public static bool operator ^(Tank tank1, Tank tank2)
        {
            // Проверка победы одного танка над другим
            int winCriteria = 0;
            if (tank1.ammunitionLevel > tank2.ammunitionLevel)
                winCriteria++;
            if (tank1.armorLevel > tank2.armorLevel)
                winCriteria++;
            if (tank1.agilityLevel > tank2.agilityLevel)
                winCriteria++;
            return winCriteria >= 2; // Победа, если выполнено не менее двух критериев
        }
    }
}
