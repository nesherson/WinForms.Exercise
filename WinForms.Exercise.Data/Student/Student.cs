﻿namespace WinForms.Exercise.Data
{
    public class Student
    {
        public Student()
        {
            Uloga = new HashSet<Uloga>();
        }

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public string Indeks { get; set; }
        public bool Aktivan { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public byte[]? Slika { get; set; }
        public int SemestarId { get; set; }
        public Semestar Semestar { get; set; }

        public ICollection<Uloga> Uloga { get; set; }
    }
}