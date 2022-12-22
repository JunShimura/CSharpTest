using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

[RequireComponent(typeof(TextMeshProUGUI)) ]
public class ValueDisplay : MonoBehaviour
{
    private TextMeshProUGUI outText;
    private string displayed="";

    public string displayText
    {
        set{
            if (displayed != value)
            {
                outText.text = value;
            }
        }
        get
        {
            return displayed;
        }
    }
    private void Awake()
    {
        outText = GetComponent<TextMeshProUGUI>();
    }
}
