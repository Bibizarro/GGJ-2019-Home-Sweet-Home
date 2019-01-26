using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueAdm : MonoBehaviour
{
    public NPC npc;
    
    public Text nameTxt;
    public Text dialogueTxt;
    public GameObject dialogueBox;
    //Fila com as setenças 
    public Queue<string> sentences;
    private PlayerMove player;

    void Start()
    {
       sentences = new Queue<string>();
       player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();   
    }
     
     public void StartDialogue()
    {   
        //Ativa caixa de dialogo
        dialogueBox.SetActive(true);
        //playerTalkin fica true
        player.talking = true;
        //Iguala
        nameTxt.text = npc.name;
        
          
        sentences.Clear();

        foreach (string sentence in npc.sentences)

            {
            sentences.Enqueue(sentence);
             }
             
        NextSentence();

	}
    
    public void NextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(LetterByLeter(sentence));
    }

    IEnumerator LetterByLeter(string sentence)
    {
         dialogueTxt.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueTxt.text += letter;
            yield return null;
        }

    }

    void EndDialogue()
    {  
        print("Anda porra");
        player.curSpeed = player.maxSpeed;
        dialogueBox.SetActive(false);
        player.talking = false;
        
    }
}


