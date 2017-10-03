using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour{

    float x;
    float y;
    float z = 1;

    void Update()
    {
        x = Input.mousePosition.x;
        y = Input.mousePosition.y;
        z = 1;
    }

    void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(x, y, z));
    }
}
