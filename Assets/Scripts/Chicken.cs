using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal
{
    protected override void DoAction()
    {
        // chicken jumps
        _animalRb.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }
}
