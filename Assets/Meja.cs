using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;
using UnityEngine;
using UnityEngine.UIElements;

public class Meja : MonoBehaviour
{
    [SerializeField]
    public Material mejaMaterial;

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[40];
        var uvs = new Vector2[vertices.Length];

        Texture myTexture = Resources.Load<Texture>("Textures/wood");
        mejaMaterial.mainTexture = myTexture;

        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(0, 0, 1);
        vertices[2] = new Vector3(0, 5, 0);
        vertices[3] = new Vector3(0, 5, 1);

        vertices[4] = new Vector3(1, 0, 0);
        vertices[5] = new Vector3(1, 5, 0);
        vertices[6] = new Vector3(1, 0, 1);
        vertices[7] = new Vector3(1, 5, 1);

        vertices[8] = new Vector3(5, 0, 0);
        vertices[9] = new Vector3(5, 0, 1);
        vertices[10] = new Vector3(5, 5, 0);
        vertices[11] = new Vector3(5, 5, 1);

        vertices[12] = new Vector3(6, 0, 0);
        vertices[13] = new Vector3(6, 5, 0);
        vertices[14] = new Vector3(6, 0, 1);
        vertices[15] = new Vector3(6, 5, 1);

        vertices[16] = new Vector3(5, 0, 5);
        vertices[17] = new Vector3(5, 0, 6);
        vertices[18] = new Vector3(5, 5, 5);
        vertices[19] = new Vector3(5, 5, 6);

        vertices[20] = new Vector3(6, 0, 5);
        vertices[21] = new Vector3(6, 5, 5);
        vertices[22] = new Vector3(6, 0, 6);
        vertices[23] = new Vector3(6, 5, 6);

        vertices[24] = new Vector3(0, 0, 5);
        vertices[25] = new Vector3(0, 0, 6);
        vertices[26] = new Vector3(0, 5, 5);
        vertices[27] = new Vector3(0, 5, 6);

        vertices[28] = new Vector3(1, 0, 5);
        vertices[29] = new Vector3(1, 5, 5);
        vertices[30] = new Vector3(1, 0, 6);
        vertices[31] = new Vector3(1, 5, 6);

        vertices[32] = new Vector3(-1, 5, -1);
        vertices[33] = new Vector3(-1, 5, 7);
        vertices[34] = new Vector3(7, 5, -1);
        vertices[35] = new Vector3(7, 5, 7);

        vertices[36] = new Vector3(-1, 6, -1);
        vertices[37] = new Vector3(-1, 6, 7);
        vertices[38] = new Vector3(7, 6, -1);
        vertices[39] = new Vector3(7, 6, 7);

        mesh.vertices = vertices;

        for (int i = 0; i < vertices.Length; i+=4)
        {
            uvs[i] = new Vector2(0, 0);
            uvs[i + 1] = new Vector2(1, 0);
            uvs[i + 2] = new Vector2(0, 1);
            uvs[i + 3] = new Vector2(1, 1);
        }

        mesh.uv = uvs;

        mesh.triangles = new int[] {
            // kaki-kaki meja
            // selimut
            1, 3, 0,
            0, 3, 2,
            0, 2, 4,
            4, 2, 5,
            6, 7, 1, 
            1, 7, 3,
            4, 5, 6,
            6, 5, 7,
            // bawah
            6, 1, 4,
            4, 1, 0,
            // atas 
            2, 3, 5,
            5, 3, 7,
            
            // selimut
            9, 11, 8,
            8, 11, 10,
            8, 10, 12,
            12, 10, 13,
            14, 15, 9,
            9, 15, 11,
            12, 13, 14,
            14, 13, 15,
            // bawah
            14, 9, 12,
            12, 9, 8,
            // atas
            10, 11, 13,
            13, 11, 15,
            
            // selimut
            17, 19, 16,
            16, 19, 18,
            16, 18, 20,
            20, 18, 21,
            22, 23, 17,
            17, 23, 19,
            20, 21, 22,
            22, 21, 23,
            // bawah
            22, 17, 20,
            20, 17, 16,
            // atas
            18, 19, 21,
            21, 19, 23,
            
            // selimut
            25, 27, 24,
            24, 27, 26,
            24, 26, 28,
            28, 26, 29,
            30, 31, 25,
            25, 31, 27,
            28, 29, 30,
            30, 29, 31,
            // bawah
            30, 25, 28,
            28, 25, 24,
            // atas
            26, 27, 29,
            29, 27, 31,

            // atasnya kaki meja
            // bawah
            34, 35, 32, 
            32, 35, 33,

            // selimut
            32, 36, 34,
            34, 36, 38,
            33, 37, 32,
            32, 37, 36,
            35, 39, 33, 
            33, 39, 37,
            34, 38, 35, 
            35, 38, 39,

            // atas
            36, 37, 38, 
            38, 37, 39,
        };
        
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = mejaMaterial;
    }
}
