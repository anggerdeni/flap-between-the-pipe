using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float speed = 1.0f;
    public float deadzone = -23.0f;
    public bool isGameOver = false;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            this.transform.position = this.transform.position + (Vector3.left * speed) * Time.deltaTime;

            if (this.transform.position.x < this.deadzone)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
