using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiangSpotlight : MonoBehaviour
{
    [SerializeField]
    public Material TiangMaterial;
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[16];

        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(0, 0, 1f);
        vertices[2] = new Vector3(1f, 0, 0);
        vertices[3] = new Vector3(1f, 0, 1f);

        vertices[4] = new Vector3(0, 0.2f, 0);
        vertices[5] = new Vector3(0, 0.2f, 1f);
        vertices[6] = new Vector3(1f, 0.2f, 0);
        vertices[7] = new Vector3(1f, 0.2f, 1f);

        vertices[8] = new Vector3(0.4f, 0.2f, 0.4f);
        vertices[9] = new Vector3(0.4f, 0.2f, 0.6f);
        vertices[10] = new Vector3(0.6f, 0.2f, 0.4f);
        vertices[11] = new Vector3(0.6f, 0.2f, 0.6f);

        vertices[12] = new Vector3(0.4f, 5f, 0.4f);
        vertices[13] = new Vector3(0.4f, 5f, 0.6f);
        vertices[14] = new Vector3(0.6f, 5f, 0.4f);
        vertices[15] = new Vector3(0.6f, 5f, 0.6f);

        mesh.vertices = vertices;

        var colors = new Color32[vertices.Length];
        colors[0] = new Color32(77, 60, 60, 255);
        colors[1] = new Color32(77, 60, 60, 255);
        colors[2] = new Color32(77, 60, 60, 255);
        colors[3] = new Color32(77, 60, 60, 255);
        colors[4] = new Color32(77, 60, 60, 255);
        colors[5] = new Color32(77, 60, 60, 255);
        colors[6] = new Color32(77, 60, 60, 255);
        colors[7] = new Color32(77, 60, 60, 255);

        for (int i = 8; i < vertices.Length; i++)
        {
            colors[i] = new Color32(233, 229, 229, 255);
        }

        mesh.colors32 = colors;

        mesh.triangles = new int[] {
            // kaki tiang
            2, 1, 0,
            2, 3, 1, // alas kaki tiang
            4, 5, 6,
            7, 6, 5, // atap kaki tiang
            0, 1, 4,
            1, 5, 4, // sisi 1 kaki tiang
            0, 6, 2,
            0, 4, 6, // sisi 2 kaki tiang
            1, 3, 5,
            5, 3, 7, // sisi 3 kaki tiang
            2, 6, 7,
            7, 3, 2, // sisi 4 kaki tiang

            // tiang
            13, 14, 12,
            13, 15, 14, // atap tiang
            8, 12, 10,
            10, 12, 14, // sisi 1 tiang
            10, 14, 15,
            15, 11, 10, // sisi 2 tiang
            15, 13, 9,
            15, 9, 11, // sisi 3 tiang
            12, 8, 9,
            12, 9, 13, // sisi 4 tiang

        };

        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = TiangMaterial;
        TiangMaterial.color = new Color32(77, 60, 60, 255);
    }

    // Update is called once per frame
    void Update()
    {

    }
}