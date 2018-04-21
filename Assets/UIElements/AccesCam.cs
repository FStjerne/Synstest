using UnityEngine;
using System.Collections;

public class AccesCam : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void GetCamcript()
    {
        Camera.main.GetComponent<CameraScript>().ChangePos();
    }
}
