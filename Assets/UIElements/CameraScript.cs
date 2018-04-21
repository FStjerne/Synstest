using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    [SerializeField]
    float x;
    [SerializeField]
    float y;
    [SerializeField]
    float z;
    [SerializeField]
    float speed;
    [SerializeField]
    GameObject obj;

    float targetFOV = 60f;

    public GameObject Obj
    {
        get { return obj; }
        set { obj = value; }
    }
    public float TargetFOV
    {
        get { return targetFOV; }
        set { targetFOV = value; }
    }

    Vector3 targetVec;
    Vector3 originalVec;
    bool follow = true;
    int state;
    const int firstState = 0;
    const int secondState = 1;

	// Use this for initialization
	void Start ()
    {
        targetVec = Camera.main.transform.position;
        originalVec = Camera.main.transform.position;
        state = firstState;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, targetVec, speed * Time.deltaTime);
        if(obj != null)
        {
            Camera.main.transform.LookAt(obj.transform);
        }
        Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, targetFOV, speed * Time.deltaTime);
    }

    public void ChangePos()
    {
        if (state == firstState && obj != null)
        {
            targetVec = new Vector3(x, y, z);
            Camera.main.transform.LookAt(obj.transform);
            state = secondState;
        }
        else if(state == secondState)
        {
            targetVec = originalVec;
            Camera.main.transform.LookAt(obj.transform);
            state = firstState;
        }
    }
}
