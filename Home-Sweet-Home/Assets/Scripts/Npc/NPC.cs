using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{   
    //public DialogueThings dialogue;

    private DialogueAdm dialogueAdm;
    public string name;
    public Sprite img;

    public string[] sentences;
    public GameObject dialogueBox;
    public GameObject pressButton;
    //Instanciou o Player aqui pra pegar a variavel booleana Talking
    private PlayerMove player;
     

    
    void Start()
    {
    player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();

    }
    
  
    void OnTriggerStay2D (Collider2D coll)
    {
        print("coll");
    
        #region BolaVermelha
        //Bolinha vermelha ligada se o player não estiver falando
        if(!player.talking)
        {
        pressButton.SetActive(true);
        }
        //Bolinha vermelha desligada se ele estiver falando
        if(player.talking)
        {
        pressButton.SetActive(false);
        }
        #endregion 

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
      
      //Pra quando sair a bola vrmelha não ficar ativa
      void OnTriggerExit2D(Collider2D coll)
      {
          if(coll.tag == "Player")
          {
              pressButton.SetActive(false);
          }

      }
}
