using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoCenter : MonoBehaviour
{
    public float speed = 1.5f;
    private Vector3 target;
    private bool moving;
    Animator animator;
    public GameObject thePlayer;
    public WalkHallCenter _walk;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (Input.GetMouseButtonUp(0))
            {
                // PlayerPrefs.SetString("returnMain", "true");
                _walk.GoCenter();

            }
        }
    }
}
