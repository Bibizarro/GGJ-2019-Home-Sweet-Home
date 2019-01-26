using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{

    private Vector2 movementInput;
    [HideInInspector]public float curSpeed;

    public float maxSpeed;
    private Rigidbody2D rb;
    public bool talking;
    private Animator anim;

    //changing idle

    private SpriteRenderer sp;
    [SerializeField] private Sprite sideways;
    [SerializeField] private Sprite behind;
    [SerializeField] private Sprite front;
    
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();   
      talking = false; 
     // anim = GetComponent<Animator>();
      sp = GetComponent<SpriteRenderer>();
      curSpeed = maxSpeed;
    }
    
    void Update()
    {
      Animating();
      if (talking)
      {
        curSpeed = 0;
      }

      else
      {
       movementInput = Vector2.right * Input.GetAxis("Horizontal") + Vector2.up * Input.GetAxis("Vertical") ;    
      }
      
      
    }


        void FixedUpdate()
     { 
       
         movementInput = movementInput*curSpeed;
         rb.velocity = movementInput;
     }

     void Animating()
     {
       //anim.SetFloat("SideWalking" , movementInput.x);
       if(movementInput.x > 0)
       {
         sp.sprite = sideways;
         transform.eulerAngles = new Vector2(0,0);
       }

        if(movementInput.x < 0)
       {
         sp.sprite = sideways;
         transform.eulerAngles = new Vector2(0,180);
       }

       if(movementInput.y > 0)
       {
         sp.sprite = front;
         transform.eulerAngles = new Vector2(180,0);
       }

        if(movementInput.y < 0)
       {
         sp.sprite = behind;
         transform.eulerAngles = new Vector2(-180,0);
       }

     }
}