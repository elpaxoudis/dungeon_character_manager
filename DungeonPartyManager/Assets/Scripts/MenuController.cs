using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

	public GameObject characterStatsPanel;
	public GameObject characterCreationInfo;
	public GameObject characterListPanel;

	public void OpenPanel(GameObject panel)
	{
		panel.SetActive (true);
	}

	public void ClosePanel(GameObject panel)
	{
		panel.SetActive (false);
	}

    private void Start()
    {
        //if (characterStatsPanelGO == null)
        //    Debug.Log("No character stats panel object found!!");
        //else
        //    characterController.UnpackStats(characterStatsPanelGO);
    }

	private void Update()
	{
		if (Input.GetKeyUp (KeyCode.Escape)) 
		{
			characterStatsPanel.SetActive (false);
		}
	}
}
