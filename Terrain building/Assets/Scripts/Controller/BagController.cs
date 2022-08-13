using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagController : MonoBehaviour
{
    public GameObject BagPanel;
    public Text GHT;
    public Text WT;
    public Text PWT;
    public Text FT;
    public Text HST;
    public Text PT;

    public static int GrassHerb;
    public int CGH;
    public static int Wheat;
    public int CW;
    public static int PureWater;
    public int CPW;
    public static int Fish;
    public int CF;
    public static int HealingSlayer;
    public int CHS;
    public static int Porridge;
    public int CP;

    public int dem;

    void Start()
    {
        dem = 0;
    }

    // Update is called once per frame
    void Update()
    {
        CGH = GrassHerb;
        CW = Wheat;
        CPW = PureWater;
        CF = Fish;
        CHS = HealingSlayer;
        CP = Porridge;

        GHT.text = "" + CGH;
        WT.text = "" + CW;
        PWT.text = "" + CPW;
        FT.text = "" + CF;
        HST.text = "" + CHS;
        PT.text = "" + CP;

        if (Input.GetKeyUp(KeyCode.B))
        {
            dem++;
        }

        if (dem % 2 != 0)
        {
            BagPanel.SetActive(true);
        }
        else if (dem % 2 == 0)
        {
            BagPanel.SetActive(false);
        }
    }
}
