using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayPrefs : MonoBehaviour
{

    string talkPoint;
    string location;
    string talk;
    string didBathroom;
    string gotUp;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("location", "none");
        PlayerPrefs.SetString("talkPoint", "nothing");
        PlayerPrefs.SetString("talk", "That same dream, first on the ship, then dead!");
        PlayerPrefs.SetString("didBathroom", "false");
        PlayerPrefs.SetString("gotUp", "false");
        PlayerPrefs.SetString("returnMain", "false");
        PlayerPrefs.SetString("heardClick", "false");
        PlayerPrefs.SetString("inBathroom", "false");
        PlayerPrefs.SetString("doorSound", "true");


        talkPoint = PlayerPrefs.GetString("talkPoint");
        talk = PlayerPrefs.GetString("talk");
        //don't put PlayerPrefs in Update;
        //  print(PlayerPrefs.GetString("location"));
    }
    private void Update()
    {
        // print(PlayerPrefs.GetString("talkPoint"));
      //  print(PlayerPrefs.GetString("talk"));
            
        if (talkPoint == "gotUp");
        {
            //  PlayerPrefs.SetString("talk", "I heard the click!");
            talk = "I heard the Click!";
            
        }
    }


}
