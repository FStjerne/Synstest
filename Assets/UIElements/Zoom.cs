using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Zoom : MonoBehaviour {

    [SerializeField]
    Button button;

    [SerializeField]
    CameraScript camScript;

    [SerializeField]
    ParticleSystem ps;

    [SerializeField]
    float zoomFOV;

    float standardFOV = 60f;

    float targetFOV = 0f;


    float speed = 2f;

	// Use this for initialization
	void Start () {
        button.gameObject.SetActive(false);
        ps.gameObject.SetActive(true);
        targetFOV = standardFOV;
	}
	
	// Update is called once per frame
	void Update () {
        //Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, targetFOV, speed * Time.deltaTime);
	}

    void OnMouseDown()
    {
        Camera.main.transform.LookAt(transform);

        //targetFOV = zoomFOV;
        camScript.TargetFOV = zoomFOV;

        //Camera.main.GetComponent<CameraScript>().TargetFOV = zoomFOV;

        button.gameObject.SetActive(true);
        ps.gameObject.SetActive(false);

        //camScript.Obj = this.gameObject;
        Camera.main.GetComponent<CameraScript>().Obj = gameObject;
    }

    public void BackOut()
    {
        Camera.main.transform.LookAt(transform);

        //targetFOV = standardFOV;
        camScript.TargetFOV = standardFOV;
        //Camera.main.GetComponent<CameraScript>().TargetFOV = standardFOV;

        button.gameObject.SetActive(false);
        ps.gameObject.SetActive(true);
    }
}
