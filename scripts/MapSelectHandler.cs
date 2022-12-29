using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MapSelectHandler : MonoBehaviour
{
    public GameObject panel;

    public GameObject a; // sfax 
    public GameObject b; // tunis 
    public GameObject c; // sousse
    public GameObject d; // tozeur



    // Start is called before the first frame update
    public void sfax()
    {
        panel.SetActive(false);
        // bg.sprite = Resources.Load<Sprite>("Battle sfax");
        a.SetActive(true);
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);





    }
    public void sousse()
    {
        panel.SetActive(false);
        // bg.sprite = Resources.Load<Sprite>("Battle sousse");
        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(true);
        d.SetActive(false);

    }
    public void tunis()
    {
        panel.SetActive(false);
        // bg.sprite = Resources.Load<Sprite>("Battle tunis");
        a.SetActive(false);
        b.SetActive(true);
        c.SetActive(false);
        d.SetActive(false);

    }
    public void tozeur()
    {
        panel.SetActive(false);
        // bg.sprite = Resources.Load<Sprite>("Battle tozeur");
        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(true);

    }


}
