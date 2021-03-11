using System;

namespace İnterFacesDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			IWork[] works = new IWork[3] {new Worker(),new Manager(),new Robot() };
			foreach (var worker in works)
			{
				worker.Work();
			}
			IEat[] eats = new IEat[2] {new Worker(),new Manager()};
			foreach (var eat in eats)
			{
				eat.Eat();
			}
		}
		interface IWork
		{
			
			void Work();

		}
		interface IGetSallary
		{
				void GetSallary();
	}
		interface IEat
		{
			void Eat();
		}
		class Manager : IWork, IEat, IGetSallary
		{
			public void Eat()
			{
				throw new NotImplementedException();
			}

			public void GetSallary()
			{
				throw new NotImplementedException();
			}

			public void Work()
			{
				throw new NotImplementedException();
			}
		}
		class Worker : IWork, IGetSallary, IEat
		{
			public void Eat()
			{
				throw new NotImplementedException();
			}

			public void GetSallary()
			{
				throw new NotImplementedException();
			}

			public void Work()
			{
				throw new NotImplementedException();
			}
		}
		class Robot : IWork
		{
			public void Work()
			{
				throw new NotImplementedException();
			}
		}
	}
}
