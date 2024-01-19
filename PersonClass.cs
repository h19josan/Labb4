    using System;
// person klassen som plockar info från enum och struct om gender och hår och sen lägger till ögonfärg och födelsedatum
    public class Person
    {
        public Gender PersonGender { get; set; }
        public Hair PersonHair { get; set; }
        public DateTime BirthDate { get; set; }
        public string EyeColor { get; set; }

        public override string ToString()
        {
            return $"Kön: {PersonGender}, Hår: {PersonHair}, Födelsedag: {BirthDate.ToShortDateString()}, Ögonfärg: {EyeColor}";
        }
    }


