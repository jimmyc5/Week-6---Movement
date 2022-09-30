using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copyRotation : MonoBehaviour
{
    public Transform rotationToCopy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(-90,rotationToCopy.eulerAngles.y,0);
    }
}
