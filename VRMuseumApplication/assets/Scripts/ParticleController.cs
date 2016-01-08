using UnityEngine;
using System.Collections;

public class ParticleController : MonoBehaviour {

    public GameObject player;
    public ParticleSystem PSLeaves, PSSnow;
    float rotation;

	// Use this for initialization
	void Start () {
        rotation = player.GetComponent<Transform>().rotation.eulerAngles.y;
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(player.transform.rotation.eulerAngles.y);
        if (player.transform.rotation.eulerAngles.y >= 0 && player.transform.rotation.eulerAngles.y < 180) 
        {
            PSLeaves.enableEmission = false;
            PSSnow.enableEmission = true;
            Debug.Log("snow");
        }
        else
        {
            PSLeaves.enableEmission = true;
            PSSnow.enableEmission = false;
            Debug.Log("leaf");
        }
	
	}
}
