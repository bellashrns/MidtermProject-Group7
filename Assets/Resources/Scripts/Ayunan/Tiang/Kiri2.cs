using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class Cylinder2 : MonoBehaviour
{
    public float height = 10;
    public float radius = 0.1f;
    public int numSegments = 16;

    void Start()
    {
        CreateCylinderMesh();
    }

    void CreateCylinderMesh()
    {
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        Mesh mesh = new Mesh();
        meshFilter.mesh = mesh;

        int numVertices = (numSegments + 1) * 2;
        Vector3[] vertices = new Vector3[numVertices];
        int[] triangles = new int[numSegments * 6];

        for (int i = 0; i <= numSegments; i++)
        {
            float angle = 2 * Mathf.PI * i / numSegments;
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;

            vertices[i] = new Vector3(x, 0, z);
            vertices[i + numSegments + 1] = new Vector3(x, height, z);

            if (i < numSegments)
            {
                int triIndex = i * 6;
                triangles[triIndex] = i;
                triangles[triIndex + 1] = i + 1;
                triangles[triIndex + 2] = i + numSegments + 1;
                triangles[triIndex + 3] = i + 1;
                triangles[triIndex + 4] = i + numSegments + 2;
                triangles[triIndex + 5] = i + numSegments + 1;
            }
        }

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();

        transform.position = new Vector3(15, 0, 2.1f);
        transform.rotation = Quaternion.Euler(-5, 0, 0);
    }
}
