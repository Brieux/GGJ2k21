using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 randomVect;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       randomVect  = new Vector3(Random.Range(1,10), Random.Range(1,10), Random.Range(1,10));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(randomVect * speed); ;
    }
}
