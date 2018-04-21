using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Text : MonoBehaviour {

    
    [SerializeField]
    UnityEngine.UI.Text text;

    [SerializeField]
    int page;

    int counter = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void click()
    {        
        if(page == 1)
        {
            if(counter == 1)
            {
                text.text = "This is the Second Text";
            }
            else if(counter == 2)
            {
                text.text = "This is the Third Text";
            }
        }
        else if (page == 2)
        {
            text.text = "This is the Second Text of Page 2";
        }
        else if (page == 3)
        {
            text.text = "This is the Second Text of Page 3";
        }

        counter++;

    }
}
