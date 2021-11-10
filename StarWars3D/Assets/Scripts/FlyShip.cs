using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyShip : MonoBehaviour
{
    public GameObject ship;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        /*
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        */
    }

    // Update is called once per frame
    void Update()
    {
        ship.transform.Rotate(Input.GetAxis("Mouse Y") * -1, Input.GetAxis("Mouse X"), 0);
        gameObject.transform.Translate(0, 0, 1f);
    }
}
