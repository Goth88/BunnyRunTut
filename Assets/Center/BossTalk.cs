using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BossTalk : MonoBehaviour
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


            if (step == 14)
            {
                SceneManager.LoadScene("Center");

            }
            else if (step == 13)
            {
                blue.text = "";
                FindObjectOfType<DialogManager>().DisplayNextSentenceRed();
            }
            else if (step == 12)
            {
                red.text = "";
                FindObjectOfType<DialogManager>().DisplayNextSentence();
            }
            else if (step == 11)
            {
                blue.text = "";
                FindObjectOfType<DialogManager>().DisplayNextSentenceRed();
            }
            else if (step == 10)
            {
                red.text = "";
                FindObjectOfType<DialogManager>().DisplayNextSentence();
            }
            else if (step == 9)
            {
                blue.text = "";
                FindObjectOfType<DialogManager>().DisplayNextSentenceRed();
            }
            else if (step == 8)
            {
                red.text = "";
                FindObjectOfType<DialogManager>().DisplayNextSentence();
            }
            else if (step == 7)
            {
                blue.text = "";
                FindObjectOfType<DialogManager>().DisplayNextSentenceRed();
            }
            else if (step == 6)
            {
                red.text = "";
                FindObjectOfType<DialogManager>().DisplayNextSentence();
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

