using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlatform : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Vertical"))
        {
            Vector3 newPos = Vector3.up;
            transform.position = transform.position + newPos * speed * Input.GetAxisRaw("Vertical");
        }
        if (Input.GetButton("Horizontal"))
        {
            Vector3 newPos = Vector3.left;
            transform.position = transform.position + newPos * -speed * Input.GetAxisRaw("Horizontal");
        }
    }
}
