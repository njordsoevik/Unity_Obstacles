using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float xRotate = 0.1f;
    void Update()
    {
        this.transform.Rotate(0,xRotate,0);
    }
}
