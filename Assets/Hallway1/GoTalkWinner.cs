using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoTalkWinner : MonoBehaviour
{
    public float speed = 1.5f;
    private Vector3 target;   
    private bool moving;
    Animator animator;    
    public GameObject thePlayer;
    public WalkHall1 _walk;

    private void OnMouseOver()
    {        
        if (Input.GetMouseButtonUp(0))
        {
            if (Input.GetMouseButtonUp(0))
            {
                PlayerPrefs.SetString("returnMain", "true");
                _walk.GoTalkWin();

            }
            //    target.x = 0f;
            //      target.y = 0f;
            //     transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            //     animator.SetBool("moving", true);
            //  enterHall = true;
            //   SceneManager.LoadScene("TalkHall1");
        }
    }
}
