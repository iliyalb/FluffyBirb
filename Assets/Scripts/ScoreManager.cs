using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int levelScore;
    public Text textObject;
    public GameObject gameOverObject;
    // Start is called before the first frame update
    void Start()
    {
        textObject.text = "Score: 0";
        gameOverObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameOver()
    {
        gameOverObject.SetActive(true);
    }

    [ContextMenu("Add Score")]
    public void increaseScore(int amount = 1)
    {
        levelScore += amount;
        textObject.text = "Score: " + levelScore;
    }
}
