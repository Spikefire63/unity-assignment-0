using UnityEngine;

public class Lights : MonoBehaviour
{
    Material material;

    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        material = renderer.materials[0];
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
