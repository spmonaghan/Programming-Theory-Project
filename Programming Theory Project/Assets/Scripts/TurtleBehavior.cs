using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleBehavior : AnimalBehavior
{
    private Rigidbody rb;
    private float swimForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * movementSpeed * Time.deltaTime;
    }

    protected override void WaterBehavior()
    {
        movementSpeed *= 2;
        rb.useGravity = false;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Water"))
            {
            movementSpeed = 0;
            rb.useGravity = true;
            }
    }
}
