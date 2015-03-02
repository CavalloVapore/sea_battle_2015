using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{

    public int Boundary = 50;
    public int speed = 3;
    private int theScreenWidth;
    private int theScreenHeight;
    public int orthographicSizeMin = 1;
    public int orthographicSizeMax = 6;

    void Start()
    {
        theScreenWidth = Screen.width;
        theScreenHeight = Screen.height;
    }
    void Update()
    {
        if (Input.mousePosition.x > theScreenWidth - Boundary)
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (Input.mousePosition.x < 0 + Boundary)
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (Input.mousePosition.y > theScreenHeight - Boundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed * Time.deltaTime);
        }
        if (Input.mousePosition.y < 0 + Boundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed * Time.deltaTime);
        }

        

    if (Input.GetAxis("Mouse ScrollWheel") < 0) // forward
    {
    Camera.main.orthographicSize++;
    }
    if (Input.GetAxis("Mouse ScrollWheel") > 0) // back
    {
    Camera.main.orthographicSize--;
    }
     
    Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, orthographicSizeMin, orthographicSizeMax );
    }
}
