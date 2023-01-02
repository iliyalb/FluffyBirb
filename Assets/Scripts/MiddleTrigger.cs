using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleTrigger : MonoBehaviour
{
    public ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.FindWithTag("GameController").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreManager.increaseScore();
    }
}
