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
    private AudioSource audioSource;
    private AudioSource Backgroundsound;
    public AudioClip coin;

    public AudioClip die;
    void Start()
    {
        
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D> ();
        audioSource = GetComponent <AudioSource>();
        
        died = false; 
    }

   

    void OnTriggerEnter2D (Collider2D c)
    {
        if (died)
            return;
        audioSource.PlayOneShot(coin);
        
        uiManager.IncreaseScore();
        
    }

    void Update()
    {

        bool keyDown = Input.GetKeyDown(KeyCode.Space);
       
        bool mouseDown = Input.GetMouseButtonDown(0);

        if (keyDown || mouseDown && false == died)
        {
            rigidbody2D.velocity = velocity;
            animator.SetTrigger("IsFlap");
            
        }
        
        
        
    }

   

    public void OnCollisionEnter2D (Collision2D c)
    {
        died = true;
        audioSource.PlayOneShot(die);
        Invoke ("Ondied", 0);
        
    }

    

    void Ondied()
    {
       
        uiManager.ShowResult();
    }
    
    
    
}
