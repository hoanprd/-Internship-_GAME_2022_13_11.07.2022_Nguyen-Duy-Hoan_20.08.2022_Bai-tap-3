using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestController : MonoBehaviour
{
    public Behaviour UnityChanControlScriptWithRgidBody;
    public GameObject QuestPanel;
    public GameObject Message;
    public Text MessageText;
    public Text ReputationText;
    public GameObject CommitB1;
    public GameObject CommitB2;
    public GameObject Tick1;
    public GameObject Tick2;
    public AudioSource CompleteSound;

    public static int Reputation;
    public int CReputation;

    public int[] CommitMaterials = new int[] {BagController.GrassHerb, BagController.Wheat, BagController.PureWater, BagController.Fish, BagController.Rock, BagController.Tephra};
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
        if (DayPass.Days < 7)
        {
            RandM = Random.Range(0, 4);
            RandI = Random.Range(0, 2);
        }
        else
        {
            RandM = Random.Range(0, 6);
            RandI = Random.Range(0, 2);
        }
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
        CReputation = Reputation;
        ReputationText.text = "Reputation: " + CReputation + "/20";
        CommitMaterials = new int[] { BagController.GrassHerb, BagController.Wheat, BagController.PureWater, BagController.Fish };
        CommitItems = new int[] { BagController.HealingSlayer, BagController.Porridge };
        if (Input.GetKeyUp(KeyCode.F) && IsQuest == true)
        {
            UnityChanControlScriptWithRgidBody.enabled = false;
            QuestPanel.SetActive(true);
        }

        if (Reputation >= 20)
        {
            SceneManager.LoadScene(4);
        }
    }

    public void Commit1()
    {
        for (int i = 0; i < CommitMaterials.Length; i++)
        {
            if (i == RandM && CommitMaterials[i] > 0 && Reputation < 20)
            {
                CompleteSound.Play();
                Reputation += 1;
                CommitMaterials[i] -= 1;
                if (i == 0)
                {
                    BagController.GrassHerb = CommitMaterials[i];
                }
                else if (i == 1)
                {
                    BagController.Wheat = CommitMaterials[i];
                }
                else if (i == 2)
                {
                    BagController.PureWater = CommitMaterials[i];
                }
                else if (i == 3)
                {
                    BagController.Fish = CommitMaterials[i];
                }
                else if (i == 4)
                {
                    BagController.Rock = CommitMaterials[i];
                }
                else if (i == 5)
                {
                    BagController.Tephra = CommitMaterials[i];
                }
                CommitB1.SetActive(false);
                Tick1.SetActive(true);
            }
        }
    }

    public void Commit2()
    {
        for (int i = 0; i < CommitItems.Length; i++)
        {
            if (i == RandI && CommitItems[i] > 0 && Reputation < 20)
            {
                CompleteSound.Play();
                Reputation += 1;
                CommitItems[i] -= 1;
                if (i == 0)
                {
                    BagController.HealingSlayer = CommitItems[i];
                }
                else if (i == 1)
                {
                    BagController.Porridge = CommitItems[i];
                }
                CommitB2.SetActive(false);
                Tick2.SetActive(true);
            }
        }
    }

    public void CloseQuestPanel()
    {
        QuestPanel.SetActive(false);
        UnityChanControlScriptWithRgidBody.enabled = true;
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
