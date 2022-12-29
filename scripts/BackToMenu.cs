using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Boy")
        {
            Debug.Log("boy collided with returntomenu");
            SceneManager.LoadScene(0);

        }
        if (col.gameObject.name == "Girl")
        {
            Debug.Log("girl collided with returntomenu");
            SceneManager.LoadScene(0);

        }
    }

}
