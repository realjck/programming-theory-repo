using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCameraControl : MonoBehaviour
{
    [SerializeField] private float speed;
    // Update is called once per frame
    void Update()
    {
        // rotate with Horizontalinput:
        transform.Rotate(0,speed * Time.deltaTime * -Input.GetAxis("Horizontal"),0);
    }
}
