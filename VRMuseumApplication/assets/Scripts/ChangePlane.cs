using UnityEngine;
using System.Collections;

public class ChangePlane : MonoBehaviour {

    public GameObject meshSource, meshSource2;
    Mesh currentMesh, targetMesh, startMesh, tempMesh;
    int nVertices;
    Vector3[] startVertices, targetVertices, newVertices;
    public GameObject player;
    Vector3 playerPos;
    float distance;
    

	// Use this for initialization
	void Start () {

        

        // Set up start, target and current meshes.
        startMesh = meshSource2.GetComponent<MeshFilter>().sharedMesh;
        targetMesh = meshSource.GetComponent<MeshFilter>().sharedMesh;
        currentMesh = new Mesh();

        // Create arrays for start and target meshes and store the vertex positions.
        nVertices = targetMesh.vertexCount;
        startVertices = new Vector3[nVertices];
        targetVertices = new Vector3[nVertices];
        newVertices = new Vector3[nVertices];

        for (int i = 0; i < nVertices; i++ )
        {
            startVertices[i] = startMesh.vertices[i];
            targetVertices[i] = targetMesh.vertices[i];
        }




	}
	
	// Update is called once per frame
	void Update () {

        playerPos = player.transform.position;
        distance = Mathf.Abs(playerPos.x - GetComponent<Transform>().position.x);


        Debug.Log("distance: " + distance );

        if (distance <= 20 && distance >= 10)
        {
            for (int i = 0; i < nVertices; i++)
                newVertices[i] = startVertices[i] - ((targetVertices[i] - startVertices[i]) / 10 * (distance - 20));


            currentMesh.vertices = newVertices;
            currentMesh.uv = targetMesh.uv;
            currentMesh.triangles = targetMesh.triangles;
            currentMesh.RecalculateNormals();
            currentMesh.RecalculateBounds();

            GetComponent<MeshFilter>().mesh = currentMesh;
        }

	}
}
