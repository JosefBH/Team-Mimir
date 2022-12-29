using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class  PlayerGirlHandler : MonoBehaviour
{
    public GameObject panel2;

    public SpriteRenderer sr;
    public SpriteRenderer srb; 
    public Rigidbody2D rb;
    public Animator anim;
    public RuntimeAnimatorController a; // elissa
    public RuntimeAnimatorController b; // nader
    public RuntimeAnimatorController c; // tawhida 
    public RuntimeAnimatorController d; // hanabal



    public void glissa()
    {

        sr.sprite = Resources.Load<Sprite>("Ellissa_0");
        anim.runtimeAnimatorController = a;
        panel2.SetActive(false);
        SceneManager.LoadScene(4);
        srb.sprite = Resources.Load<Sprite>("Arc");

    }
    public void gannibal()
    {

        sr.sprite = Resources.Load<Sprite>("Hanabal_0");
        anim.runtimeAnimatorController = d;
        panel2.SetActive(false);
        SceneManager.LoadScene(4);
        srb.sprite = Resources.Load<Sprite>("Lance");


    }
    public void gawhida()
    {
        sr.sprite = Resources.Load<Sprite>("Twhida Bechikh_0");
        anim.runtimeAnimatorController = c;
        panel2.SetActive(false);
        SceneManager.LoadScene(4);
        srb.sprite = Resources.Load<Sprite>("Poision");


    }
    public void gader()
    {
        sr.sprite = Resources.Load<Sprite>("ndr_0");
        anim.runtimeAnimatorController = b;
        panel2.SetActive(false);
        SceneManager.LoadScene(4);
        srb.sprite = Resources.Load<Sprite>("Foudre");


    }

}
