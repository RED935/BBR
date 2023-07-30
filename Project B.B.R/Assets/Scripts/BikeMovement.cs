using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.forward * speed;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
          gameObject.transform.Rotate(0f, 90f, 00f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
          gameObject.transform.Rotate(0f, -90f, 0f);
        }
    }
}
