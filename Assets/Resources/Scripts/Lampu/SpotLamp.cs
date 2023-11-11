using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLamp : MonoBehaviour
{
    [SerializeField]
    public Material LampuMaterial;
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[8];

        vertices[0] = new Vector3(0.5f, 0.2f, 0);
        vertices[1] = new Vector3(-0.5f, 0.2f, 0);
        vertices[2] = new Vector3(0.5f, -0.2f, 0);
        vertices[3] = new Vector3(-0.5f, -0.2f, 0);

        vertices[4] = new Vector3(0.5f, 0.5f, 1f);
        vertices[5] = new Vector3(-0.5f, 0.5f, 1f);
        vertices[6] = new Vector3(0.5f, -0.5f, 1f);
        vertices[7] = new Vector3(-0.5f, -0.5f, 1f);

        // vertices[8] = new Vector3(0.2f, 1f, 0.5f);
        // vertices[9] = new Vector3(-0.2f, 1f, 0.5f);
        // vertices[10] = new Vector3(0.2f, -0.2f, 0.5f);
        // vertices[11] = new Vector3(-0.2f, -0.2f, 0.5f);

        // vertices[12] = new Vector3(0.2f, 1f, 0.3f);
        // vertices[13] = new Vector3(-0.2f, 1f, 0.3f);
        // vertices[14] = new Vector3(0.2f, -0.2f, 0.3f);
        // vertices[15] = new Vector3(-0.2f, -0.2f, 0.3f);

        mesh.vertices = vertices;

        mesh.triangles = new int[] {
            0, 2, 1,
            2, 3, 1,
            4, 5, 6,
            5, 7, 6,
            4, 1, 5,
            4, 0, 1,
            5, 1, 3,
            5, 3, 7,
            7, 3, 2,
            7, 2, 6,
            0, 4, 6,
            0, 6, 2,

            // 8, 9, 10,
            // 9, 11, 10,
            // 12, 14, 13,
            // 13, 14, 15,
            // 8, 10, 12,
            // 10, 14, 12,
            // 9, 13, 11,
            // 13, 15, 11,
            // 8, 12, 13,
            // 8, 13, 9,

        };

        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = LampuMaterial;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
