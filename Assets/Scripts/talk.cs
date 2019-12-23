using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class talk : MonoBehaviour
{
    public TextMeshProUGUI uiText;
    

    // Start is called before the first frame update
    void Start()
    {
        uiText.text = PlayerPrefs.GetString("talk");
    }

    
}
