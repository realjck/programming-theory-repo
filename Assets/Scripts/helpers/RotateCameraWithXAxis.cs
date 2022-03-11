using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCameraWithXAxis : MonoBehaviour
{
    [SerializeField] private float speed;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,speed * Time.deltaTime * -Input.GetAxis("Horizontal"),0);
    }
}
