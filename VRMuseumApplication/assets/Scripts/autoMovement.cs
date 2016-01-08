using UnityEngine;
using System.Collections;

public class autoMovement : MonoBehaviour {

    float time;
    float deltaTime;
    float posx;
    bool towards;
    Vector3 pos;

	// Use this for initialization
	void Start () {
        towards = true;
        time = 0;
        pos = GetComponent<Transform>().position;
        posx = pos.x;

	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(posx);
        if (posx < -10 && towards)
        {
            posx = posx + 0.01f;
            GetComponent<Transform>().position = new Vector3(posx, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z);
        
        }
        else if(posx > -20 && !towards)
        {
            posx = posx - 0.01f;
            GetComponent<Transform>().position = new Vector3(posx, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z);
        }
        else
        {
            time += Time.deltaTime;
            if (time > 5)
            {
                time = 0;
                towards = !towards;
            }
        }
             

	}
}
