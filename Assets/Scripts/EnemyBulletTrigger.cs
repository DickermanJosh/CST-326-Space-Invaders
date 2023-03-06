using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            Debug.Log("You Lose!");
        }
        else if (other.gameObject.CompareTag("Floor"))
        {
            Destroy(this.gameObject);
        }
        else if (other.gameObject.CompareTag("Barrier"))
        {
            Destroy(this.gameObject);
        }
    }
}
