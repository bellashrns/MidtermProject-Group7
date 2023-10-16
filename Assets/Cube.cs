using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[24];

        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(0, 0, 1);
        vertices[2] = new Vector3(0, 1, 0);
        vertices[3] = new Vector3(0, 1, 1);

        vertices[4] = new Vector3(1, 0, 0);
        vertices[5] = new Vector3(1, 1, 0);

        vertices[6] = new Vector3(1, 0, 1);
        vertices[7] = new Vector3(1, 1, 1);



        mesh.vertices = vertices;

        mesh.triangles = new int[] {
            1, 3, 0,
            0, 3, 2,
            0, 2, 4,
            4, 2, 5,
            6, 7, 1, 
            1, 7, 3,
            4, 5, 6,
            6, 5, 7,
            0, 1, 4, 
            4, 1, 6,
            2, 3, 5,
            5, 3, 7
        };

        GetComponent<MeshFilter>().mesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
