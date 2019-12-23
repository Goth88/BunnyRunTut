using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WalkCenter : MonoBehaviour
{
    private float speed = 3f;
    private Vector3 target;
    private float theY = 340f;
    private float theX = 250f;
    private bool moving;
    Animator animator;
    private SpriteRenderer playerSpriteImage;
    public static float posX;
    public static float posY;
    public GameObject thePlayer;
    //  public TextMeshProUGUI uiText;
    public AudioClip doorsound;
    public AudioClip locked;
    private AudioSource source;
    private string playDoor;
    private bool goingLocked;
    //  public TextMeshProUGUI uiText;
    private string location;   
    private bool goingCenter;
    private bool goingLimit;
    private bool goingBack;


    void Start()
    {
        //  playDoor = PlayerPrefs.GetString("doorSound");
        target = transform.position;
        animator = GetComponent<Animator>();
        playerSpriteImage = (SpriteRenderer)GetComponent(typeof(SpriteRenderer));
        thePlayer = this.gameObject;
        source = GetComponent<AudioSource>();
        location = PlayerPrefs.GetString("location");
        //  print(location);
        // if (location == "TalkLoser")
        //  {
        //      Vector3 temp = transform.position; // copy to an auxiliary variable...
        //       temp.y = -2f; // modify the component you want in the variable...
        //      temp.x = 0f;
        //      transform.position = temp; // a
        //  }
        //   PlayerPrefs.SetString("location", "Hall3");
        // DoorSound();
    }

    void Update()
    {
        posX = transform.position.x;
        posY = transform.position.y;

        if (goingLimit && posX == 7f)
        {
            SceneManager.LoadScene("TalkLimits");
        }
        if (goingCenter && posX == -1f)
        {
            SceneManager.LoadScene("TalkBoss");
        }

        if (goingBack && posX == -6f)
        {
            target = transform.position;
            SceneManager.LoadScene("HallCenter");
        }

        //  print(theX);

        if (Input.GetMouseButtonDown(0))
        {
            playDoor = "true";
            //     PlayerPrefs.SetString("doorSound", "true");
            theY = Input.mousePosition.y;
            if (theY < 300f)
            {
                theY = 300f;
            }



            theX = Input.mousePosition.x;
            Vector3 mouseposition = Input.mousePosition;
            mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);
            float direction = (mouseposition.x - transform.position.x);
            // print(direction);
            if (direction > 0)
            {
                playerSpriteImage.flipX = true;

                //  print("right");
            }
            else
            {
                playerSpriteImage.flipX = false;
                //    print("left");
            }
            if (theY < 400f)
            {
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                animator.SetBool("moving", true);
            }

            target.z = transform.position.z;

        }
        if (transform.position.y > -25 && target.y > -25)
        {
            if (playDoor == "true")
            {
                transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            }
        }
        if (transform.position == target)
        {
            animator.SetBool("moving", false);
        }



    }
    public void OffLimits()
    {
        goingLimit = true;
        target.x = 7f;
        target.y = -.2f;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        animator.SetBool("moving", true);
    }
    public void GoTalk()
    {
        goingCenter = true;
        target.x = -1f;
        target.y = -.2f;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        animator.SetBool("moving", true);
    }
    public void GoHall()
    {
        goingBack = true;
        target.x = -6f;
        target.y = -.2f;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        animator.SetBool("moving", true);
    }
}
