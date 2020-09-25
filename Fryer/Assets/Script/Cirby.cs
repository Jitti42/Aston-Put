using System.Collections;
using UnityEngine;
using System.Collections.Generic;


public class Cirby : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rigidbody2D;
    
    public Vector2 velocity;
    public UIManager uiManager;
    private bool died;
    //public void click;
    void Start()
    {
        
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D> ();
        died = false; 
    }

    /*void OnClickStart()
    {

    }*/

    void OnTriggerEnter2D (Collider2D c)
    {
        if (died)
            return;

        uiManager.IncreaseScore();
        
    }

    void Update()
    {
        
        bool mouseDown = Input.GetMouseButtonDown(0);

        if (mouseDown && false == died)
        {
            rigidbody2D.velocity = velocity;
        }
        
        
        
    }

   

    void OnCollisionEnter2D (Collision2D c)
    {
        died = true;
        Invoke ("Ondied", 0);
    }

    void Ondied()
    {
       
        uiManager.ShowResult();
    }
}
