using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(playerPrefab, new Vector3(0f, -3.75f, -1f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
