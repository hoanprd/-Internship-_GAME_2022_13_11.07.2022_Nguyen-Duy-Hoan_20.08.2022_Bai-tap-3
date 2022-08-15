using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorials : MonoBehaviour
{
    public Behaviour UnityChanControlScriptWithRgidBody;
    public GameObject TPanel;
    public GameObject[] T;
    public static int HavePassT;
    public bool IsT;
    public bool DoneT;
    public int dem;

    // Start is called before the first frame update
    void Start()
    {
        IsT = true;
        DoneT = false;
        dem = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (HavePassT == 0)
        {
            if (IsT == true)
            {
                TPanel.SetActive(true);
                UnityChanControlScriptWithRgidBody.enabled = false;
            }
            else if (IsT == false && DoneT == true)
            {
                HavePassT = 1;
                TPanel.SetActive(false);
                UnityChanControlScriptWithRgidBody.enabled = true;
                DoneT = false;
            }

            if (IsT == true)
            {
                if (Input.GetKeyUp(KeyCode.F) && IsT == true)
                {
                    dem++;
                }

                for (int i = 0; i < T.Length; i++)
                {
                    if (i == dem)
                    {
                        T[i].SetActive(true);
                    }
                }

                if (dem >= T.Length)
                {
                    IsT = false;
                    DoneT = true;
                }
            }
        }
    }
}
