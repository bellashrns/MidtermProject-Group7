using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaliKiri2 : MonoBehaviour
{
    public float radius = 0.03f;
    public float height = 7f;
    public int numSegments = 20;

    // Start is called before the first frame update
    void Start()
    {
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        Mesh mesh = new Mesh();
        meshFilter.mesh = mesh;

        Vector3[] vertices = new Vector3[numSegments * 2];
        int[] triangles = new int[numSegments * 6];

        for (int i = 0; i < numSegments; i++)
        {
            float angle = 2 * Mathf.PI * i / numSegments;
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;

            vertices[i] = new Vector3(x, 0, z);
            vertices[i + numSegments] = new Vector3(x, height, z);

            int next = (i + 1) % numSegments;
            int ti = i * 6;
            triangles[ti] = i;
            triangles[ti + 1] = i + numSegments;
            triangles[ti + 2] = next;

            triangles[ti + 3] = next;
            triangles[ti + 4] = i + numSegments;
            triangles[ti + 5] = next + numSegments;
        }

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();

        transform.position = new Vector3(1.8f, 0.6f, 0);
        transform.localRotation = Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
