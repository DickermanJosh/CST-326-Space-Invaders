using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * (moveSpeed * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            // change direction and move toward player
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);
            moveSpeed *= -1;
        }
    }
}
