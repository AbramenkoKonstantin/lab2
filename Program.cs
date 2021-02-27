using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
	class Document
	{
		private string name;
		private string author;
		private string keywords;
		private string theme;
		private string pathToFile;

        public Document()
        {
			
        }

        

        public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}

		public string Author
		{
			get
			{
				return author;
			}
			set
			{
				author = value;
			}
		}

		public string Keywords
		{
			get
			{
				return keywords;
			}
			set
			{
				keywords = value;
			}
		}

		public string Theme
		{
			get
			{
				return theme;
			}
			set
			{
				theme = value;
			}
		}

		public string PathToFile
		{
			get
			{
				return pathToFile;
			}
			set
			{
				pathToFile = value;
			}
		}



	}
	class Singleton : Document
	{
		public static Singleton Instance
		{
			get
			{
				if (instance == null) instance = new Singleton();
				return instance;
			}
		}
		public virtual void GetInformation()
		{
			Console.WriteLine(Name = "Файл");
			Console.WriteLine(Author = "Автор");
			Console.WriteLine(Keywords = "Ключевые слова");
			Console.WriteLine(Theme = "Тематика");
			Console.WriteLine();
		}
		
		public Singleton() { }
		public Singleton(string pathToFile)
		{
			PathToFile = pathToFile;
		}
		private static Singleton instance;
	}

	class HTML : Singleton
	{
		public HTML()
		{

		}

		public HTML(string pathToFile) : base(pathToFile)
		{

		}

        public override void GetInformation()
		{
            Console.WriteLine("Html");
			Singleton singleton = new Singleton();
			singleton.GetInformation();
			Console.Write($"Путь: {PathToFile}");
		}
	}

	class TXT : Singleton
	{
		public TXT()
		{

		}

		public TXT(string pathToFile) : base(pathToFile)
		{

		}

		public override void GetInformation()
		{
			Console.WriteLine("TXT");
			Singleton singleton = new Singleton();
			singleton.GetInformation();
			Console.Write($"Путь: {PathToFile}");
		}
	}

	class Excel : Singleton
	{
		public Excel()
		{

		}

		public Excel(string pathToFile) : base(pathToFile)
		{

		}

		public override void GetInformation()
		{
			Console.WriteLine("Excel");
			Singleton singleton = new Singleton();
			singleton.GetInformation();
			Console.Write($"Путь: {PathToFile}");
		}
	}

	class Word : Singleton
	{
		public Word()
		{

		}

		public Word(string pathToFile) : base(pathToFile)
		{

		}

		public override void GetInformation()
		{
			Console.WriteLine("Word");
			Singleton singleton = new Singleton();
			singleton.GetInformation();
			Console.Write($"Путь: {PathToFile}");
		}
	}

	class PDF : Singleton
	{
		public PDF()
		{

		}

		public PDF(string pathToFile) : base(pathToFile)
		{

		}

		public override void GetInformation()
		{
			Console.WriteLine("PDF");
			Singleton singleton = new Singleton();
			singleton.GetInformation();
			Console.WriteLine($"Путь: {PathToFile}");

		}
	}


	class Program
	{

        static void Main(string[] args)
		{
            Console.Write("Введите путь: ");
			string pathToFile = Console.ReadLine();
            Console.WriteLine("Выберите тип файла: \n1) .docx\n2) .pdf\n3) .xlsx\n4) .txt\n5) .html");
			string change = Console.ReadLine();
			switch (change)
            {
				case "1":
					Word word = new Word(pathToFile);
					word.GetInformation();
					break;
				case "2":
					PDF pdf = new PDF(pathToFile);
					pdf.GetInformation();
					break;
				case "3":
					Excel excel = new Excel(pathToFile);
					excel.GetInformation();
					break;
				case "4":
					TXT txt = new TXT(pathToFile);
					txt.GetInformation();
					break;
				case "5":
					HTML html = new HTML(pathToFile);
					html.GetInformation();
					break;
			}
			Console.ReadKey();
			
		}
	}
}
