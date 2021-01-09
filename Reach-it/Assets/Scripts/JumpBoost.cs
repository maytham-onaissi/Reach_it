using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    [SerializeField] float duration;
    [SerializeField] float jumpRange;
    [SerializeField] GameObject pickUpEffect;

   private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           StartCoroutine(PickUp(other));
        }
    }

    IEnumerator PickUp(Collider player)
    { 
        
        Instantiate(pickUpEffect, transform.position, transform.rotation);

        GetComponent<Collider>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;

        player.attachedRigidbody.AddForce(Vector3.up * jumpRange);

        yield return new WaitForSeconds(duration);

        GetComponent<Collider>().enabled = true;
        GetComponent<MeshRenderer>().enabled = true;

    }
}
