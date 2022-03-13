using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Pixelation.Scripts;

public class CameraPressB : MonoBehaviour
{
    private bool isBWenabled;
    private Chunky chunkyEffect;
    // Start is called before the first frame update
    void Start()
    {
        chunkyEffect = GetComponent<Chunky>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B)){
            chunkyEffect.enabled = !isBWenabled;
            isBWenabled = !isBWenabled;
        }
    }
}
