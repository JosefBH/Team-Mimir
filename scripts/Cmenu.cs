using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cmenu : MonoBehaviour
{
    // menu : 0, room: 1
    public void playGame()
    {
        SceneManager.LoadScene(1);
    }
    public void goToSettings()
    {
        SceneManager.LoadScene(2);
    }
    public void quit()
    {
        Application.Quit();
    }
}
