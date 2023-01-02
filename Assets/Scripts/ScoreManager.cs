using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int levelScore;
    public Text textObject;
    // Start is called before the first frame update
    void Start()
    {  
        textObject.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Add Score")]
    public void increaseScore()
    {
        levelScore++;
        textObject.text = "Score: " + levelScore;
    }
}
