namespace RomanNumeralsCore
{
	public class ConvertThousands : IRomanConverter
	{
		public string Convert(int number) 
			=> new string('M', number / 1000);
	}
}