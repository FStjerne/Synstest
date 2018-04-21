using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class ArrowButtonLeft : MonoBehaviour {

    [SerializeField]
    int page;
    
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Lel
    public void onClick()
    {
        SceneManager.LoadSceneAsync("Page " + (page - 1), LoadSceneMode.Single);
       // SceneManager.UnloadScene("Page " + page);
    }
}
