using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEvent : MonoBehaviour
{
    public GameObject door, book;

    void OnTriggerEnter2D(Collider2D obj)
    {
        door = GameObject.Find("Door");
        book = GameObject.Find("Book");

        if(door)
        {
            Debug.Log("Entered if");
            SceneManager.LoadScene("House");
        }
        else if(book)
        {
            Debug.Log("Found book");
        }
    }
}
