namespace RomanNumeralsCore
{
	public class ConvertUnits : IRomanConverter
	{
		private static readonly string[] Units = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
		public string Convert(int number) 
			=> Units[number % 10];
	}
}