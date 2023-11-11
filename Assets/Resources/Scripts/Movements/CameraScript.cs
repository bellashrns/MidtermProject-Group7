using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public float rotationSpeed = 2.0f;
    private Vector3 lastMousePosition;
    void Start()
    {
        lastMousePosition = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        // Gerakan translasi
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 2);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 2);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * 2);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 2);
        }

        // Gerakan rotasi dengan mouse
        Vector3 deltaMousePosition = Input.mousePosition - lastMousePosition;

        if (Input.GetMouseButton(0)) // Tombol kiri mouse ditekan
        {
            transform.Rotate(Vector3.up * deltaMousePosition.x * rotationSpeed * Time.deltaTime);
            transform.Rotate(Vector3.left * deltaMousePosition.y * rotationSpeed * Time.deltaTime);
        }

        lastMousePosition = Input.mousePosition;


    }
}
