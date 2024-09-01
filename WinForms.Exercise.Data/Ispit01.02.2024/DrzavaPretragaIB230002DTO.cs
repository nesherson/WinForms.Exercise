namespace WinForms.Exercise.Data.Ispit01._02._2024
{
    public class DrzavaPretragaIB230002DTO
    {
        public byte[]? Zastava { get; set; }
        public string Drzava { get; set; }
        public int BrojGradova { get; set; }
        public bool Aktivna { get; set; }
        public DrzavaIB230002 _Drzava { get; set; }
    }
}