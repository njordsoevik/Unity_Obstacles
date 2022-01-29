using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test");
        speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(horizontal,0,vertical);
    }
}
