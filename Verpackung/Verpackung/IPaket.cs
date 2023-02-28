using System;
namespace Verpackung
{
	public interface IPaket
	{
		Person Empfänger { get; set; }

		void Verpacken();
	}
}

