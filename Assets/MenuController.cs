using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuController : MonoBehaviour
{
	public void StartMenu()
    {
        SceneManager.LoadScene("MenuScene", LoadSceneMode.Single);
       // SceneManager.UnloadScene("ManualScene");
    }
}
