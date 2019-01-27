using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public GameObject player;
  public GameObject fingertip;
  public Weapon weapon;

  public GameObject shooter;

  [Header("Position Shit")]
  public Transform kitchenPlayerPos;

  public Transform gotUpstairsPlayerPos;

 public Transform leaveDadRoomPlayerPos;

 public Transform leaveBrotherRoomPlayerPos;
  
   public Transform GotDownstairsPlayerPos;

    public Transform leaveKitchenPlayerPos;

    public Transform dadRoomPlayerPos;

    public Transform brotherRoomPlayerPos;
     public Transform kiddoRoomPlayerPos;

     public Transform justStartedPos;

     public GameManager gm;


     [Header("NPC")]

     public NPC dad;
  private static Singleton instance;

  private void Awake() 
  {
      gm = GameObject.FindObjectOfType<GameManager>();
  }


    
    
   public static Singleton GetInstance
   {
       get
       {
            if(instance == null)
            {
            instance = GameObject.FindObjectOfType<Singleton>();
            }
            return instance;
        }


   }
}
