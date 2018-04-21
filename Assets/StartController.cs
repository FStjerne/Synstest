using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Page 1", LoadSceneMode.Single);
        //SceneManager.UnloadScene("MenuScene"); SceneManager.UnloadScene("ManualScene");
    }
}
