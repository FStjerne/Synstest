using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ManualController : MonoBehaviour
{
    public void OpenManual()
    {
        SceneManager.LoadScene("ManualScene", LoadSceneMode.Single);
        //SceneManager.UnloadScene("MenuScene");
    }
}
