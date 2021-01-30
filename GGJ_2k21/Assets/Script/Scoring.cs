using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public GameObject toFind;
    public GameObject selector;
    public int score;
    public GameObject motherCube;
    public Vector3 posRand;
    public Vector3 posCroix;
    public GameObject Score;


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
            score += 1;
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


