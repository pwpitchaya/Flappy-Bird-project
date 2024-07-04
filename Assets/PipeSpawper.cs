using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawper : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOfSet = 10;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate){
            timer += Time.deltaTime;
        }
        else
        {
           spawnPipe();
           timer = 0;
        }
    }
    
    void spawnPipe()
    {
        float minY = transform.position.y - heightOfSet;
        float maxY = transform.position.y + heightOfSet;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(minY,maxY), 0), transform.rotation);
    }

    
}
