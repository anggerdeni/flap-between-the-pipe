using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public float flapStrength = 4.5f;
    public LogicScript logicScript;
    
    private Rigidbody2D rigidBody;
    private bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive && Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicScript.gameOver();
        isAlive = false;

        Destroy(rigidBody);
    }
}
