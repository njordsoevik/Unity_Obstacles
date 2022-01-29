using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    private Rigidbody rbody;
    private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();

        rbody.useGravity = false;
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 3) {
            rbody.useGravity = true;
            rend.enabled = true;
        }
    }
}
