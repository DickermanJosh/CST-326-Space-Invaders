using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
public class EnemyShooting : MonoBehaviour
{
     public GameObject EnemybulletPrefab;
     public Transform shootOffsetTransform;
     public int maxNum = 100;
     

     // Update is called once per frame
    void Update()
    {
        int randomNum = Random.Range(1, maxNum);
        if (randomNum == 50)
        {
            GameObject shot = Instantiate(EnemybulletPrefab, shootOffsetTransform.position, Quaternion.identity);
            Destroy(shot, 8f);
        } 
    }
}
