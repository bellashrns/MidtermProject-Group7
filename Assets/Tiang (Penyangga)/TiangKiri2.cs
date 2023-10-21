using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]

public class TiangKiri2 : MonoBehaviour
{
    public float customHeight = 10;
    public float customRadius = 0.1f;
    public int customNumSegments = 16;
    // Start is called before the first frame update
    void Start()
    {
    MeshFilter customMeshFilter = GetComponent<MeshFilter>();
    Mesh customMesh = new Mesh();
    customMeshFilter.mesh = customMesh;

    int customNumVertices = (customNumSegments + 1) * 2;
    Vector3[] customVertices = new Vector3[customNumVertices];
    int[] customTriangles = new int[customNumSegments * 6];

    for (int i = 0; i <= customNumSegments; i++)
    {
        float angle = 2 * Mathf.PI * i / customNumSegments;
        float x = Mathf.Cos(angle) * customRadius;
        float z = Mathf.Sin(angle) * customRadius;

        customVertices[i] = new Vector3(x, 0, z);
        customVertices[i + customNumSegments + 1] = new Vector3(x, customHeight, z);

        if (i < customNumSegments)
        {
            int triIndex = i * 6;
            customTriangles[triIndex] = i;
            customTriangles[triIndex + 1] = i + 1;
            customTriangles[triIndex + 2] = i + customNumSegments + 1;
            customTriangles[triIndex + 3] = i + 1;
            customTriangles[triIndex + 4] = i + customNumSegments + 2;
            customTriangles[triIndex + 5] = i + customNumSegments + 1;
        }
    }

    customMesh.vertices = customVertices;
    customMesh.triangles = customTriangles;
    customMesh.RecalculateNormals();

    transform.position = new Vector3(15, 0, 2.1f);
    transform.rotation = Quaternion.Euler(-5, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
