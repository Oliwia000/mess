﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mess.Model
{
    public class Dane : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public string? ImageLink { get; set; }


        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}







/*Id = 1, Name = "Jan Postulski", Description = "Kawa to moje życie", ImageLink = "osoba1.jpg"
Id = 2, Name = "Alicja Bystra", Description = "<brak opisu>", ImageLink = "osoba2.jpg"
Id = 3, Name = "Adrianna Nowak", Description = "Przyroda to ciężki przedmiot", ImageLink = "osoba3.jpg"
Id = 4, Name = "Grażyna Łuk", Description = "Życie mnie mnie", ImageLink = "osoba4.jpg"
Id = 5, Name = "Krystian Błąd", Description = "Life is fun", ImageLink = "osoba5.jpg"
Id = 6, Name = "Adrian Jańczyk", Description = "Droga do sukcesu nie jest prosta", ImageLink = "osoba6.jpg"
Id = 7, Name = "Michaś Kowalczyk", Description = "Gry to moja specjalność", ImageLink = "osoba7.jpg"

Wiadomości czatu:

Jan Postulski: Siema, gdzie jesteś? Czekam na Ciebie pod Twoim blokiem.
Ty: Poczekaj chwilę, jeszcze muszę skończyć projekt, który mam do oddania.
Jan Postulski: Długo Ci to zajmie?
Ty: Jeszcze tak z 15 minut
Jan Postulski: Dobra, tylko byleby nie dłużej!
Ty: Dobra dobra...

*/