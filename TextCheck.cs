using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formochka;

namespace Formochka
{
    public class TextCheck
    {
        public string CheckLevels(string boxText)
        {
            if (boxText == "Легкий")
            {
                return "Easy";
            }
            else
            {
                if (boxText == "Средний")
                {
                    return "Normal";
                }
                else
                {
                    if (boxText == "Сложный")
                    {
                        return "Cringe";
                    }
                    // Если сложность не выбрана
                    else
                    {
                        Random rnd = new Random();
                        string[] lvl = { "Easy", "Normal", "Cringe" };
                        int index = rnd.Next(lvl.Length);
                        return lvl[index];
                    }
                }
            }
        } 
        
        public string CheckLanguage(string boxText)
        {
            if ((boxText != "Русский") && (boxText != "English"))
            {
                Random rnd = new Random();
                string[] ls = { "Русский", "English" };
                int index = rnd.Next(ls.Length);
                boxText = ls[index];
            }
            
            return boxText;
        }
    }
}
