using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AnimalBehavior : MonoBehaviour
{
    [SerializeField]
    protected int movementSpeed = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            WaterBehavior();//ABSTRACTION
        }
        else if (other.CompareTag("Boundary"))
        {
            Destroy(gameObject);
        }
    }

    protected abstract void WaterBehavior();//POLYMORPHISM
}
