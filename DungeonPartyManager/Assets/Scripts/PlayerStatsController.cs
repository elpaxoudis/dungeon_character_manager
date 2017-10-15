using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatsController : MonoBehaviour {
    /* This class will be all about unpacking and rendering the information of the player
     * on the screen.
     */

    // We need a character to unpack
    Character myChar;

    // Character Name Text object
    public Text characterNameTxt;

    // Character Class Text object
    public Text characterClassTxt;

    // Character Level Text object
    public Text characterLevelTxt;

    // Attributes Text objects
    public Text hpTxt;
    public Text strTxt;
    public Text dexTxt;
    public Text conTxt;
    public Text intTxt;
    public Text wisTxt;
    public Text chaTxt;

    // Basic Magic Power Text object
    public Text bmpTxt;

    // Basic Physical Power Text object
    public Text bppTxt;

	public void UnpackInfo(Character myChar)
	{
		characterNameTxt.text = myChar.characterName;
		characterClassTxt.text = myChar.characterClass;
		characterLevelTxt.text = myChar.level.ToString();

		bppTxt.text = myChar.attributes[Character.Attribute.BPP].ToString();
		bmpTxt.text = myChar.attributes[Character.Attribute.BMP].ToString();

		hpTxt.text = myChar.attributes[Character.Attribute.HP].ToString();
		strTxt.text = myChar.attributes[Character.Attribute.STR].ToString();
		dexTxt.text = myChar.attributes[Character.Attribute.DEX].ToString();
		conTxt.text = myChar.attributes[Character.Attribute.CON].ToString();
		intTxt.text = myChar.attributes[Character.Attribute.INT].ToString();
		wisTxt.text = myChar.attributes[Character.Attribute.WIS].ToString();
		chaTxt.text = myChar.attributes[Character.Attribute.CHA].ToString();
	}

    // Use this for initialization
    void Start () {
        //TODO for now we will call a default constructor for the character
        myChar = new Character();

        characterNameTxt.text = myChar.characterName;
        characterClassTxt.text = myChar.characterClass;
        characterLevelTxt.text = myChar.level.ToString();

        bppTxt.text = myChar.attributes[Character.Attribute.BPP].ToString();
        bmpTxt.text = myChar.attributes[Character.Attribute.BMP].ToString();

        hpTxt.text = myChar.attributes[Character.Attribute.HP].ToString();
        strTxt.text = myChar.attributes[Character.Attribute.STR].ToString();
        dexTxt.text = myChar.attributes[Character.Attribute.DEX].ToString();
        conTxt.text = myChar.attributes[Character.Attribute.CON].ToString();
        intTxt.text = myChar.attributes[Character.Attribute.INT].ToString();
        wisTxt.text = myChar.attributes[Character.Attribute.WIS].ToString();
        chaTxt.text = myChar.attributes[Character.Attribute.CHA].ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    
}
