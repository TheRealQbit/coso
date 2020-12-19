using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectdetect : MonoBehaviour
{
    public Material red;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 60, Color.red);

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity)) 
        {
            red = hit.transform.gameObject.tag == "red";







        }
    }
}
