using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class VisusController : MonoBehaviour
{
    public void StartVisus()
    {
        SceneManager.LoadScene("VisusScene", LoadSceneMode.Single);
       // SceneManager.UnloadScene("Page 3");
    }
}
