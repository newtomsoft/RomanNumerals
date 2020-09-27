namespace RomanNumeralsCore
{
	public class ConvertTens : IRomanConverter
	{
		private static readonly string[] Tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
		public string Convert(int number)
			=> Tens[number / 10 % 10];
	}
}