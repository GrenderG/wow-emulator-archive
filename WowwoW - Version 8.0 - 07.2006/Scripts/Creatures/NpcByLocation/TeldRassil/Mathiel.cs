using System;
using Server.Items;
using HelperTools;


namespace Server.Creatures
{
	public class Mathiel : BaseNPC
	{
		public Mathiel() : base()
		{
			Name = "Mathiel";
			Id = 6142;
			Model = 5083;
			Level = RandomLevel(33);
			SetDamage(1f+1.8f*Level,1f+2.5*Level);			
			AttackSpeed = 2000;
			Armor = Level*15;
			Block = 0;
			ResistArcane = 0;
			ResistFire = 0;
			ResistFrost = 0;
			ResistHoly = 0;
			ResistNature = 0;
			Flags1=0x08480046;
			BaseMana = 0;
			BoundingRadius = 0.420f;
			CombatReach = 2.5f;
			Size = 1f;
			Speed = 2.9f;
			WalkSpeed = 2.9f;
			RunSpeed = 5.9f;
			Str = (int)(Level/2.5f);
			Faction = Factions.Alliance;
			AIEngine = new StandingNpcAI( this );
			NpcType = 7;
			NpcFlags = (int)NpcActions.Dialog; 
			Equip( new Item( 7838, InventoryTypes.MainGauche, 2, 4, 2, 3, 0, 0, 0 ) );
			Loots = new BaseTreasure[]{  new BaseTreasure(Drops.MoneyB , 100f ) };
			/*****************************/
			BCAddon.Hp( this, 486, 33 );
			/*****************************/
		}
	}
}
