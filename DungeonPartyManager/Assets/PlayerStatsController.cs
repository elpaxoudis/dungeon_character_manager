using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatsController : MonoBehaviour {

    public string characterName = "Character Name";

    public enum Attribute
    {
        STR,
        DEX,
        CON,
        INT,
        WIS,
        CHA,
        HP,
        BAP,
        BMP
    }

    public Dictionary<Attribute, int> attributes = new Dictionary<Attribute, int>();

    public int healthPoints = 999;
    public int basicAttackPower = 999;
    public int basicMagicPower = 999;

    public int strength = 999;
    public int dexterity = 999;
    public int constitution = 999;
    public int intelligence = 999;
    public int wisdom = 999;
    public int charisma = 999;

    // Use this for initialization
    void Start () {
        attributes[Attribute.STR] = strength;
        attributes[Attribute.DEX] = dexterity;
        attributes[Attribute.CON] = constitution;
        attributes[Attribute.INT] = intelligence;
        attributes[Attribute.WIS] = wisdom;
        attributes[Attribute.CHA] = charisma;
        attributes[Attribute.HP] = healthPoints;
        attributes[Attribute.BAP] = basicAttackPower;
        attributes[Attribute.BMP] = basicMagicPower;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    
}
