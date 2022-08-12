using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{
    public GameObject Message;
    public Text MessageText;
    public bool IsSave;
    // Start is called before the first frame update
    void Start()
    {
        IsSave = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F) && IsSave == true)
        {
            PlayerPrefs.SetInt("SaveDayPass", DayPass.Days);
            PlayerPrefs.SetInt("SaveGH", BagController.GrassHerb);
            PlayerPrefs.SetInt("SaveW", BagController.Wheat);
            PlayerPrefs.SetInt("SavePW", BagController.PureWater);
            PlayerPrefs.SetInt("SaveF", BagController.Fish);
            PlayerPrefs.SetInt("SaveHS", BagController.HealingSlayer);
            PlayerPrefs.SetInt("SaveP", BagController.Porridge);
            PlayerPrefs.SetInt("SaveHave", 1);
            Message.SetActive(true);
            MessageText.text = "Data Save";
            StartCoroutine(CloseMessage());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Message.SetActive(true);
        MessageText.text = "Press 'F' to save game";
        IsSave = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Message.SetActive(false);
        IsSave = false;
    }

    IEnumerator CloseMessage()
    {
        yield return new WaitForSeconds(1);

        Message.SetActive(false);
    }
}
