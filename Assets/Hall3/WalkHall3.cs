using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WalkHall3 : MonoBehaviour
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
    private bool goingCop;
    private string playDoor;
    private bool goingLocked;
  //  public TextMeshProUGUI uiText;
    private string location;


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
        if (location == "TalkLoser")
        {
            Vector3 temp = transform.position; // copy to an auxiliary variable...
            temp.y = -2f; // modify the component you want in the variable...
            temp.x = 0f;
            transform.position = temp; // a
        }
        if (location == "HallCenter")
        {
            Vector3 temp = transform.position; // copy to an auxiliary variable...
            temp.y = -2f; // modify the component you want in the variable...
            temp.x = 6f;
            transform.position = temp; // a
        }
        PlayerPrefs.SetString("location", "Hall3");
        // DoorSound();
    }
  //  public void DoorSound()
   // {
   //     if (playDoor == "true")
  //      {
   //         source.PlayOneShot(doorsound);
  //      }
  //      else if (playDoor == "false")
  //      {
  //          Vector3 temp = transform.position; // copy to an auxiliary variable...
  //          temp.y = -1.5f; ////ify the component you want in the variable...
  //          temp.x = 0f;
  //          transform.position = temp; // and save
  //      }
 //   }

    // Update is called once per frame
    void Update()
    {
        posX = transform.position.x;
        posY = transform.position.y;
        if (goingCop && posX == 0f)
        {
            SceneManager.LoadScene("TalkLoser");
        }

    //    if (goingLocked && posX == -3f)
      //  {
      //      uiText.text = "It's locked";
            //   source.PlayOneShot(locked);            
    //    }
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
    public void GoTalkLoser()
    {
        goingCop = true;
        target.x = 0f;
        target.y = -2f;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        animator.SetBool("moving", true);
    }
//    public void GoLocked()
 //   {
//        goingLocked = true;
 //       target.x = -3f;
 //       target.y = -.1f;
// //       transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
//        animator.SetBool("moving", true);
 //   }

}

