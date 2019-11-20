namespace BinaryMapCounter
{
	public class Character
	{
		public CharacterPoint Point { get; set; }
		public CharacterType Type { get; set; }
		public bool IsCounted { get; set; }

		public Character(CharacterPoint point, CharacterType type)
		{
			Point = point;
			Type = type;
			IsCounted = false;
		}
	}
}
