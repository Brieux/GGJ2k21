using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    public Vector3 direction;
    public GameObject cible;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

        direction = (cible.transform.position - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime * speed;
    }
}
