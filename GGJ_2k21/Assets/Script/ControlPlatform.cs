using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlPlatform : MonoBehaviour
{
    public float speed;
    public Rigidbody playerRb;
    public GameObject player;
    public GameObject cam1;
    public bool control;
    public bool green;
    public bool yellow;
    public bool blue;
    public ScriptableObject_Stockage stockage;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = stockage.posTP;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateBool();

    }

    private void FixedUpdate()
    {
        Move();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Gate")
        {
            transform.position = collision.gameObject.GetComponentInChildren<tpScript>().tpPos;
            cam1.transform.position = collision.gameObject.GetComponentInChildren<tpScript>().tpCamera;
            if (collision.gameObject.GetComponentInChildren<tpScript>().numeroCase == 1)
            {
                cam1.GetComponentInChildren<AudioSource>().clip = collision.gameObject.GetComponentInChildren<tpScript>().newSound;
                cam1.GetComponentInChildren<AudioSource>().Play();
            }

        }
  
        if (collision.gameObject.tag == "CubeG" && stockage.green)
        {
            control = false;
            stockage.greenCube = true;
            SceneManager.LoadScene(1);
        }
    }
    void Move()
    {
        if (control)
        {
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");
            playerRb.AddForce(y * transform.up * speed, ForceMode.Acceleration);
            playerRb.AddForce(x * transform.right * speed, ForceMode.Acceleration);
        }
    }

    void UpdateBool()
    {
        blue = stockage.blue;
        yellow = stockage.yellow;
        green = stockage.green;
    }
}
