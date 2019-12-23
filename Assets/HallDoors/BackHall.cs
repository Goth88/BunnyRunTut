using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackHall : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        PlayerPrefs.SetString("doorSound", "hallDoors");
        SceneManager.LoadScene("Hallway1");
    }
}
