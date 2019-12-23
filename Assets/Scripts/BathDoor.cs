using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BathDoor : MonoBehaviour
{
    public float speed = 1.5f;
    public TextMeshProUGUI uiText;
    float playerX;
    public GameObject player;
    public AudioClip door;
    private AudioSource source;
    private int inBathroom = 0;
    public GameObject analysis;
    Animator animator;
    private Vector3 target;
    public walk _walk;
    private bool wentBath;


    void Awake()
    {
        source = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        uiText.text = "";
        target = transform.position;
    }

    private void OnMouseOver()
    {     
        if (Input.GetMouseButtonUp(0))
        {
            if (PlayerPrefs.GetString("inBathroom") == "true")
            {
                _walk.PlayerBack();
                PlayerPrefs.SetString("inBathroom", "false");
            }
            if (inBathroom == 2)
            {
                uiText.text = "You don't need a bathroom right now.";

            }

            if (inBathroom == 1)
            {
                PlayerPrefs.SetString("didBathroom", "true");
                uiText.text = "";
                _walk.PlayerBack();
                inBathroom = 2;
                source.PlayOneShot(door);
                wentBath = true;
               
            }
            if (inBathroom == 0)
            {
                if (!wentBath)
                {
                    _walk.GoBathroom();
                    inBathroom = 1;
                }
               
            }


        }

    }    
}
