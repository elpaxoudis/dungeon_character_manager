using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[System.Serializable]
public class Character {
    /* This class holds all the information about a character.
     */

    public string characterName;
    public string characterClass;

    public int level;

    public enum Attribute
    {
        STR,
        DEX,
        CON,
        INT,
        WIS,
        CHA,
        HP,
        BPP,
        BMP
    }

    public Dictionary<Attribute, int> attributes;

    public Character()
    {
        Random rnd = new Random();
        var values = Enum.GetValues(typeof(Attribute)).Cast<Attribute>();
        attributes = new Dictionary<Attribute, int>();
        foreach (Attribute attr in values)
        {
            attributes.Add(attr, rnd.Next(8, 20));
        }

        characterClass = "Warrior";
        characterName = "Lpax";
        level = rnd.Next(1, 100);
    }

	public Character(string charName, string charClass)
	{
		Random rnd = new Random();
		var values = Enum.GetValues(typeof(Attribute)).Cast<Attribute>();
		attributes = new Dictionary<Attribute, int>();
		foreach (Attribute attr in values)
		{
			attributes.Add(attr, rnd.Next(8, 20));
		}

		characterClass = charClass;
		characterName = charName;
		level = 1;
	}
}
