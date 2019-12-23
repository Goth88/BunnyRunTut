using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class getUp : MonoBehaviour
{
    private bool gotUp;
    public GameObject bedded;   
    public TextMeshProUGUI uiText;
    public GameObject analysis;
    private string didBathroom;
    public GameObject player;
    private string returnMain;
    private bool notNowY;


    private void Start()
    {    
        returnMain = PlayerPrefs.GetString("returnMain");
        if(returnMain == "true")
        {
            Vector3 temp = player.transform.position; // copy to an auxiliary variable...
            temp.y = -1.2f; // modify the component you want in the variable...
            temp.x = 1f;
            player.transform.position = temp; // and save
        }
        if (PlayerPrefs.GetString("gotUp") == "true");
          {
             gotUp = true;
           //  Destroy(bedded);
         }      

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            // print("grape");
            Destroy(bedded);
            if (uiText.text != "")
            {
                uiText.text = "";
            }
            if (returnMain != "true")
            { 
                //  gotUp = true;
                //   Destroy(bedded);
                PlayerPrefs.SetString("gotUp", "true");
                Vector3 temp = player.transform.position; // copy to an auxiliary variable...
                if (!notNowY)
                {
                    temp.y = -1.2f; // modify the component you want in the variable...
                }
                    player.transform.position = temp; // and save the modified value       
                                                      //   print(player.transform.position.x);
                
                notNowY = true;
            }
                      

        }
        didBathroom = PlayerPrefs.GetString("didBathroom");
        if (didBathroom == "true")
        {
            analysis.SetActive(true);
        }
        else
        {
            analysis.SetActive(false);
        }
    }    
}
