using UnityEngine;
using System.Collections;

public class TransparentWall : MonoBehaviour {
    Color color;
    float newAlpha;
    bool decreasing;
	// Use this for initialization
	void Start () {
        color = GetComponent<Renderer>().material.color;
        newAlpha = 1;
        decreasing = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (newAlpha > 0 && decreasing)
        {
            newAlpha -= 0.01f;            
        }
        else if(newAlpha < 1 && !decreasing)
        {
            newAlpha += 0.01f; 
        }
        else
        {
            decreasing = !decreasing;
        }
        color.a = newAlpha;
        this.GetComponent<Renderer>().material.color = color;
	}
}
