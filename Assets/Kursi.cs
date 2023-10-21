using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kursi : MonoBehaviour
{
    [SerializeField]
    public Material cubeMaterial;

    float x = 1.0f;
    float y = 2.0f;
    float z = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[40];
        var uv = new Vector2[40]; 

        //Kaki pertama bawah
        vertices[0] = new Vector3(-x, -y, -z);
        vertices[1] = new Vector3(-0.9f, -y, -z);
        vertices[2] = new Vector3(-x, -y, -0.9f);
        vertices[3] = new Vector3(-0.9f, -y, -0.9f); 

        //Kaki pertama atas
        vertices[4] = new Vector3(-x, 0.0f, -z);
        vertices[5] = new Vector3(-0.9f, 0.0f, -z);
        vertices[6] = new Vector3(-x, 0.0f, -0.9f);
        vertices[7] = new Vector3(-0.9f, 0.0f, -0.9f);

        //Kaki kedua bawah
        vertices[8] = new Vector3(0.9f, -y, -z);
        vertices[9] = new Vector3(x, -y, -z);
        vertices[10] = new Vector3(0.9f, -y, -0.9f);
        vertices[11] = new Vector3(x, -y, -0.9f);
        //Kaki kedua atas
        vertices[12] = new Vector3(0.9f, 0.0f, -z);
        vertices[13] = new Vector3(x, 0.0f, -z);
        vertices[14] = new Vector3(0.9f, 0.0f, -0.9f);
        vertices[15] = new Vector3(x, 0.0f, -0.9f);

        //Kaki ketiga bawah
        vertices[16] = new Vector3(-x, -y, 0.9f);
        vertices[17] = new Vector3(-0.9f, -y, 0.9f);
        vertices[18] = new Vector3(-x, -y, z);
        vertices[19] = new Vector3(-0.9f, -y, z);
        //Kaki ketiga atas
        vertices[20] = new Vector3(-x, 0.0f, 0.9f);
        vertices[21] = new Vector3(-0.9f, 0.0f, 0.9f);
        vertices[22] = new Vector3(-x, 0.0f, z);
        vertices[23] = new Vector3(-0.9f, 0.0f, z);

        //Kaki keempat bawah
        vertices[24] = new Vector3(0.9f, -y, 0.9f);
        vertices[25] = new Vector3(x, -y, 0.9f);
        vertices[26] = new Vector3(0.9f, -y, z);
        vertices[27] = new Vector3(x, -y, z);
        //Kaki keempat atas
        vertices[28] = new Vector3(0.9f, 0.0f, 0.9f);
        vertices[29] = new Vector3(x, 0.0f, 0.9f);
        vertices[30] = new Vector3(0.9f, 0.0f, z);
        vertices[31] = new Vector3(x, 0.0f, z);

        //Pantat Kursi
        vertices[32] = new Vector3(-x, 0.2f, -z); //4
        vertices[33] = new Vector3(x, 0.2f, -z); //13
        vertices[34] = new Vector3(-x, 0.2f, z); //22
        vertices[35] = new Vector3(x, 0.2f, z); //31

        //Senderan Kursi Atas
        vertices[36] = new Vector3(-x, y, 0.9f);
        vertices[37] = new Vector3(x, y, 0.9f);
        vertices[38] = new Vector3(-x, y, z);
        vertices[39] = new Vector3(x, y, z);
        mesh.vertices = vertices;

        for (int i = 0; i < 40; i += 4){
            uv[i] = new Vector2(0, 0);
            uv[i+1] = new Vector2(0, 1);
            uv[i+2] = new Vector2(1, 0);
            uv[i+3] = new Vector2(1, 1);
        };

        mesh.uv = uv;

        mesh.triangles = new int[] {
            0,4,5,
            5,1,0,
            0,6,4,
            6,0,2,
            1,5,7,
            7,3,1,
            2,7,6,
            7,2,3, //kaki pertama
            8,12,13,
            13,9,8,
            8,14,12,
            14,8,10,
            9,13,15,
            15,11,9,
            10,15,14,
            15,10,11, //kaki kedua
            16,20,21,
            21,17,16,
            16,22,20,
            22,16,18,
            17,21,23,
            23,19,17,
            18,23,22,
            23,18,19, //kaki ketiga
            24,28,29,
            29,25,24,
            24,30,28,
            30,24,26,
            25,29,31,
            31,27,25,
            26,31,30,
            31,26,27, //kaki keempat
            4,13,22,
            13,31,22, //sisi kursi bawah
            32,35,33,
            35,32,34, //sisi kursi atas
            32,33,13,
            32,13,4,
            33,35,31,
            33,31,13,
            34,32,22,
            22,32,4,
            35,34,31,
            34,22,31, //sisi pinggir kursi
            36,37,29,
            20,36,29, //punggung kursi depan
            38,22,31,
            39,38,31, //punggung kursi belakang
            36,38,37,
            38,39,37, //punggung kursi atas
            38,36,22,
            22,36,20, //punggung kursi kiri
            37,39,31,
            31,29,37 //punggung kursi kanan
        };

        GetComponent<MeshFilter>().mesh = mesh;

        GetComponent<MeshRenderer>().material = cubeMaterial;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float cubeTime = Time.fixedTime;
        if (cubeTime % 2.0f == 0)
        {
            var mesh = GetComponent<MeshFilter>().mesh;
            var length = mesh.vertices.Length;
            Color32[] colors = new Color32[length];
            for (int i = 0; i < length; i++)
            {
                byte valueR = (byte)(Random.Range(0.0f, 1.0f) * 255);
                byte valueG = (byte)(Random.Range(0.0f, 1.0f) * 255);
                byte valueB = (byte)(Random.Range(0.0f, 1.0f) * 255);
                colors[i] = new Color32(valueR, valueG, valueB, 255);
            }
            mesh.colors32 = colors;
        }
    }
}

