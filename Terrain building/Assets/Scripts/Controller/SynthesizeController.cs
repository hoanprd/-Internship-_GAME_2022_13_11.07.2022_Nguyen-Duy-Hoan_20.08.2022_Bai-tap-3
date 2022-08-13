using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SynthesizeController : MonoBehaviour
{
    public GameObject SynPanel;
    public GameObject Message;
    public Text MessageText;
    public Text GHT;
    public Text WT;
    public Text PWT;
    public Text PWT2;
    public Text HST;
    public Text PT;
    public bool IsSyn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GHT.text = "" + BagController.GrassHerb;
        WT.text = "" + BagController.Wheat;
        PWT.text = "" + BagController.PureWater;
        PWT2.text = "" + BagController.PureWater;
        HST.text = "" + BagController.HealingSlayer;
        PT.text = "" + BagController.Porridge;

        if (Input.GetKeyUp(KeyCode.F) && IsSyn == true)
        {
            SynPanel.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Message.SetActive(true);
        MessageText.text = "Press 'F' to synthesize";
        IsSyn = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Message.SetActive(false);
        IsSyn = false;
    }

    public void SynHelaingSlayer()
    {
        if (BagController.GrassHerb > 0 && BagController.PureWater > 0)
        {
            BagController.HealingSlayer += 1;
            BagController.GrassHerb -= 1;
            BagController.PureWater -= 1;
        }
    }

    public void SynPorridge()
    {
        if (BagController.Wheat > 0 && BagController.PureWater > 0)
        {
            BagController.Porridge += 1;
            BagController.Wheat -= 1;
            BagController.PureWater -= 1;
        }
    }    

    public void CloseSynPanel()
    {
        SynPanel.SetActive(false);
    }
}
