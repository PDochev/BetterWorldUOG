using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    
    public float movingSpeed = 1;
    public float rotationSpeed = 1;
    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
            float yRotation = Input.GetAxis("Horizontal");
            transform.Rotate(new Vector3(0,yRotation,0));
            float z = Input.GetAxis("Vertical");
            Vector3 moveDir = new Vector3(z, 0, 0);
            transform.Translate(Vector3.forward * (z * movingSpeed));
            //_rb.MovePosition(_rb.transform.forward + moveDir * (movingSpeed * Time.deltaTime));
        
        
    }
}

