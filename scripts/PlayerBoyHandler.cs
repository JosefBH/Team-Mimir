using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerBoyHandler : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;

    
    public SpriteRenderer sr;
    public SpriteRenderer srb;

    public Rigidbody2D rb;
    public Animator anim;
    public float hp;
    public float atk;
    public RuntimeAnimatorController a; // elissa
    public RuntimeAnimatorController b; // nader
    public RuntimeAnimatorController c; // tawhida 
    public RuntimeAnimatorController d; // hanabal



    public void elissa()
    {

        sr.sprite = Resources.Load<Sprite>("Ellissa_0");
        anim.runtimeAnimatorController = a;
        panel1.SetActive(false);
        panel2.SetActive(true);
        srb.sprite = Resources.Load<Sprite>("Arc");
        hp = 70;
        atk = 15;

    }
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void hannibal()
    {
       
        sr.sprite = Resources.Load<Sprite>("Hanabal_0");
        anim.runtimeAnimatorController = d;
        panel1.SetActive(false);
        panel2.SetActive(true);
        srb.sprite = Resources.Load<Sprite>("Lance");
        hp = 120;
        atk = 8;

    }
    public void tawhida()
    {
        sr.sprite = Resources.Load<Sprite>("Twhida Bechikh_0");
        anim.runtimeAnimatorController = c;
        panel1.SetActive(false);
        panel2.SetActive(true);
        srb.sprite = Resources.Load<Sprite>("Poision");
        hp = 90;
        atk = 11;

    }
    public void nader()
    {
        sr.sprite = Resources.Load<Sprite>("ndr_0");
        anim.runtimeAnimatorController = b;
        panel1.SetActive(false);
        panel2.SetActive(true);
        srb.sprite = Resources.Load<Sprite>("Foudre");
        hp = 100;
        atk = 10;

    }

}
