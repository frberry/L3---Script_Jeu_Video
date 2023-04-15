using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement; 

public class TimerCountdown : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public int secondsLeft = 30;
    public int minutesLeft = 1;
    public bool takingAway = false;
    public string nom; 

    // Start is called before the first frame update
    void Start()
    {
        textDisplay.text = "0" + minutesLeft + ":" + secondsLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if(takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }

    IEnumerator TimerTake()
    {
        takingAway=true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;

        if (secondsLeft == 0 && minutesLeft > 0 )
        {
            textDisplay.text = "0" + minutesLeft + ":00";
            yield return new WaitForSeconds(1);
            minutesLeft -=1; 
            secondsLeft = 59;
        }
        if (secondsLeft <10)
        {
            textDisplay.text = "0" + minutesLeft + ":0" + secondsLeft;
        }
        if (secondsLeft == 0 && minutesLeft== 0)
        {
            SceneManager.LoadScene(nom);
        }
        else
        {
            textDisplay.text = "0" + minutesLeft + ":" + secondsLeft;
        }

        takingAway = false;

    }
}