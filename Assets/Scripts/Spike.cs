using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public static float scrollSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.right * scrollSpeed) * Time.deltaTime;
        scrollSpeed += Time.deltaTime;
    }
}
