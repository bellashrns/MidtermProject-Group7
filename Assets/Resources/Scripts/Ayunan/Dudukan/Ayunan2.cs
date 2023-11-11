using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class Ayunan2 : MonoBehaviour
{
    public float seatWidth = 4;
    public float seatThickness = 0.2f;
    public float seatLength = 2f;

    void Start()
    {
        CreateSwingSeatMesh();
    }

    void CreateSwingSeatMesh()
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

         transform.position = new Vector3(10.46f, 2.77f, 0.8f);
    }
}
