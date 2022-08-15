using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject SettingPanel;
    public AudioSource ClickSound;

    public void NewGame()
    {
        ClickSound.Play();
        StartCoroutine(PlayNewGame());
    }

    public void LoadGame()
    {
        if (PlayerPrefs.GetInt("SaveHave") == 1)
        {
            ClickSound.Play();
            StartCoroutine(LoadCurGame());
        }
    }

    public void ResetGame()
    {
        ClickSound.Play();
        PlayerPrefs.SetInt("SaveDayPass", 0);
        PlayerPrefs.SetInt("SaveReputation", 0);
        PlayerPrefs.SetInt("SaveGH", 0);
        PlayerPrefs.SetInt("SaveW", 0);
        PlayerPrefs.SetInt("SavePW", 0);
        PlayerPrefs.SetInt("SaveF", 0);
        PlayerPrefs.SetInt("SaveHS", 0);
        PlayerPrefs.SetInt("SaveP", 0);
        PlayerPrefs.SetInt("SaveHave", 0);

        SceneManager.LoadScene(0);
    }

    public void Setting()
    {
        ClickSound.Play();
        SettingPanel.SetActive(true);
    }

    public void CloseSettingPanel()
    {
        ClickSound.Play();
        SettingPanel.SetActive(false);
    }

    public void ExitGame()
    {
        ClickSound.Play();
        Application.Quit();
    }

    IEnumerator PlayNewGame()
    {
        Tutorials.HavePassT = 0;
        DayPass.Days = 0;
        QuestController.Reputation = 0;
        BagController.GrassHerb = 0;
        BagController.Wheat = 0;
        BagController.PureWater = 0;
        BagController.Fish = 0;
        BagController.HealingSlayer = 0;
        BagController.Porridge = 0;

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(2);
    }

    IEnumerator LoadCurGame()
    {
        Tutorials.HavePassT = 1;
        DayPass.Days = PlayerPrefs.GetInt("SaveDayPass");
        QuestController.Reputation = PlayerPrefs.GetInt("SaveReputation");
        BagController.GrassHerb = PlayerPrefs.GetInt("SaveGH");
        BagController.Wheat = PlayerPrefs.GetInt("SaveW");
        BagController.PureWater = PlayerPrefs.GetInt("SavePW");
        BagController.Fish = PlayerPrefs.GetInt("SaveF");
        BagController.HealingSlayer = PlayerPrefs.GetInt("SaveHS");
        BagController.Porridge = PlayerPrefs.GetInt("SaveP");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(2);
    }
}
