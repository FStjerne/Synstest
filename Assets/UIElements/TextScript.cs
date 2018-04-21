using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class TextScript : MonoBehaviour {

    [SerializeField]
    UnityEngine.UI.Text text;

    [SerializeField]
    DialogueController controller;

    [SerializeField]
    [TextArea(3,10)]
    string line;

    [SerializeField]
    int[] indexChangers;

    int indexChange = 0;

    int index = 0;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void NextLine()
    {
        string[] limiters = new string[] { "\\r\\n" };
        string[] lines = line.Split(limiters, StringSplitOptions.RemoveEmptyEntries);
        if (index < lines.Length)
        {
            text.text = lines[index];
        }
        index++;
        if (indexChange < indexChangers.Length && index == indexChangers[indexChange])
        {
            controller.NextText();
            indexChange++;
        }
    }
}
