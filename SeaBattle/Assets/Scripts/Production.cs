using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Production : MonoBehaviour
{
    public Texture scout, arrow, ram, cannon;

    void Start()
    {


    }






    void OnGUI()
    {
        Debug.Log(scout.height);
        GUI.DrawTexture(new Rect(3 * Screen.width / 4 + 5, 4 * Screen.height / 5 + 50, 27, 27), scout, ScaleMode.ScaleToFit, true, 0);
        GUI.DrawTexture(new Rect(3 * Screen.width / 4 + 35, 4 * Screen.height / 5 + 50, 27, 27), scout, ScaleMode.ScaleToFit, true, 0);
        GUI.DrawTexture(new Rect(3 * Screen.width / 4 + 65, 4 * Screen.height / 5 + 50, 27, 27), scout, ScaleMode.ScaleToFit, true, 0);



    }
}
