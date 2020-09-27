namespace RomanNumeralsCore
{
	public class ConvertHundreds : IRomanConverter
	{
		private static readonly string[] Hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
		public string Convert(int number) 
			=> Hundreds[number / 100 % 10];
	}
}