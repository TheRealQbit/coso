using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BLUEtransparent : MonoBehaviour
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
            rend.materials[i].SetVector("_Color", new Vector4(1, 1, 255, 0.7f));
        }
    }
}
