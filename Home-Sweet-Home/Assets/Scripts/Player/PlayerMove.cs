using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{

    private Vector2 movementInput;
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    
    public bool talking;
    
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();   
      talking = false; 
     
    
    }
    
    void Update()
    {
      if (talking)
      {
        speed = 0;
      }

      else
      {
       movementInput = Vector2.right * Input.GetAxis("Horizontal") + Vector2.up * Input.GetAxis("Vertical") ;    
      }
      
      
    }


        void FixedUpdate()
     { 
       
         movementInput = movementInput*speed;
         rb.velocity = movementInput;
     }
}