using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePause : MonoBehaviour
{
    public Behaviour UnityChanControlScriptWithRgidBody;
    public GameObject PausePanel;

    public AudioSource PauseSound;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            PauseSound.Play();
            UnityChanControlScriptWithRgidBody.enabled = false;
            PausePanel.SetActive(true);
        }
    }

    public void Resume()
    {
        PausePanel.SetActive(false);
        UnityChanControlScriptWithRgidBody.enabled = true;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(1);
    }
}
