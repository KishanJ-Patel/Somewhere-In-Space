using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public GameObject PauseBtn;
    public GameObject PauseMnu;

    public GameObject Player;

    public GameObject TDEyellow;

    public GameObject LoadingScreen;

    public AudioSource UIAudio;


    void Start()
    {
        UIAudio = transform.Find("UI Audio").GetComponent<AudioSource>();
        PauseBtn.SetActive(true);
        PauseMnu.SetActive(false);
    }

    public void PauseButton()
    {
        Time.timeScale = 0f;
        TDEyellow.GetComponent<AudioSource>().Pause();
        UIAudio.Play();
        Player.GetComponent<Rigidbody>().freezeRotation = true;
        transform.Find("Joystick").gameObject.GetComponent<bl_Joystick>().enabled = false;
        transform.Find("Fire Button").gameObject.GetComponent<Button>().interactable = false;
        PauseMnu.SetActive(true);
        PauseBtn.SetActive(false);
    }

    public void ResumeButton()
    {
        Time.timeScale = 1f;
        UIAudio.Play();
        TDEyellow.GetComponent<AudioSource>().UnPause();
        Player.GetComponent<Rigidbody>().freezeRotation = false;
        transform.Find("Joystick").gameObject.GetComponent<bl_Joystick>().enabled = true;
        transform.Find("Fire Button").gameObject.GetComponent<Button>().interactable = true;
        PauseBtn.SetActive(true);
        PauseMnu.SetActive(false);
    }

    public void ExitButton()
    {
        UIAudio.Play();
        StartCoroutine(LoadingScreenLodingTextDelay());
        StartCoroutine (MainMenuLoadScene());
        PauseMnu.SetActive(false);
        LoadingScreen.SetActive(true);
    }

    IEnumerator LoadingScreenLodingTextDelay()
    {
        yield return new WaitForSecondsRealtime(1f);

        LoadingScreen.transform.Find("Text (TMP)").gameObject.SetActive(true);
    }

    IEnumerator MainMenuLoadScene()
    {
        AsyncOperation LoadScreen = SceneManager.LoadSceneAsync(0);

        while (!LoadScreen.isDone)
        {
            yield return null;
        }
    }
}

