using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBackHC : MonoBehaviour
{

    public float speed = 3f;
    private Vector3 target;
    private bool moving;
    Animator animator;
    public GameObject thePlayer;
    public WalkCenter _walk;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (Input.GetMouseButtonUp(0))
            {                
                PlayerPrefs.SetString("location", "Center");
                _walk.GoHall();

            }
        }
    }
}