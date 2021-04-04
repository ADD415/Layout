using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Spawner spawner;
    public UIManager manager;
    public sceenTransitions sceneTransitions;

    public int playerSpeed = 10;
    private bool facingRight = true;
    public int playerJumpPower = 1250;
    private float moveX;

    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        //Controls, animations, player direction, physics 

        //Controls
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }


        //Player Direction
        if (moveX > 0.0f && facingRight == false)
        {
            FlipPlayer();
        }

        else if (moveX < 0.0f && facingRight == true)
        {
            FlipPlayer();
        }

        //Physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump()
    {
        //Jumping Code

        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
    }

    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }



    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("Death"))
        {
            Destroy(gameObject);
            manager.checkLives();
            manager.lifeLost();

        }
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.name)
        {
            case "Transition":
                sceneTransitions.Room();
                break;

            case "Transition Back":
                sceneTransitions.Room2();
                break;

            case "Transition Three":
                sceneTransitions.Room3();
                break;

            case "Transition Four":
                sceneTransitions.Room4();
                break;

            case "Transition Five":
                sceneTransitions.Room5();
                break;

            case "Transition Six":
                sceneTransitions.Room6();
                break;

            case "Transition Seven":
                sceneTransitions.Room7();
                break;

            case "Transition Eight":
                sceneTransitions.Room8();
                break;

            case "Spine":
                Destroy(gameObject);
                Destroy(other.gameObject);
                spawner.spawnPlayerSpine();
                spawner.value++;

                break;

            case "Ribs":
                Destroy(gameObject);
                Destroy(other.gameObject);
                spawner.spawnPlayerRibs();
                spawner.value++;
                break;
        }
        }
}
