using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getUp2 : MonoBehaviour
{
    private string gotUp2 = "false";
    public GameObject player;

    private void Start()
    {
        gotUp2 = PlayerPrefs.GetString("gotUp2");
     
     if (PlayerPrefs.GetString("gotUp") == "true")
        {              
            Vector3 temp = transform.position; // copy to an auxiliary variable...
            temp.x = 1f;
            temp.y = -1.2f; // modify the component you want in the variable...
            transform.position = temp; // and save the modified value 
        }
      else
        {
            Vector3 temp = transform.position; // copy to an auxiliary variable...
            temp.x = 1f;
            temp.y = -30f; // modify the component you want in the variable...
            transform.position = temp; // and save the modified value 
        }
    }
    // Update is called once per frame
 //   void Update()
 //   {

   //     if (Input.GetMouseButtonUp(0) && gotUp2 == "true")
   //     {

    //        Vector3 temp = transform.position; // copy to an auxiliary variable...
   //         temp.y = -1.2f; // modify the component you want in the variable...
    //        transform.position = temp; // and save the modified value       
   //     }
    //    else
   //     { 
    //            PlayerPrefs.SetString("gotUp2", "true");           
    //    }
  //  }
    

}

