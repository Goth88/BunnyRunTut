using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vitC : MonoBehaviour
{
    private AudioSource source;    
    public AudioClip bell;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    private void OnMouseOver()
    {

        if (Input.GetMouseButtonUp(0))
        {
         //   if (Singletons.instance.didBathroom)
            if(PlayerPrefs.GetString("didBathroom") == "true")
            {
                source.PlayOneShot(bell);
                // Singletons.instance.talkPoint = "tookC";
                PlayerPrefs.SetString("talkPoint", "tookC");
                PlayerPrefs.SetString("heardClick", "true");
                PlayerPrefs.SetString("talk", "I heard the bell!");
                this.Invoke("GoTalk", 1);
              //  SceneManager.LoadScene("Talk");
            }
            else
            {
                SceneManager.LoadScene("Main");
            }
        }
    }
    private void GoTalk()
    {
        SceneManager.LoadScene("Talk");
    }
}
