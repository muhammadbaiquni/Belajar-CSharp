using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarCShart
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Calculation.Tambah(123));
			Console.WriteLine(Calculation.Kali(456));

			Console.ReadKey();
		}
	}

	static class Calculation
	{
		public static int Tambah(int numbers)
		{
			// Memisahkan setiap digit angka menggunakan LINQ
			var number = numbers.ToString().Select(digit => int.Parse(digit.ToString()));
			int result = 0;

			// Melakukan operasi penjumlahan
			foreach(var item in number)
			{
				result += item;
			}

			// Awal rekursif jika panjang chars angka melebihi 2 char
			if(result > 9)
			{
				return Tambah(result);
			}

			return result;
		}

		public static int Kali(int numbers)
		{
			// Memisahkan setiap digit angka menggunakan LINQ
			var number = numbers.ToString().Select(digit => int.Parse(digit.ToString()));
			int result = 1;

			// Melakukan operasi perkalian
			foreach(var item in number)
			{
				result *= item;
			}

			// Awal rekursif jika panjang chars angka melebihi 2 char
			if(result > 9)
			{
				return Kali(result);
			}

			return result;
		}
	}
}
