using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birb : MonoBehaviour
{
    public bool gameOverState = false;
    public float jumpVelocity;
    public Rigidbody2D rigidbodyObject;
    public ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        rigidbodyObject.constraints = RigidbodyConstraints2D.None;
        scoreManager = GameObject.FindWithTag("GameController").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !gameOverState)
        {
            rigidbodyObject.velocity = Vector2.up * jumpVelocity;
        }
    }

    void EndGame()
    {
        scoreManager.GameOver();
        gameOverState = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        EndGame();
    }

    private void OnBecameInvisible()
    {
        rigidbodyObject.constraints = RigidbodyConstraints2D.FreezeAll;
        EndGame();
    }
}
