using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GHPickUp : MonoBehaviour
{
    public GameObject Message;
    public Text MessageText;
    public bool IsPick;

    // Start is called before the first frame update
    void Start()
    {
        IsPick = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F) && IsPick == true)
        {
            BagController.GrassHerb += 1;
            Message.SetActive(false);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Message.SetActive(true);
        MessageText.text = "Press 'F' to pick up";
        IsPick = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Message.SetActive(false);
        IsPick = false;
    }
}
