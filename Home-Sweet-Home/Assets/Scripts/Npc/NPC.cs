using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{   
    public DialogueThings dialogue;

    //private DialogueAdm dialogueAdm;
    //public string name;
    //

    //public string[] sentences;
    public Sprite mortoImg;
     public string[] dieSentences;
    public GameObject dialogueBox;
    //public GameObject pressButton;
    //Instanciou o Player aqui pra pegar a variavel booleana Talking
    private PlayerMove player;

    public SpriteRenderer spriteRenderer;
     

    
    void Start()
    {
    player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();

    }
    
    void Die()
    {
        
         dialogue.img = mortoImg;
          spriteRenderer.sprite = mortoImg;
         dialogue.sentences = dieSentences;
         return;

    }
  
    void OnTriggerStay2D (Collider2D coll)
    {
        print("coll");

          if (Input.GetKeyDown(KeyCode.Q) && coll.tag == "Player" )
        {
           Die();
           if (!dialogueBox.activeSelf)
            {
                  FindObjectOfType<DialogueAdm>().StartDialogue(dialogue);
             }

             else
             {
                 //Vai no DialogueManager e entra em NextSentence
                  FindObjectOfType<DialogueAdm>().NextSentence();

             }
        }
        #region InputPraStartarDialogo
        //se colidor com tag Player e apertar , entra
        if (Input.GetKeyDown(KeyCode.E) && coll.tag == "Player" )
        {
           
           if (!dialogueBox.activeSelf)
            {
                  FindObjectOfType<DialogueAdm>().StartDialogue(dialogue);
             }

             else
             {
                 //Vai no DialogueManager e entra em NextSentence
                  FindObjectOfType<DialogueAdm>().NextSentence();

             }
        }
        #endregion
    }
      
      //Pra quando sair a bola vrmelha não ficar ativa
     // void OnTriggerExit2D(Collider2D coll)
     // {
      //    if(coll.tag == "Player")
        //  {
         //     pressButton.SetActive(false);
         // }

     // }
}
