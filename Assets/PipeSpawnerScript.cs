using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 4.5f;
    public float heightOffset = 3.0f;

    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();   
    }

    // Update is called once per frame
    void Update()
    {
        this.timer += Time.deltaTime;

        if (timer > spawnRate)
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float min = transform.position.y - heightOffset;
        float max = transform.position.y + heightOffset;
        Vector3 position = new Vector3(transform.position.x, Random.Range(min, max), transform.position.z);

        Debug.Log(position.x);

        Instantiate(pipe, position, transform.rotation);
    }
}
