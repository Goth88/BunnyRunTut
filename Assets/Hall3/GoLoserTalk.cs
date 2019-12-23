using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoLoserTalk : MonoBehaviour
{
    public float speed = 3f;
    private Vector3 target;
    private bool moving;
    Animator animator;
    public GameObject thePlayer;
    public WalkHall3 _walk;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (Input.GetMouseButtonUp(0))
            {
                PlayerPrefs.SetString("location", "TalkLoser");
               _walk.GoTalkLoser();

            }           
        }
    }
}
