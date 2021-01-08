using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    [SerializeField] Transform addedObject;
    [SerializeField] Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        addedObject.transform.position = respawnPoint.transform.position;
    }
}
