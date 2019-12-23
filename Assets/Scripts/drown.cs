using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class drown : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        Vector2 position = this.transform.position;
        position.y = position.y - .02f;
        this.transform.position = position;
        if (this.transform.position.y < -6)
        {
         //   print(this.transform.position.y);
           SceneManager.LoadScene("Talk");
        }
    }
}
