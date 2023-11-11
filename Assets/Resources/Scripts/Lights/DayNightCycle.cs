using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public float DayLength;
    private float _rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _rotationSpeed = Time.deltaTime / DayLength;
        transform.Rotate(0, _rotationSpeed, 0);
    }
}
