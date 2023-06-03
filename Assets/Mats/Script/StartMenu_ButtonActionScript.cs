using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu_ButtonActionScript : MonoBehaviour
{   
    //public variables
    [Header("Game Object")]
    public GameObject MainMenu;
    public GameObject LevelMenu;

    //Main Menu
    public void MainMenuPlayButton()
    {
        MainMenu.SetActive(value: false);
        LevelMenu.SetActive(value: true);
    }
    
    public void MainMenuQuitButton()
    {
        Application.Quit();
    }

    //Level Menu
    public void LevelMenuLevel1Button()
    {
        SceneManager.LoadScene(1);
    }

    public void LevelMenuBackButton()
    {
        LevelMenu.SetActive(value: false);
        MainMenu.SetActive(value: true);
    }
}
