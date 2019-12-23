using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSoundC : MonoBehaviour
{

    public AudioClip doorsound;    
    private AudioSource source;
    // Start is called before the first frame update
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    private void Start()
    {
        source.PlayOneShot(doorsound);
    }
}
