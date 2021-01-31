using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Fondu : MonoBehaviour
{
    public GameObject PanelVids;
    public VideoPlayer vidsIntro;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        vidsIntro = PanelVids.GetComponent<VideoPlayer>();
        player.GetComponentInChildren<ControlPlatform>().control = false;

    }

    // Update is called once per frame
    void Update()
    {
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
            }   
        }
    }
}
