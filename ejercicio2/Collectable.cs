using UnityEngine;

public class collectable : MonoBehaviour
{
    private bool collected = false;
    private Collider col;
    private Renderer rd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        col = GetComponent<Collider>();
        rd = GetComponent<Renderer>();
    }

    void OnPointerEnter() 
    {
        if (!collected) {
            collected = true;
            rd.enabled = false;
            col.enabled = false;
        }
    }

    public void OnPointerExit()
    {
        // Método vacío para satisfacer a SendMessage y evitar el error
    }
}
