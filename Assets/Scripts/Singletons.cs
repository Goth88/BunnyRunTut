using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singletons : MonoBehaviour
{
    public static Singletons instance;   
    public int location = 0;
    public string talkPoint;
    public string talk;
    public bool didBathroom = false;
    public bool gotUp = false;
  

    private void Awake()
    {
        MakeSingleton();
        talk = "That same dream, first on the ship, then dead!";
   
    }


    void MakeSingleton()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

    }
    private void Update()
    {
        if (talkPoint == "tookC")
        {
         //   talk = "I heard the click!";
        }
    }    
}
