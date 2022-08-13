using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DayPass : MonoBehaviour
{
    public Text DayText;
    public GameObject SleepTrigger;
    public GameObject FadeOutSleep;
    public GameObject Message;
    public Text MessageText;
    public static int Days;
    public int CDays;
    public bool IsSleep;

    // Start is called before the first frame update
    void Start()
    {
        IsSleep = false;
    }

    // Update is called once per frame
    void Update()
    {
        CDays = Days;
        DayText.text = "Days: " + CDays;
        if (Input.GetKeyUp(KeyCode.F) && IsSleep == true)
        {
            Days += 1;
            FadeOutSleep.GetComponent<Animator>().enabled = true;
            SleepTrigger.GetComponent<BoxCollider>().enabled = false;
            IsSleep = false;
            StartCoroutine(CloseSleep());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Message.SetActive(true);
        MessageText.text = "Press 'F' to sleep";
        IsSleep = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Message.SetActive(false);
        IsSleep = false;
    }

    IEnumerator CloseSleep()
    {
        yield return new WaitForSeconds(1);

        FadeOutSleep.GetComponent<Animator>().enabled = false;
        SleepTrigger.GetComponent<BoxCollider>().enabled = true;
        IsSleep = true;
        SceneManager.LoadScene(2);
    }
}
