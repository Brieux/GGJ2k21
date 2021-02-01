using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGreen : MonoBehaviour
{
    public ScriptableObject_Stockage stockage;
    public Vector3 memory;
    // Start is called before the first frame update
    void Start()
    {
        memory = this.GetComponentInParent<RectTransform>().localScale;
        if (stockage.green)
        {
            this.GetComponentInParent<RectTransform>().localScale = new Vector3(0f, 0f, 0f);
        }
        if (!stockage.green)
        {
            this.GetComponentInParent<RectTransform>().localScale = memory;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (stockage.green)
        {
            this.GetComponentInParent<RectTransform>().localScale = new Vector3(0f, 0f, 0f);
        }
        if (!stockage.green)
        {
            this.GetComponentInParent<RectTransform>().localScale = memory;
        }
    }
}
