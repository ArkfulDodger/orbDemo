using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    public float speed = 1.0f;
    public float amplitude = 1.0f;

    public Vector3 tempPosition;
    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * speed) * amplitude;
        transform.position = tempPosition + startPosition;
    }
}
