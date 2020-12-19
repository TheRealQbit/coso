using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REDtransparet : MonoBehaviour
{
    Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.shader = Shader.Find("Custom/TransparentDiffuse ZWrite");
    }

    void Update()
    {
        for(int i=0; i<rend.materials.Length;i++)
        {
            rend.materials[i].SetVector("_Color", new Vector4(255, 1, 1, 0.7f));
        }
    }
}