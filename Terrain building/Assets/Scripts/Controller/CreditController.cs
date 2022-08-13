using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EndCredit());
    }

    IEnumerator EndCredit()
    {
        yield return new WaitForSeconds(4);

        SceneManager.LoadScene(1);
    }
}
