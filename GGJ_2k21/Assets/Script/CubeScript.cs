using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

            float XAxis = Input.GetAxis("Mouse X") * -speed;
            float YAxis = Input.GetAxis("Mouse Y") * speed;
            transform.Rotate(Vector3.down, XAxis);
            transform.Rotate(Vector3.right, YAxis);
    }
}
