using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    private Queue<string> sentences;
    private Queue<string> sentencesRed;
    public Text dialogText;
    public Text dialogRed;
    //  public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        sentencesRed = new Queue<string>();
    }

    public void StartDialog(Dialog dialog)
    {
       // animator.SetBool("isOpen", true);               
        sentences.Clear();
        foreach (string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }    
        DisplayNextSentence();
    }
    public void StartDialogRed(DialogRed dialogRed)
    {
        // animator.SetBool("isOpen", true);               
         sentencesRed.Clear();               
        foreach (string sentenceRed in dialogRed.sentencesRed)
         {
              sentencesRed.Enqueue(sentenceRed);
           }
          DisplayNextSentenceRed();       
    }
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialog();
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));       
    }
    public void DisplayNextSentenceRed()
    {
        if (sentencesRed.Count == 0)
        {
            EndDialog();
            return;
        }
        string sentenceRed = sentencesRed.Dequeue();
      //  StopAllCoroutines();
        StartCoroutine(TypeSentenceRed(sentenceRed));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogText.text += letter;
            yield return null;
        }
    }
    IEnumerator TypeSentenceRed(string sentenceRed)
    {
        dialogRed.text = "";
        foreach (char letter in sentenceRed.ToCharArray())
        {
            dialogRed.text += letter;
            yield return null;
        }
    }

    void EndDialog()
    {
     //   animator.SetBool("isOpen", false);
    }
}
