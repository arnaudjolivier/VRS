using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class TPScript : MonoBehaviour
{
    [SerializeField] Vector3 TPDestination;
    [SerializeField] GameObject ToDetect;
    [SerializeField] GameObject Player;
    [SerializeField] bool Relative;
    [SerializeField] bool TpPlayer;
    [SerializeField] bool TpOnce;
    bool once;
    
    // Start is called before the first frame update
    void Start()
    {
        once = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == ToDetect)
        {
            if (TpOnce)
                if (once == false)
                    once = true;
                else
                    return;

            Debug.Log("TP: " + other.gameObject.name + " to " + TPDestination);

            if (Relative)
            {
                if (Player != null && TpPlayer)
                    Player.transform.position += TPDestination;
                else
                    other.gameObject.transform.position += TPDestination;
            }
            else
            {
                if (Player != null && TpPlayer)
                    Player.transform.position = TPDestination;
                else
                    other.gameObject.transform.position = TPDestination;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(Relative ? transform.position + TPDestination : TPDestination, .1f);
    }
}