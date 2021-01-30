using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTosco : MonoBehaviour
{
    public float velMov = 5f;
    public float velRot = 3f;


    void FixedUpdate()
    {
        if (Mathf.Abs(Input.GetAxis("Vertical")) > 0.1f || Mathf.Abs(Input.GetAxis("Horizontal")) > 0.1f)
        {
            transform.Translate(Input.GetAxis("Vertical") * velMov * Vector3.forward * Time.deltaTime);
            transform.Translate(Input.GetAxis("Horizontal") * velMov * Vector3.right * Time.deltaTime);
        }

        if (Mathf.Abs(Input.GetAxis("Mouse X")) > .01f)
            transform.Rotate(0, Input.GetAxis("Mouse X") * velRot * Time.deltaTime, 0);
    }
}