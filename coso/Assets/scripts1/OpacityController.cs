using UnityEngine;
using UnityEngine.UI;

public class OpacityController : MonoBehaviour
{
    Renderer rend;
    void Start()
    {
         GameObject[] firstcolour = GameObject.FindGameObjectsWithTag( "Colour1");
        rend = GetComponent<Renderer>();
        rend.material.shader = Shader.Find("Custom/TransparentDiffuse ZWrite");
    }

    void Update()
    {
        for(int i=0; i<rend.materials.Length;i++)
        {
            rend.materials[i].SetVector("_Color", new Vector4(1, 1, 1, 0.75f));
        }
    }
}
