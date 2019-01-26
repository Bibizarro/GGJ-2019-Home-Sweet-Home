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

    [SerializeField]private GameObject fingertip;
    
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();   
      talking = false; 
     anim = GetComponent<Animator>();
      
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
       movementInput = Vector2.right * Input.GetAxisRaw("Horizontal") + Vector2.up * Input.GetAxisRaw("Vertical") ;    
      }
      
      
    }


        void FixedUpdate()
     { 
       
         movementInput = movementInput*curSpeed;
         rb.velocity = movementInput;
     }

     void Animating()
     {
       print("xis" + (int)movementInput.x);
       print("yis" +(int)movementInput.y);
       anim.SetInteger("xMovement" , (int)movementInput.x);
       anim.SetInteger("yMovement" , (int)movementInput.y);
       if(movementInput.x > 0)
       {
         transform.eulerAngles = new Vector2(0,0);
         fingertip.transform.eulerAngles = new Vector3(0,0,90);
       }

        if(movementInput.x < 0)
       {
         transform.eulerAngles = new Vector2(0,180);
         fingertip.transform.eulerAngles = new Vector3(0,0,-90);
       }

       if(movementInput.y > 0)
       {
         fingertip.transform.eulerAngles = new Vector3(0,0,180);
       }

        if(movementInput.y < 0)
       {
        
         fingertip.transform.eulerAngles = new Vector3(0,0,0);
       }

     }
}