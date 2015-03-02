using UnityEngine;
using System.Collections;

public class SelectShip : MonoBehaviour {

    public Color mouseOverColor = Color.blue;
    public Color originalColor = Color.yellow;
    private bool dragging = false;
    private float distance;
    private Vector3 screenPoint;


    void OnMouseEnter()
    {
        renderer.material.color = mouseOverColor;
    }

    void OnMouseExit()
    {
        renderer.material.color = originalColor;
    }

    void OnMouseDown()
    {
        dragging = true;
    }

    void OnMouseUp()
    {
        dragging = false;
    }

    void Update()
    {
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(52);
            transform.position = rayPoint;
        }
    }

    
}
