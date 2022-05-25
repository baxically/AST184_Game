using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //Variables
    public float moveSpeed = 5f;
    //public int sceneCounter = 0;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if(obj.tag == "RoboDoor")
        {
            Debug.Log("Robo Room to Hallway");
            SceneManager.LoadScene("House");
        }
        else if(obj.tag == "Book")
        {
            Debug.Log("Found book");
        }
        else if(obj.tag == "HallwayDoor")
        {
            Debug.Log("Hallway to Robo Room");
            SceneManager.LoadScene("Roboticist Room");
        }
    }
}
