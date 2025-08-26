using UnityEngine;

public class Lights : MonoBehaviour
{
    Material material;

    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        material = renderer.materials[1];
    }

    private void OnTriggerEnter(Collider other)
    {
        
         Color currentEmission = material.GetColor("_EmissionColor");
         material.SetColor("_EmissionColor", currentEmission * 0f);
        
    }
}
