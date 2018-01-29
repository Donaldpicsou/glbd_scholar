using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
	class Program{

		/// <summary>
		/// Allow to Display the content of an array of string
		/// </summary>
		/// <param name="table"></param>
		/// <param name="msg1"></param>
		/// <param name="msg2"></param>
		static void displayTable(String[] table, String msg1, String msg2)
		{
			Console.WriteLine(msg1);
			for (int i = 0; i < table.Length; i++)
			{
				Console.WriteLine(msg2+" "+i);
				Console.WriteLine(table[i]);
			}
		}

		/// <summary>
		/// Allow to display the content of array of integer
		/// </summary>
		/// <param name="table"></param>
		/// <param name="msg1"></param>
		/// <param name="msg2"></param>
		static void displayTable(int[] table, String msg1, String msg2) {
			Console.WriteLine(msg1);
			for (int i = 0; i < table.Length; i++)
			{
				Console.WriteLine(msg2 + " " + i);
				Console.WriteLine(table[i]);
			}
		
		}

		/// <summary>
		/// Allow to fill an array of String with appropriate value
		/// </summary>
		/// <param name="table"></param>
		/// <param name="message"></param>
		static void fillTable(String[] table, String message)
		{
			for (int i = 0; i < table.Length; i++)
			{
				Console.WriteLine(message);
				table[i] = Console.ReadLine();
			}
		}

		/// <summary>
		/// Allow to check if a value is in appropriate boundaries
		/// </summary>
		/// <param name="value"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		static bool checkValue(int value, int min, int max) {
			if (value >= min && value <= max)
			{
				return true;
			}
			else {
				Console.WriteLine("Values are between " + min + " and" + max); 
				return false;
			}
		}


		/// <summary>
		/// Allow to fill an array of integer with appropriate values
		/// </summary>
		/// <param name="table"></param>
		/// <param name="message"></param>
		static void fillTable(int[] table, String message) {
			int coef = 0;
			for (int i = 0; i < table.Length; i++) {
				Console.WriteLine(message + " "+i);
				coef = Int16.Parse(Console.ReadLine());
				while (!checkValue(coef, 2, 5)) {
					Console.WriteLine(message + " " + i);
					coef = Int16.Parse(Console.ReadLine());
				}
				table[i] = coef;
			}
		}

		/// <summary>
		/// Allow to fill array of marks for a specific user for each subject
		/// </summary>
		/// <param name="marks"></param><b>Table of marks</b>
		/// <param name="subjects"></param>
		/// <param name="students"></param>
		/// <param name="stu"></param>
		/// <param name="mes1"></param>
		/// <param name="mes2"></param>
		static void fillStumark(int[,] marks, String[] subjects, String[] students, int stu, String mes1, String mes2)
		{
			if (checkValue(stu, 0, students.Length)) // we check if the student exist, if He is between the boundaries
			{
				informUser(mes1);
				Console.WriteLine(mes1+" "+students[stu]); // We display the welcome message
				for(int i = 0; i < marks.GetLength(1); i++){
					Console.WriteLine(mes2 + " " + subjects[i]);
					int mark = Int16.Parse(Console.ReadLine());
					while (!checkValue(mark, 0, 20)) {
						mark = Int16.Parse(Console.ReadLine());
					}
					marks[stu, i] = mark;
				}
			}
		}

		/// <summary>
		/// Allow to Fill Overall Marks for every Students
		/// </summary>
		/// <param name="marks" ></param>
		/// <param name="subjects"></param>
		/// <param name="students"></param>
		/// <param name="mes1"></param>
		/// <param name="mes2"></param>
		static void fillAllMark(int[,] marks, String[] subjects, String[] students, String mes1, String mes2)
		{
			for (int i = 0; i < marks.GetLength(0); i++) {
				fillStumark(marks, subjects, students, i, mes1, mes2);
			}
		}

		/// <summary>
		/// Allow to clean and write a message in the standard out
		/// </summary>
		/// <param name="message" ty></param>
		static void informUser(String message)
		{
			Console.WriteLine(message);
			Console.WriteLine("Type a key to continue...");
			Console.Clear();
			Console.WriteLine(message);

		}

		/// <summary>
		/// Allow to compute the average of each student
		/// </summary>
		/// <param name="marks"> array of marks</param>
		/// <param name="coefficient"> array of coefficient </param>
		static void computeAverage(int [,] marks, int[] coefficient) {
			// Ajouter le code y relatif ici 
		}

		/// <summary>
		/// Allow to sort Ascendant an array of String 
		/// </summary>
		/// <param name="table"></param>
		static void sortArrayAsc(String[] table) { 
			// Ajouter le code y relatif ici 
			// Utiliser l'algorithme QuickSort
		}

		/// <summary>
		/// Allow to sort Descendant an array of String
		/// </summary>
		/// <param name="table"></param>
		static void sortArrayDec(String[] table)
		{
			// Ajouter le code y relatif ici 
			//Utiliser l'algorithme tri fusion
		}

		/// <summary>
		/// Allow to sort Ascendant an array of integer
		/// </summary>
		/// <param name="table"></param>
		static void sortArrayAsc(int[] table)
		{
			// Ajouter le code y relatif ici 
			//utiliser l'algorithme de votre choix
		}

		/// <summary>
		/// Allow to sort Descendant an array of integer
		/// </summary>
		/// <param name="table"></param>
		static void sortArrayDec(int[] table)
		{
			// Ajouter le code y relatif ici 
			//utiliser l'algorithme de votre choix
		}


		static void Main(string[] args)
		{
			string[] students = new String[7]; // Containts Students name
			string[] subjects = new String[10]; // Containts Subjects informations
			int [] coefficient = new int[10]; // Containts coefficient information
			int[,] marks = new int[7, 10];
			int[] average = new int[7]; 
			
			fillTable(students, "Entrer un nom svp");
			fillTable(subjects, "Entrer une matière svp");
			fillTable(coefficient, "Entrer une valeur entière SVP");
			fillStumark(marks, subjects, students, 0, "Fill marks of ", "Enter mark (between 0 and 20)");
			//Calculer et afficher la moyenne de chaque élève par ordre croissant
			//Calculer et afficher la moyenne de chaque élève par ordre décroissant
			//Ecrire une fonction qui prend en entré le numéro d'un étudiant et retourne sa moyenne et son rang
			// Ecrire une fonction qui prend le rand d'une personne et retourne son nom
			// Ecrire une fonction qui retourne le nom du meilleur élève dans chaque matière
			// Ecrire une fonciton qui retourne la liste des élèves donc la note est supérieure à la moyenne
			// Ecrire une fonction qui retourne la liste des élèves donc la note est inférieure à la moyenne
			Console.ReadLine();
		}
	}
}
