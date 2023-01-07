using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassedPipeScript : MonoBehaviour
{
    public LogicScript logicScript;

    const int DEFAULT_SCORE_TO_ADD = 1;

    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logicScript.addScore(DEFAULT_SCORE_TO_ADD);
        }
    }
}
