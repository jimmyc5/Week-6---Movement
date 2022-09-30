using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingThing : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 initialPosition;
    public Vector3 moveToPosition;
    public float speed;

    private Vector3 goalVector;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
        goalVector = moveToPosition - initialPosition;
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(initialPosition + (Mathf.Sin(Time.time) + 1f / 2f) * goalVector);
    }
}
