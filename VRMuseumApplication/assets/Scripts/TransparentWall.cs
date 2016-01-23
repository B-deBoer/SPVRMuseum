using UnityEngine;
using System.Collections;

public class TransparentWall : MonoBehaviour {
    Color color;
    float newAlpha, timer;
    bool decreasing;
    float speed = 0.25f;
    float pause = 1; // Wait 1 sec when fully opaque/transparent.


	// Use this for initialization
	void Start () {
        color = GetComponent<Renderer>().material.color;
        newAlpha = 1;
        decreasing = true;
	}
	
	// Update is called once per frame
	void Update () {
        if(timer > 1/speed + pause)
        {
            // Reset timer.
            timer = 0;
        }
        else if(timer > (1/speed))
        {
            // Pause when fully transparant or opaque.
            timer += Time.deltaTime;
        }
        else if (newAlpha > 0 && decreasing)
        {
            newAlpha -= Time.deltaTime * speed;
            timer += Time.deltaTime;
        }
        else if(newAlpha < 1 && !decreasing)
        {
            newAlpha += Time.deltaTime * speed;
            timer += Time.deltaTime;
        }
        else
        {
            decreasing = !decreasing;
        }
        
        color.a = newAlpha;
        this.GetComponent<Renderer>().material.color = color;
	}
}
