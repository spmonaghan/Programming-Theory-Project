using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBehavior : AnimalBehavior //INHERITANCE
{
    private Rigidbody rb;
    [SerializeField]
    private int catJumpForce = 15;

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
        movementSpeed = 0;
        rb.AddForce(new Vector3(-1, 1, 0) * catJumpForce, ForceMode.Impulse);
    }
}
