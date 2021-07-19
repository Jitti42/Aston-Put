using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator animator;
    private Rigidbody2D rigidbody2D;

    private AudioSource audioSource;
    public AudioClip coin;

    //public GameObject res;

    public scoremanage Scores;

    public float speed;
    public float left;

    public UIManager uiManager;


    //public void click;
    void Start()
    {

        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        uiManager.start();
    }


    void OnTriggerEnter2D(Collider2D c)
    {

        audioSource.PlayOneShot(coin);

        uiManager.plusScore();

    }

    void Update()
    {
        //Vector2 position = transform.position;
        //bool mouseDown = Input.GetMouseButtonDown(0);
        //n -= Time.deltaTime;

        /*if (position.x < left)
        {
            //rigidbody2D.velocity = velocity;

            Destroy(gameObject);
            return;
        }
        transform.Translate(-speed * Time.deltaTime, 0, 0);*/
       


    }



    



    
    
}
