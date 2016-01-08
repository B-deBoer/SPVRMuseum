using UnityEngine;
using System.Collections;

public class ExtendHole : MonoBehaviour {

    Vector3 scale;
    bool extend;
    public float speed;
    public float minScale, maxScale;

	// Use this for initialization
	void Start () {
        scale = transform.localScale;
        extend = true;
        minScale = 94;
        maxScale = 460;
	}
	
	// Update is called once per frame
	void Update () {
        if( scale.x >= maxScale || scale.x <= minScale)
        {
            extend = !extend;
        }

        if (scale.x < maxScale && extend)
        {
            transform.localScale = new Vector3(scale.x + speed, scale.y, scale.z + speed);
        }
        else if( scale.x > minScale && ! extend)
        {
            transform.localScale = new Vector3(scale.x - speed, scale.y, scale.z - speed);
        }
        scale = transform.localScale;
	}
}
