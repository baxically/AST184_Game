using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject book, board, desk;

    /*public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }*/

    void OnTriggerEnter2D(Collider2D obj)
    {
        book = GameObject.Find("Book");
        board = GameObject.Find("Board");
        desk = GameObject.Find("Desk");

        if (book)
        {
            Debug.Log("Found book");
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        else if (board)
        {
            Debug.Log("Found board");
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        else if (desk)
        {
            Debug.Log("Found desk");
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
    }
}
