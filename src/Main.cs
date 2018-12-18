using System;

namespace persons {
	class Program {
		static void Main() {			
			Console.WriteLine("Hello world!!!");
			Person p = new Person(1,"Peter");
			Person p1 = new Person(1,"Peter");
			Console.WriteLine("Hello " + p);
			Console.WriteLine("Hello " + p1);
			Console.WriteLine("p == p1 {0} ",p == p1);
			Console.WriteLine("p != p1 {0} ",p != p1);
			//Console.WriteLine("xx = "+Math.Sqrt(1225));
			//Console.WriteLine("xx = "+(45*45));
			Console.WriteLine("p.Equals(p1) {0} ",p.Equals(p1));						
			Console.WriteLine("!p.Equals(p1) {0} ",!p.Equals(p1));						
		}
	}
}
