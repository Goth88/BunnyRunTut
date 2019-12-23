using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackHall3 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        PlayerPrefs.SetString("location", "HallCenter");
        SceneManager.LoadScene("Hall3");
    }
}
