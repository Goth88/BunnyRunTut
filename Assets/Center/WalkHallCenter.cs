using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WalkHallCenter : MonoBehaviour
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
    public TextMeshProUGUI uiText;
    private bool goingCenter;


    void Start()
    {
        //  playDoor = PlayerPrefs.GetString("doorSound");
        target = transform.position;
        animator = GetComponent<Animator>();
        playerSpriteImage = (SpriteRenderer)GetComponent(typeof(SpriteRenderer));
        thePlayer = this.gameObject;
        source = GetComponent<AudioSource>();
        location = PlayerPrefs.GetString("location");
        
        if (location == "Center")
        {
            Vector3 temp2 = transform.position; // copy to an auxiliary variable...
            temp2.y = -1f; // modify the component you want in the variable...
            temp2.x = 5f;
            transform.position = temp2; // a
        }      
        PlayerPrefs.SetString("location", "HallCenter");
        // DoorSound();
    }
    
    void Update()
    {
        posX = transform.position.x;
        posY = transform.position.y;       

            if (goingLocked && posX == 0f)
          {
              uiText.text = "It's locked";
         //  source.PlayOneShot(locked);            
           }
        if (goingCenter && posX == 4f)
        {
            SceneManager.LoadScene("Center");
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
    public void LockedDoor()
    {       
        goingLocked = true;
        target.x = 0f;
        target.y = -.2f;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        animator.SetBool("moving", true);
    }
    public void GoCenter()
    {
        goingCenter = true;
        target.x = 4f;
        target.y = -.5f;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        animator.SetBool("moving", true);
    }

}


