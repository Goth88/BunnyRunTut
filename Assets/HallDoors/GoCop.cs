using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoCop : MonoBehaviour
{
    public float speed = 1.5f;
    private Vector3 target;
    private bool moving;
    Animator animator;
    public GameObject thePlayer;
    public WalkDoors _walk;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (Input.GetMouseButtonUp(0))
            {
               // PlayerPrefs.SetString("returnMain", "true");
                _walk.GoToCop();

            }            
        }
    }
}
