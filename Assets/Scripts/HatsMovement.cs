using UnityEngine;
using System.Collections;

public class HatsMovement : MonoBehaviour
{ 
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void EnableRagdoll()
    {
        rb.isKinematic = false;
        rb.detectCollisions = true;
    }

    private void OnDisable()
    {
        rb.isKinematic = true;
        rb.detectCollisions = false;
    }
}

