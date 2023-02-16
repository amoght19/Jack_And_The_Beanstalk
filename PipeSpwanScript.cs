using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpwanScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    private float timer=0;
    public float spawnRate=2;
    private float heightOffset=10;
    void Start()
    {
     spawnPipe();   
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnRate){
            timer+=Time.deltaTime;
        }
        else {
            spawnPipe();
            timer=0;
        }
    }

    void spawnPipe(){
        float maxHeight=transform.position.y+heightOffset;
        float minHeight=transform.position.y-heightOffset;
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(minHeight,maxHeight)),transform.rotation);
    }
}
