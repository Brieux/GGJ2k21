using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    private Vector3 posAct;
    public Vector3 select = new Vector3(0,0,0);
    public GameObject target;
    public GameObject proj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Select()
    {
        posAct = transform.localPosition;
        select =new Vector3(5.5f-10*posAct.x, 5.5f-10*posAct.y, 5.5f-10*posAct.z);
    }

    void Move()
    {
        Vector3 newPos;
        if (transform.localPosition.x < 0.45f)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                newPos = new Vector3(0.1f, 0, 0);
                transform.localPosition = transform.localPosition + newPos;
            }
        }
        if (transform.localPosition.x > -0.45f)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                newPos = new Vector3(-0.1f, 0, 0);
                transform.localPosition = transform.localPosition + newPos;
            }
        }
        if (transform.localPosition.y < 0.45f)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                newPos = new Vector3(0, 0.1f, 0);
                transform.localPosition = transform.localPosition + newPos;
            }
        }
        if (transform.localPosition.y > -0.45f)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                newPos = new Vector3(0, -0.1f, 0);
                transform.localPosition = transform.localPosition + newPos;
            }
        }
        if (transform.localPosition.z < 0.45f)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                newPos = new Vector3(0, 0, 0.1f);
                transform.localPosition = transform.localPosition + newPos;
            }
        }
        if (transform.localPosition.z > -0.45f)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                newPos = new Vector3(0, 0, -0.1f);
                transform.localPosition = transform.localPosition + newPos;
            }
        }
        Select();
    }

    public void Tirer()
    {
        GameObject sphere = Instantiate(proj, transform.position, transform.rotation) ;
        sphere.GetComponentInChildren<Launch>().cible = target;

    }
}
