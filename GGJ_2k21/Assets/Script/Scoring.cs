using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour
{
    public GameObject toFind;
    public GameObject selector;
    public int score;
    public GameObject motherCube;
    public Vector3 posRand;
    public Vector3 posCroix;
    public GameObject Score;
    public ScriptableObject_Stockage stockage;


        // Start is called before the first frame update
        void Start()
    {
        trigger();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        checkScore();
    }

    void checkScore()
    {
        if (Input.GetKeyDown(KeyCode.Space) && toFind.transform.localPosition == selector.transform.localPosition)
        {
            if (stockage.greenCube)
            {
            stockage.posTP = new Vector3(266.3f, -0.5f, -1f);
            stockage.cameraPos = new Vector3(266.11f, 0f, -18.3f);
            
            stockage.green = false;
            stockage.greenCube = false;
            }
            if (stockage.blueCube)
            {
                stockage.blue = false;
                stockage.blueCube = false;
            }
            if (stockage.yellowCube)
            {
                stockage.yellow = false;
                stockage.yellowCube = false;
            }

            SceneManager.LoadScene(0);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Score.GetComponentInChildren<Cursor>().Tirer();
        }
    }

    float foncCroix(float n)
    {
        return 0.55f - (0.1f* n);
    }

    void trigger()
    {
        posRand.x = Random.Range(1, 10);
        posRand.y = Random.Range(1, 10);
        posRand.z = Random.Range(1, 10);
        toFind.transform.localPosition = posRand;
        posCroix.x = foncCroix(posRand.x);
        posCroix.y = foncCroix(posRand.y);
        posCroix.z = foncCroix(posRand.z);
        toFind.transform.localPosition = posCroix;

    }

}


