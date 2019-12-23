using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoLimits : MonoBehaviour
{
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
                _walk.OffLimits();

            }
        }
    }
}
