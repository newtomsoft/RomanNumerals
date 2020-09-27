namespace RomanNumeralsCore
{
    public class RomanNumerals
    {
	    public static string Convert(int number) 
		    =>  Parse.Number(number)
			    .And<ConvertThousands>()
			    .And<ConvertHundreds>()
			    .And<ConvertTens>()
			    .And<ConvertUnits>()
			    .GetString();
    }
}
