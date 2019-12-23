using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoCopTalk : MonoBehaviour
{
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (Input.GetMouseButtonUp(0))
            {
                PlayerPrefs.SetString("location", "TalkCop");
                SceneManager.LoadScene("TalkCop");

            }
        }

    }
}
