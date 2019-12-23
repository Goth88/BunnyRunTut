using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleeperGone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetString("gotUp") == "true")
        {
            Destroy(gameObject);
        }
    }   
}
