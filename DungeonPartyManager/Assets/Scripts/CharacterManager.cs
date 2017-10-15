using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour {

    public List<Character> allCharacters;
	public List<GameObject> allCharacterListButtons;

	public InputField nameInput;
	public InputField classInput;

	public GameObject characterCreationPanel;
	public GameObject characterListContentGO;
	public GameObject characterListButtonPrefab;

	private void ClearCharacterListContent()
	{
		allCharacterListButtons.Clear ();
	}

	private void UpdateCharacterListContent(Character characterToAdd)
	{
		GameObject newInfo = Instantiate (characterListButtonPrefab);
		newInfo.GetComponent<CharacterInfoUnpacker> ().Unpack (characterToAdd);
		newInfo.transform.SetParent (characterListContentGO.transform);
		newInfo.GetComponent<CharacterInfoUnpacker> ().playerStatsController = GetComponent<PlayerStatsController> ();
		newInfo.GetComponent<CharacterInfoUnpacker> ().menuController = GetComponent<MenuController> ();

		allCharacterListButtons.Add (newInfo);
	}

	public void createNewCharacter(){
		string characterName = nameInput.textComponent.text;
		string characterClass = classInput.textComponent.text;

		Debug.Log (characterName + " " + characterClass);

		Character newChar = new Character (characterName, characterClass);
		allCharacters.Add (newChar);

		UpdateCharacterListContent (newChar);

		GetComponent<MenuController> ().ClosePanel (characterCreationPanel);
	}
}
