using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Sortie : MonoBehaviour
{
    // Start is called before the first frame update
    public nbobjets nbobjet;
    int objmanquants;
    public TextMeshProUGUI textDisplay;

    public void OnCollisionEnter (Collision infoCollision)
    {
        textDisplay.text = "";
        if (infoCollision.gameObject.name=="Capsule" && nbobjet.nbObj==7)
        {
            SceneManager.LoadScene("Sortie");

        } 
        
        else if (infoCollision.gameObject.name=="Capsule" && nbobjet.nbObj<7) 
        {
            StartCoroutine(waiter());
        } 
    }

    IEnumerator waiter()
    {
        objmanquants=7-nbobjet.nbObj;
        textDisplay.text = "Il manque "+ objmanquants+" objets";
        yield return new WaitForSeconds(3);
        textDisplay.text = "";
    }

}
