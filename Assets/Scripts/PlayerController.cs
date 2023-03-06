using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
     public GameObject bulletPrefab;
     public Transform shootOffsetTransform;
    private Rigidbody rb;
   
    public float moveSpeed = 1;
    private float getAxis;
    private Vector3 move;
    
    // Start is called before the first frame update
    private void Start()
    { 
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject shot = Instantiate(bulletPrefab, shootOffsetTransform.position, Quaternion.identity);

            Destroy(shot, 8f);
        }
    }
    void FixedUpdate()
    {
        getAxis = Input.GetAxis("Horizontal");
        move = moveSpeed * new Vector3(getAxis, 0f, 0f);
        rb.AddForce(move * (moveSpeed * Time.deltaTime),ForceMode.Force);
    }
}
