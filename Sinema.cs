using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorage
{
   public  class Sinema
    {

        public int ID { get; set; }
        public string NameSinema { get; set; }// Название фильма
        public int Year { get; set; } // Год выпуска картины
        public string  Style { get; set; }// Жанр (комедии, боевик, драмма)
        public string Producer { get; set; }// Режисер
    }
   
    public class Theatr
    {
        public int ID { get; set; }
        public string NameTheatr { get; set; } // Название
        public string Author { get; set; }// Автор 
        public string Style { get; set; }// Жанр
        public int NuberArtist { get; set; }// Учетный номер актера главной роли
    }
    public class Actors
    {
        public int ID { get; set; } // Ключ
        public string Family { get; set; } // Фамилия
        public string Name { get; set; }// Имя
        public string Patronymic { get; set; }// Отчество
        public int YearBirth { get; set; }// Год рождения
        public string Role { get; set; }// Какие роли играет
        public int AccountNumber { get; set; }// Учетный номер

     
  
    }
    
}
