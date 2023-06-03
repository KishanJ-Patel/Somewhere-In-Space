using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SMUIScript : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject LevelsMenu;
    public GameObject SettingsMenu;
    public GameObject LoadingScreen;

    public AudioSource UIAudio;

    private float Timer1;
    private float Timer2;
    private int Operator1;

    void Start()
    {
        UIAudio = transform.Find("UI Audio").GetComponent<AudioSource>();
        MainMenu.SetActive(false);
        LevelsMenu.SetActive(false);
        LoadingScreen.SetActive(false);
    }

    void Update()
    {   
        if (Operator1 == 1)
        {
            Timer1 += Time.deltaTime;
            Timer2 += Time.deltaTime;

            if (Timer1 >= 1f)
            {
                LoadingScreen.transform.Find("Text (TMP)").gameObject.SetActive(true);
            }
            else if (Timer2 >= 2f)
            {
                StartCoroutine(EasyGameLoadScene());
                Operator1++;
            }
        }
    }

    public void QuitButton()
    {
        UIAudio.Play();
        Application.Quit();
    }

    public void PlayButton()
    {
        UIAudio.Play();
        Time.timeScale = 0.3f;
        MainMenu.SetActive(false);
        LevelsMenu.SetActive(true);
    }

    public void SettingsButton()
    {
        UIAudio.Play();
        Time.timeScale = 0.3f;
        MainMenu.SetActive(false);
        SettingsMenu.SetActive(true);
    }

    public void LvlMenuBackButton()
    {
        UIAudio.Play();
        Time.timeScale = 1f;
        MainMenu.SetActive(true);
        LevelsMenu.SetActive(false);
    }

    public void LvlMenuEasyButton()
    {
        UIAudio.Play();
        Time.timeScale = 1f;
        LoadingScreen.SetActive(true);
        StartCoroutine(LoadingScreenLodingTextDelay());
        StartCoroutine(EasyGameLoadScene());
        LevelsMenu.SetActive(false);
    }

    public void LvlMenuNormalButton()
    {
        UIAudio.Play();
        Time.timeScale = 1f;
        StartCoroutine(LoadingScreenLodingTextDelay());
        StartCoroutine(EasyGameLoadScene());
        LoadingScreen.SetActive(true);
        LevelsMenu.SetActive(false);
    }

    public void LvlMenuHardButton()
    {
        UIAudio.Play();
        Time.timeScale = 1f;
        StartCoroutine(LoadingScreenLodingTextDelay());
        StartCoroutine(EasyGameLoadScene());
        LoadingScreen.SetActive(true);
        LevelsMenu.SetActive(false);
    }

    public void LvlMenuNightmareButton()
    {
        UIAudio.Play();
        Time.timeScale = 1f;
        StartCoroutine(LoadingScreenLodingTextDelay());
        StartCoroutine(EasyGameLoadScene());
        LoadingScreen.SetActive(true);
        LevelsMenu.SetActive(false);
    }

    IEnumerator LoadingScreenLodingTextDelay()
    {
        yield return new WaitForSecondsRealtime(1f);

        LoadingScreen.transform.Find("Text (TMP)").gameObject.SetActive(true);
    }

    IEnumerator EasyGameLoadScene()
    {   
        AsyncOperation SceneLoading = SceneManager.LoadSceneAsync(1);

        while (!SceneLoading.isDone)
        {
            yield return null;
        }
    }
}
