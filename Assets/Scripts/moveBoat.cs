using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveBoat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = this.transform.position;
        position.x = position.x + .05f;
        this.transform.position = position;
        if (this.transform.position.x > 13)
        {
            SceneManager.LoadScene("Drown");
        }
    }
}
