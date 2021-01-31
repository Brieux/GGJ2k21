using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Fondu : MonoBehaviour
{
    public GameObject PanelVids;
    public VideoPlayer vidsIntro;
    public GameObject player;
    public ScriptableObject_Stockage stockage;
    // Start is called before the first frame update
    void Start()
    {
        vidsIntro = PanelVids.GetComponent<VideoPlayer>();
        player.GetComponentInChildren<ControlPlatform>().control = false;
        transform.position = stockage.cameraPos;

    }

    // Update is called once per frame
    void Update()
    {
        if (!stockage.blue)
        {
            vidsIntro.Pause();
        }
        else if (!stockage.green)
        {
            vidsIntro.Pause();
        }
        else if (!stockage.yellow)
        {
            vidsIntro.Pause();
        }
        print(vidsIntro.isPaused);
        if (vidsIntro.isPaused)
        {
            if (vidsIntro.targetCameraAlpha > 0)
            {
                vidsIntro.targetCameraAlpha -= 0.01f;
                
            }
            if (vidsIntro.targetCameraAlpha <= 0)
            {
                player.GetComponentInChildren<ControlPlatform>().control = true;
                DestroyImmediate(this);
            }   
        }
    }
}
