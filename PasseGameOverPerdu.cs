using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasseGameOverPerdu : MonoBehaviour
{
    void start()
    {
        StartCoroutine(TimerTake());
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    IEnumerator TimerTake()
    {
        yield return new WaitForSeconds(3);
    }

}

