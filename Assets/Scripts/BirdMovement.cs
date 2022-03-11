using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    private Rigidbody2D birdRb;
    private float force = 10f;
    private GameMnager gamemanager;
    void Start()
    {
        birdRb = GetComponent<Rigidbody2D>();
        gamemanager = GameObject.Find("GameManager").GetComponent<GameMnager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gamemanager.gameover==false)
        {
            birdRb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gamemanager.gameover = true;
            Destroy(gameObject);
        }
    }
}
