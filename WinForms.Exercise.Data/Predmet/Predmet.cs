namespace WinForms.Exercise.Data
{
	public class Predmet
	{
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int SemestarId { get; set; }


		public override string ToString()
		{
			return Naziv;
		}
	}
}
