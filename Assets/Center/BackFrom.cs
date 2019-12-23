using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackFrom : MonoBehaviour
{
    string location = "";
    public AudioClip doorsound;
    private AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        location = PlayerPrefs.GetString("location");

        if (location == "Center")
        {
            source.PlayOneShot(doorsound);
        }
    }   
   
}
