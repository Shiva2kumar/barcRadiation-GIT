using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elementdrag : MonoBehaviour
{
    public BoxCollider colli;
    public GameObject pin;
    public float distance;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "catch")
        {
            ////////       this.gameObject.transform.position = other.gameObject.transform.position;
            distance = Vector3.Distance(this.transform.position, other.transform.position);
            if ((distance < 0.9f)&&((OVRInput.Get(OVRInput.RawButton.Y))||((OVRInput.Get(OVRInput.RawButton.B)))))
            {
                this.gameObject.transform.position = other.gameObject.transform.position;
            }
        }
    }
}