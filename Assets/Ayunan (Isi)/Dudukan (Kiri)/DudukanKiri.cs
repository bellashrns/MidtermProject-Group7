using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudukanKiri : MonoBehaviour
{
    public float seatWidth = 5;
    public float seatThickness = 0.3f;
    public float seatLength = 2f;
    // Start is called before the first frame update
    void Start()
    {
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        Mesh mesh = new Mesh();
        meshFilter.mesh = mesh;

        Vector3[] vertices = new Vector3[8];
        int[] triangles = new int[36];

        vertices[0] = new Vector3(-seatWidth / 2, 0, -seatLength / 2);
        vertices[1] = new Vector3(seatWidth / 2, 0, -seatLength / 2);
        vertices[2] = new Vector3(seatWidth / 2, 0, seatLength / 2);
        vertices[3] = new Vector3(-seatWidth / 2, 0, seatLength / 2);

        vertices[4] = new Vector3(-seatWidth / 2, seatThickness, -seatLength / 2);
        vertices[5] = new Vector3(seatWidth / 2, seatThickness, -seatLength / 2);
        vertices[6] = new Vector3(seatWidth / 2, seatThickness, seatLength / 2);
        vertices[7] = new Vector3(-seatWidth / 2, seatThickness, seatLength / 2);

        triangles[0] = 0; triangles[1] = 4; triangles[2] = 1;
        triangles[3] = 1; triangles[4] = 4; triangles[5] = 5;
        triangles[6] = 1; triangles[7] = 5; triangles[8] = 2;
        triangles[9] = 2; triangles[10] = 5; triangles[11] = 6;
        triangles[12] = 2; triangles[13] = 6; triangles[14] = 3;
        triangles[15] = 3; triangles[16] = 6; triangles[17] = 7;
        triangles[18] = 3; triangles[19] = 7; triangles[20] = 0;
        triangles[21] = 0; triangles[22] = 7; triangles[23] = 4;
        triangles[24] = 4; triangles[25] = 7; triangles[26] = 5;
        triangles[27] = 5; triangles[28] = 7; triangles[29] = 6;

        mesh.vertices = vertices;
        mesh.triangles = triangles;

        mesh.RecalculateNormals();

         transform.position = new Vector3(10.13f, 2.22f, 0.79f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class DudukanKiri : MonoBehaviour
// {
//     public float seatWidth = 5;
//     public float seatThickness = 0.3f;
//     public float seatLength = 2f;
//     public float grillSpacing = 0.5f; // Jarak antara batang-batang grill

//     void Start()
//     {
//         MeshFilter meshFilter = GetComponent<MeshFilter>();
//         Mesh mesh = new Mesh();
//         meshFilter.mesh = mesh;

//         int numGridX = Mathf.FloorToInt(seatWidth / grillSpacing);
//         int numGridZ = Mathf.FloorToInt(seatLength / grillSpacing);

//         int numVertices = (numGridX + 1) * (numGridZ + 1);
//         Vector3[] vertices = new Vector3[numVertices];

//         int numTriangles = numGridX * numGridZ * 2;
//         int[] triangles = new int[numTriangles * 3];

//         float halfWidth = seatWidth / 2;
//         float halfLength = seatLength / 2;
//         float halfThickness = seatThickness / 2;

//         for (int z = 0, i = 0; z <= numGridZ; z++)
//         {
//             float zPos = Mathf.Lerp(-halfLength, halfLength, (float)z / numGridZ);
//             for (int x = 0; x <= numGridX; x++, i++)
//             {
//                 float xPos = Mathf.Lerp(-halfWidth, halfWidth, (float)x / numGridX);
//                 vertices[i] = new Vector3(xPos, halfThickness, zPos);
//             }
//         }

//         for (int z = 0, ti = 0, vi = 0; z < numGridZ; z++, vi++)
//         {
//             for (int x = 0; x < numGridX; x++, ti += 6, vi++)
//             {
//                 triangles[ti] = vi;
//                 triangles[ti + 1] = vi + numGridX + 1;
//                 triangles[ti + 2] = vi + 1;
//                 triangles[ti + 3] = vi + 1;
//                 triangles[ti + 4] = vi + numGridX + 1;
//                 triangles[ti + 5] = vi + numGridX + 2;
//             }
//         }

//         mesh.vertices = vertices;
//         mesh.triangles = triangles;

//         mesh.RecalculateNormals();

//         transform.position = new Vector3(10.13f, 2.22f, 0.79f);
//     }

//     void Update()
//     {

//     }
// }
