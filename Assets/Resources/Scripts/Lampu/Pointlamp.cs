using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lampu : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public Material LampuMaterial;
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[16];

        vertices[0] = new Vector3(-0.5f, -0.5f, -0.5f);
        vertices[1] = new Vector3(-0.5f, -0.5f, 0.5f);
        vertices[2] = new Vector3(0.5f, -0.5f, -0.5f);
        vertices[3] = new Vector3(0.5f, -0.5f, 0.5f);

        vertices[4] = new Vector3(-0.3f, 0.3f, -0.3f);
        vertices[5] = new Vector3(-0.3f, 0.3f, 0.3f);
        vertices[6] = new Vector3(0.3f, 0.3f, -0.3f);
        vertices[7] = new Vector3(0.3f, 0.3f, 0.3f);

        vertices[8] = new Vector3(-0.1f, 0.3f, -0.1f);
        vertices[9] = new Vector3(-0.1f, 0.3f, 0.1f);
        vertices[10] = new Vector3(0.1f, 0.3f, -0.1f);
        vertices[11] = new Vector3(0.1f, 0.3f, 0.1f);

        vertices[12] = new Vector3(-0.1f, 0.5f, -0.1f);
        vertices[13] = new Vector3(-0.1f, 0.5f, 0.1f);
        vertices[14] = new Vector3(0.1f, 0.5f, -0.1f);
        vertices[15] = new Vector3(0.1f, 0.5f, 0.1f);

        // vertices[16] = new Vector3(0.3f, 0f, 0.3f);
        // vertices[17] = new Vector3(0.3f, 0f, 0.5f);
        // vertices[18] = new Vector3(0.5f, 0f, 0.3f);
        // vertices[19] = new Vector3(0.5f, 0f, 0.5f);

        // vertices[20] = new Vector3(0.3f, 1f, 0.3f);
        // vertices[21] = new Vector3(0.3f, 1f, 0.5f);
        // vertices[22] = new Vector3(0.5f, 1f, 0.3f);
        // vertices[23] = new Vector3(0.5f, 1f, 0.5f);

        mesh.vertices = vertices;

        mesh.triangles = new int[] {
            2, 1, 0,
            2, 3, 1,
            4, 5, 6,
            7, 6, 5,
            0, 1, 4,
            1, 5, 4,
            0, 6, 2,
            0, 4, 6,
            1, 3, 5,
            5, 3, 7,
            2, 6, 7,
            7, 3, 2,

            8, 10, 9,
            9, 10, 11,
            12, 13, 14,
            13, 15, 14,
            12, 14, 8,
            14, 10, 8,
            14, 15, 11,
            14, 11, 10,
            15, 13, 11,
            13, 9, 11,
            13, 12, 9,
            12, 8, 9,
            // 20, 22, 16,
            // 22, 18, 16,

            // 22, 23, 19,
            // 22, 19, 18,

            // 23, 21, 19,
            // 21, 17, 19,

            // 20, 17, 21,
            // 20, 16, 17,

            // 20, 21, 22,
            // 21, 23, 22,
        };

        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = LampuMaterial;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
