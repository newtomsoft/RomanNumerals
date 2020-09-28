using System;

namespace RomanNumeralsCore
{
	internal class Parse
	{
		private readonly int _valueToConvert;
		private string _romanNumber = string.Empty;

		private Parse(int value)
		{
			if(value < 1 || value > 3999)
				throw new OverflowException("number must be less or equal than 3999");
			_valueToConvert = value;
		}
		public static Parse Number(int value) => new Parse(value);

		public Parse And<T>() where T : IRomanConverter, new()
		{
			var converter = new T();
			_romanNumber += converter.Convert(_valueToConvert);
			return this;
		}

		public string GetString() => _romanNumber;
	}
}