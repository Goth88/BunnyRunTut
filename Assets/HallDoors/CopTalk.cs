using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CopTalk : MonoBehaviour
{
    public Dialog dialog;
    public DialogRed dialogRed;
    public Text blue;
    public Text red;
    private int step = 0;

    public void Start()
    {
        PlayerPrefs.SetString("doorSound", "false");
    }
    private void OnMouseOver()
    {        
        if (Input.GetMouseButtonUp(0))
        {


            if (step == 6)
            {
                SceneManager.LoadScene("HallDoors");

            }

            else if (step == 5)
            {
                blue.text = "";
                FindObjectOfType<DialogManager>().DisplayNextSentenceRed();
            }

            else if (step == 4)
            {
                red.text = "";
                FindObjectOfType<DialogManager>().DisplayNextSentence();
            }

            else if (step == 3)
            {
                blue.text = "";
                FindObjectOfType<DialogManager>().DisplayNextSentenceRed();
            }


            else if (step == 2)
            {
                red.text = "";
                //  FindObjectOfType<DialogManager>().DisplayNextSentenceRed();
                FindObjectOfType<DialogManager>().DisplayNextSentence();
            }

            else if (step == 1)
            {
                blue.text = "";
                FindObjectOfType<DialogManager>().StartDialogRed(dialogRed);

            }

            else if (step == 0)
            {
                FindObjectOfType<DialogManager>().StartDialog(dialog);
            }

            step++;

        }

    }
}

