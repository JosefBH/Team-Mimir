using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChampSelect : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Boy")
        {

            Debug.Log("boy collided with champselect ");
            SceneManager.LoadScene(3);
        }
        if (col.gameObject.name == "Girl")
        {
            Debug.Log("girl collided with champselect");
            SceneManager.LoadScene(3);
        }
    }

}
