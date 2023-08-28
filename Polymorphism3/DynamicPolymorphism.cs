namespace Polymorphism3
{
	class Arac
	{
		public virtual void Calistir() => Console.WriteLine("Araç çalıştı...");
	}
	class Taksi : Arac 
	{
		public override void Calistir() => Console.WriteLine("Taksi çalıştı..");
	}
}
