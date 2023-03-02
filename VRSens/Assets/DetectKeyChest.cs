using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class DetectKeyChest : MonoBehaviour
{
    [SerializeField] GameObject ToDetect;
    
    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == ToDetect)
        {
            Debug.Log("Detect Key");      
        }
    }
}