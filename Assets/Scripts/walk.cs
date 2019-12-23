using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class walk : MonoBehaviour
{
    public float speed = 1.5f;
    private Vector3 target;
    private float theY = 340f;
    private float theX;
    private bool moving;
    Animator animator;
    private SpriteRenderer playerSpriteImage;
    public static float posX;
    public static float posY;
    public GameObject thePlayer;
    public TextMeshProUGUI uiText;
    private bool enterBathroom;
    public AudioClip doorsound;
    public AudioClip locked;
    private AudioSource source;
    private bool openDrawer;
    private bool enterHall;
    private string heardClick;
    private string location;

    // Start is called before the first frame update

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        location = PlayerPrefs.GetString("location");
        if(location == "Hallway1")
        {            
            Vector3 temp = transform.position; // copy to an auxiliary variable...
            temp.y = -3.7f; // modify the component you want in the variable...
            temp.x = -4.7f;
            transform.position = temp; // and save  
            source.PlayOneShot(doorsound);
            PlayerPrefs.SetString("location", "Main");
        }
        target = transform.position;     
        playerSpriteImage = (SpriteRenderer)GetComponent(typeof(SpriteRenderer));
        thePlayer = this.gameObject;
        
    }
    public void DoorSound()
    {
        source.PlayOneShot(doorsound);
    }

    // Update is called once per frame
    void Update()
    {
        heardClick = PlayerPrefs.GetString("heardClick");
       // print(heardClick);
        posX = transform.position.x;
        posY = transform.position.y;
        //  print(theX);
        if (Input.GetMouseButtonDown(0))
        {            
            theY = Input.mousePosition.y;
            theX = Input.mousePosition.x;
            Vector3 mouseposition = Input.mousePosition;
            mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);
            float direction = (mouseposition.x - transform.position.x);
           // print(direction);
           if(direction > 0)
            {
               playerSpriteImage.flipX = true;
              
              //  print("right");
            }
           else
            {
                playerSpriteImage.flipX = false;
            //    print("left");
            }
            if (theY < 382f && theX > 950f)
            {
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition);              
                animator.SetBool("moving", true);
            }

            if (theY < 300f && theX > 600f)
            {
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                animator.SetBool("moving", true);
            }

            if (theY < 200f && theX > 500f)
            {
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                animator.SetBool("moving", true);
            }

                if (theY < 150f && theX > 475f)
            {
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                animator.SetBool("moving", true);
            }        
            target.z = transform.position.z;
           
        }
        if (transform.position.y > -25 && target.y > -25)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
            if(transform.position == target)
        {
            animator.SetBool("moving", false);            
        }


            if(enterBathroom && transform.position.x < -1 && transform.position.y > -2.3f)
         {
            enterBathroom = false;
            animator.SetBool("moving", false);
            PlayerPrefs.SetString("returnMain", "true");           
            Vector3 temp = transform.position; // copy to an auxiliary variable...
            temp.y = -30f; // modify the component you want in the variable...
            transform.position = temp; // and save          
            uiText.text = "You go in the bathroom.";
            PlayerPrefs.SetString("inBathroom", "true");
        }
        if (openDrawer && transform.position.x < 2.1f && transform.position.y > -.6f)
        {
            openDrawer = false;
            animator.SetBool("moving", false);
            PlayerPrefs.SetString("returnMain", "true");
            SceneManager.LoadScene("Vitamins");
        }
        if (enterHall && transform.position.x < -4.3f && transform.position.y < -3.5f)
        {
            
          //  print(heardClick);
            enterHall = false;
            animator.SetBool("moving", false);
            PlayerPrefs.SetString("returnMain", "true");        
           if (heardClick == "true")
            {
                SceneManager.LoadScene("Hallway1");
            }
            else
            {
                uiText.text = "It's locked";
                source.PlayOneShot(locked);
            }
        }

    }
    public void GoBathroom()
    {
       // print(transform.position.x);
        target.x = -1.1f;
        target.y = -2f;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        animator.SetBool("moving", true);
        enterBathroom = true;        
    }
  
    public void PlayerBack()
    {
        Vector3 temp = transform.position; // copy to an auxiliary variable...
        target.x = 0f;
        temp.y = -2f; // modify the component you want in the variable...
        transform.position = temp; // and save  
        target = temp;
    }

    public void GoDrawer()
    {
        // print(transform.position.x);
        target.x = 2f;
        target.y = -.5f;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        animator.SetBool("moving", true);
        openDrawer = true;
        
    }

    public void GoHall()
    {
        // print(transform.position.x);
        target.x = -4.5f;
        target.y = -3.7f;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        animator.SetBool("moving", true);
        enterHall = true;

    }
}

