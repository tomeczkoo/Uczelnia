
using System;
using Workers.Student;

namespace Oczelnia_1._
{
	class Application
	{
		public static void Main(string[] args)
		{
			
			Student mietek = new Student("mietek","kowalski");
			
			
			Console.WriteLine(mietek.nazwisko);
			Console.ReadKey(true);
		}
	}
}