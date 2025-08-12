using System.ComponentModel.DataAnnotations;

namespace ContractManager.Models
{
	public class Dyspozycja
	{
		public int Id { get; set; }

		[Display(Name = "Numer umowy")]
		public required string NumerUmowy { get; set; }

		[Required]
		[Display(Name = "Data złożenia dyspozycji")]
		public DateTime DataDyspozycji { get; set; }

		[Display(Name = "Użytkownik")]
		public required string Uzytkownik { get; set; }

		public bool Checked { get; set; } = false;
	}
}
