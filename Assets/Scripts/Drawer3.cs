using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Drawer3 : MonoBehaviour
{
    public float speed = 1.5f;
    public TextMeshProUGUI uiText;
    float playerX;
    public GameObject player;
    public AudioClip latch;
    private AudioSource source;        
    Animator animator;
    private Vector3 target;
    public walk _walk;

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
            PlayerPrefs.SetString("returnMain", "true");
            _walk.GoDrawer();

        }

    }
}
