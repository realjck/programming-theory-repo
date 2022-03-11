using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Lion : Animal
{
    // POLYMORPHISM
    private float speedBackup;
    protected override void DoAction()
    {
        // lion sleeps 2.5 seconds
        speedBackup = Speed;
        Speed = 0;
        _animalAnim.SetInteger("Walk",0);
        StartCoroutine(WaitForWakeUp());
    }
    IEnumerator WaitForWakeUp(){
        yield return new WaitForSeconds(2.5f);
        Speed = speedBackup;
        _animalAnim.SetInteger("Walk",1);
    }
}
