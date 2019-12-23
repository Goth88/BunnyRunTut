using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vitOther : MonoBehaviour
{
    private AudioSource source;
    public AudioClip latch;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    private void OnMouseOver()
    {

        if (Input.GetMouseButtonUp(0))
        {            
                source.PlayOneShot(latch);             
                SceneManager.LoadScene("Main");           
        }
    }
}
