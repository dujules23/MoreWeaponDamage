using System;
using System.Diagnostics;
namespace MoreWeaponDamage
{
	public class SwordDamage
	{
		public SwordDamage(int startingRoll)
		{
			roll = startingRoll;
			CalculateDamage();
			Console.WriteLine("Created an instance of SwordDamage");
		}

		private const int BASE_DAMAGE = 3;
		private const int FLAME_DAMAGE = 2;

        public int Damage { get; private set; }

        // Removed old fields and created backing field and property for roll, flaming, and magic.
        private int roll;

		public int Roll
		{
			get { return roll; }
			set
			{
				roll = value;
				CalculateDamage();
			}
		}

		private bool flaming;

		public bool Flaming
		{
			get { return flaming; }
			set
			{
				flaming = value;
				CalculateDamage();
			}
		}

		private bool magic;

		public bool Magic
		{
			get { return magic; }
			set
			{
				magic = value;
				CalculateDamage();
			}
		}

		

		private void CalculateDamage()
		{
			decimal magicMultiplier = 1M;
			if (Magic) magicMultiplier = 1.75M;

			Damage = BASE_DAMAGE;
			Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
			if (Flaming) Damage += FLAME_DAMAGE;
			Console.WriteLine($"CalculateDamage finished: {Damage} (roll: {Roll})");
		}

	}
}

