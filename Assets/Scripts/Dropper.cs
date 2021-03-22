using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer ren;
    Rigidbody rb;
    [SerializeField] float timeToWait = 5f;
    // Start is called before the first frame update
    void Start()
    {
        ren = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        ren.enabled = false;
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
            Debug.Log("3 sec");
            ren.enabled = true;
            rb.useGravity = true;
        }
    }
}
