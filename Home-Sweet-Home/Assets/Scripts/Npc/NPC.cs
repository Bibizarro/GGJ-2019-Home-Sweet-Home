using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{   
    

    private DialogueAdm dialogueAdm;
    public Sprite img;

    public string[] sentences;
    public GameObject dialogueBox;
   
    private PlayerMove player;
     

    
    void Start()
    {
    player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();

    }
    
  
    void OnTriggerStay2D (Collider2D coll)
    {
        print("coll");
    
      

        #region InputPraStartarDialogo
        //se colidor com tag Player e apertar , entra
        if (Input.GetKeyDown(KeyCode.E) && coll.tag == "Player" )
        {
           
           if (!dialogueBox.activeSelf)
            {
                  FindObjectOfType<DialogueAdm>().StartDialogue();
             }

             else
             {
                 //Vai no DialogueManager e entra em NextSentence
                  FindObjectOfType<DialogueAdm>().NextSentence();

             }
        }
        #endregion
    }
      
      
}
