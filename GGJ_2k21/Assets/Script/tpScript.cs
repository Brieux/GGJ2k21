using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class tpScript : MonoBehaviour
{
    public int numeroCase;
    public Vector3 tpPos;
    public Vector3 tpCamera;
    public AudioClip newSound;
    public ScriptableObject_Stockage stockage;
    public VideoClip vidsOutro;
    public GameObject PanelVids;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!stockage.blue && !stockage.green && !stockage.yellow && numeroCase == 0)
            {
                PanelVids.GetComponentInChildren<VideoPlayer>().targetCameraAlpha = 1;
                PanelVids.GetComponentInChildren<VideoPlayer>().clip = vidsOutro;
                PanelVids.GetComponentInChildren<VideoPlayer>().Play();

            }
        }
    }
}
