using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    public void ChangeScence(string nom)
    {
        SceneManager.LoadScene(nom);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
