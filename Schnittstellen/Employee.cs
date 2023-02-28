using System;
namespace Schnittstellen
{
	public class Employee : IPerson, IPilot
	{
		public string Firstname { get; set; }

		public string Surname { get; set; }

        public void AddDataToOnBoardComputer(string data)
        {
            // add data to an on-board computer
        }
    }
}

