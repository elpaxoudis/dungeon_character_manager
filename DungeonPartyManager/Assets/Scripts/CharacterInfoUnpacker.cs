using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInfoUnpacker : MonoBehaviour {
	public Text characterName;
	public Text characterClass;

	public PlayerStatsController playerStatsController;
	public MenuController menuController;

	private Character myChar;

	public void Unpack(Character aCharacter)
	{
		myChar = aCharacter;

		characterName.text = myChar.characterName;
		characterClass.text = myChar.characterClass;
	}

	public void OpenCharacterStatsPanel()
	{
		playerStatsController.UnpackInfo (myChar);
		menuController.OpenPanel (menuController.characterStatsPanel);
		menuController.ClosePanel (menuController.characterListPanel);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
