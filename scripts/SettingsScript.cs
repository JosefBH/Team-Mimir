using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SettingsScript : MonoBehaviour
{
    public bool music = true;
    public Text onoff;
    [SerializeField] AudioSource musicc;

    public void musicChanger()
    {
        music = !music;

    }
    public void back()
    {
        SceneManager.LoadScene(0);
    }
    public void Update()
    {
        if (music)
        {
            onoff.text = "ON";
            musicc.Play();

        }
        else
        {
            onoff.text = "OFF";
            musicc.Stop();
        }

    }

}
