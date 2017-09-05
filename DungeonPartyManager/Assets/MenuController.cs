using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

    public PlayerStatsController characterController;

    public GameObject characterStatsPanelGO;

    public void OpenCharacterStatsPanel()
    {
        characterStatsPanelGO.SetActive(true);
        //characterController.UnpackStats(characterStatsPanelGO);
    }

    public void CloseCharacterStatsPanel()
    {
        characterStatsPanelGO.SetActive(false);
    }

    private void Start()
    {
        //if (characterStatsPanelGO == null)
        //    Debug.Log("No character stats panel object found!!");
        //else
        //    characterController.UnpackStats(characterStatsPanelGO);
    }
}
