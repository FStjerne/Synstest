using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DialogueController : MonoBehaviour {

    [SerializeField]
    List<GameObject> objects = new List<GameObject>();

    [SerializeField]
    int[] indexers;

    int index = 0;

	// Use this for initialization
	void Start () {
        foreach (GameObject obj in objects)
        {
            obj.gameObject.SetActive(false);
        }
        objects[indexers[index]].SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void NextText()
    {
        objects[indexers[index]].SetActive(false);
        index++;
        objects[indexers[index]].SetActive(true);
    }
}
