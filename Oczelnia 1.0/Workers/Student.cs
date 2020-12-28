using System.Collections.Generic;
using System;
using Oczelnia_1.Workers.student;

namespace Oczelnia_1._.Workers
{

	public class Student
	{
		string aImie  { get; set; }
		string aNazwisko  { get; set; }
		
		public List<string> oceny = new List<string>(); 
	
		
		public Student()
		{
			aImie= "basic_name";
			aNazwisko = "basic_surname";
		}
		
		public Student( string imie, string nazwisko )
		{
			aImie = imie;
			aNazwisko = nazwisko;
		}
		
		
		
	}
}
