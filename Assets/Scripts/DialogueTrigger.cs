using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject book, board, desk, shelf, p1, p2, d1;

    /*public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }*/

    void OnTriggerEnter2D(Collider2D obj)
    {
        book = GameObject.Find("Book");
        board = GameObject.Find("Board");
        desk = GameObject.Find("Desk");
        p1 = GameObject.Find("Painting 1");
        p2 = GameObject.Find("Painting 2");
        d1 = GameObject.Find("Drawings");

        if (book)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        else if (board)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        else if (desk)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        else if (shelf)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        else if (p1)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        else if (p2)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        else if (d1)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
    }
}
