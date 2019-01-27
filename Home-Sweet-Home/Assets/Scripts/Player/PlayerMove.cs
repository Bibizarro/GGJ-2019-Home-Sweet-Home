using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMove : MonoBehaviour
{
    private Scene curScene;
    private Vector2 movementInput;
    [HideInInspector]public float curSpeed;

    private GameObject shooterPlayer;

    public float maxSpeed;
    private Rigidbody2D rb;
    public bool talking;
    private Animator anim;


    [SerializeField]private GameObject fingertip;
    
    private void Awake()
     {
       rb = GetComponent<Rigidbody2D>(); 
      anim = GetComponent<Animator>();
    }
    void Start()
    {
      GettingPos();

      CheckingGun();
       
      talking = false; 
      
      curSpeed = maxSpeed;

      shooterPlayer =  Singleton.GetInstance.shooter;
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

     void CheckingGun()
     {
       if(PlayerPrefs.GetInt("GotGun")==1)
       {
         Instantiate(shooterPlayer , transform.position , Quaternion.identity);
         Destroy(gameObject);
       }
     }

     void GettingPos()
     {
       #region  OneWayRoom

       curScene = SceneManager.GetActiveScene();
       if(curScene.name == "Kitchen" || curScene.name == "DadRoom" ||curScene.name == "BrotherRoom" || curScene.name == "KiddoRoom")
       {
       switch(curScene.name)
       {
         
         case "Kitchen":
         transform.position = Singleton.GetInstance.kitchenPlayerPos.position;
         break;

         case "DadRoom":
         transform.position = Singleton.GetInstance.dadRoomPlayerPos.position;
         break;

         case "KiddoRoom":
         transform.position = Singleton.GetInstance.kiddoRoomPlayerPos.position;
         break;

         case "BrotherRoom":
         transform.position = Singleton.GetInstance.brotherRoomPlayerPos.position;
         break;

       }
       }
     #endregion OneWayRoom

      else
      {
        string previousScene = PlayerPrefs.GetString("previousScene");
        print(previousScene);

          switch(previousScene)
        {
          case "DadRoom":
          transform.position = Singleton.GetInstance.leaveDadRoomPlayerPos.position;
          break;

          case "BrotherRoom":
          transform.position = Singleton.GetInstance.leaveBrotherRoomPlayerPos.position;
          break;

          case "Kitchen":
          transform.position = Singleton.GetInstance.leaveKitchenPlayerPos.position;
          break;

          case "Menu":
          transform.position = Singleton.GetInstance.justStartedPos.position;
          break;

          case "Upstairs":
          transform.position = Singleton.GetInstance.GotDownstairsPlayerPos.position;
          break;

          case "Nha":
          transform.position = Singleton.GetInstance.gotUpstairsPlayerPos.position;
          break;
       }

     }

     }
     void Animating()
     {
       
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