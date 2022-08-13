using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestController : MonoBehaviour
{
    public GameObject QuestPanel;
    public GameObject Message;
    public Text MessageText;
    public GameObject CommitB1;
    public GameObject CommitB2;
    public GameObject Tick1;
    public GameObject Tick2;

    public int[] CommitMaterials = new int[] {BagController.GrassHerb, BagController.Wheat, BagController.PureWater, BagController.Fish};
    public int[] CommitItems = new int[] {BagController.HealingSlayer, BagController.Porridge};

    public GameObject[] MaterialsI;
    public GameObject[] ItemsI;

    public int RandM;
    public int RandI;

    public bool IsQuest;

    // Start is called before the first frame update
    void Start()
    {
        IsQuest = false;
        RandM = Random.Range(0, 4);
        RandI = Random.Range(0, 2);
        for (int i = 0; i < CommitMaterials.Length; i++)
        {
            if (i == RandM)
            {
                MaterialsI[i].SetActive(true);
            }
        }

        for (int j = 0; j < CommitItems.Length; j++)
        {
            if (j == RandI)
            {
                ItemsI[j].SetActive(true);
            }
        }
    }

    void Update()
    {
        CommitMaterials = new int[] { BagController.GrassHerb, BagController.Wheat, BagController.PureWater, BagController.Fish };
        CommitItems = new int[] { BagController.HealingSlayer, BagController.Porridge };
        if (Input.GetKeyUp(KeyCode.F) && IsQuest == true)
        {
            QuestPanel.SetActive(true);
        }
    }

    public void Commit1()
    {
        for (int i = 0; i < CommitMaterials.Length; i++)
        {
            if (i == RandM && CommitMaterials[i] > 0)
            {
                CommitMaterials[i] -= 1;
                CommitB1.SetActive(false);
                Tick1.SetActive(true);
            }
        }
    }

    public void Commit2()
    {
        for (int i = 0; i < CommitItems.Length; i++)
        {
            if (i == RandI && CommitItems[i] > 0)
            {
                CommitItems[i] -= 1;
                CommitB2.SetActive(false);
                Tick2.SetActive(true);
            }
        }
    }

    public void CloseQuestPanel()
    {
        QuestPanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Message.SetActive(true);
        MessageText.text = "Press 'F' to do quests";
        IsQuest = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Message.SetActive(false);
        MessageText.text = "Press 'F' to do quests";
        IsQuest = false;
    }
}
