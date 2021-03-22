using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spineer : MonoBehaviour
{
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 0;
    [SerializeField] float zAngle = 0;
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
