using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishScript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float wingStrenth;
    public logicScript logic; 
    public bool BirdAlive= true;
    public AudioSource sourceBounce;
    public AudioSource sourcepop;
    public Animator animator;


    
    // Start is called before the first frame update sfsf
   void Start()
    {
        
         logic=GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame,
    void Update()
    {
        //animator.SetBool("bounce", false);
        if (Input.GetKeyDown(KeyCode.Space) && BirdAlive) //Used for keyboard input
        //if(Input.touchCount > 0 && BirdAlive) 
        {
            sourceBounce.Play();
            animator.SetBool("bounce", true);
            myrigidbody.velocity = Vector2.down * wingStrenth;
            
               
        }
        else
        {
            animator.SetBool("bounce", false);
        }
        if (transform.position.y < -17 ||transform.position.y > 17)
        {
            logic.GameOver();
            BirdAlive=false;
        }
        // This is a tst file
         
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("alive",false);
        sourcepop.Play();
        logic.GameOver();
        BirdAlive=false;
        
     }

}
