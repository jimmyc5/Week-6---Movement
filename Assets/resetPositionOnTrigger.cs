using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPositionOnTrigger : MonoBehaviour
{
    public Vector3 startingPos;
    private CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        startingPos = this.transform.position;
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Restart")
        {
            Debug.Log("hi");
            cc.enabled = false;
            this.transform.position = startingPos;
            cc.enabled = true;
        }
    }
}
