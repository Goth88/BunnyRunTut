using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour
{
    public void GoCredit()
    {
        SceneManager.LoadScene("Credits");        
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void CutScene()
    {
        SceneManager.LoadScene("CutShip");
    }
}
