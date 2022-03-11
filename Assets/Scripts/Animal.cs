using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    private float speed = 3;
    public float Speed{
        get{
            return speed;
        }
        set {
            if (value < 0){
                speed = -value;
            } else {
                speed = value;
            }
        }
    }
    private protected Rigidbody _animalRb;
    private protected Animator _animalAnim;
    // Start is called before the first frame update
    void Start()
    {
        _animalRb = GetComponent<Rigidbody>();
        _animalAnim = GetComponent<Animator>();
        _animalAnim.SetInteger("Walk", 1);
        AssignRandomDirection();

        StartCoroutine(RepeatActions());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
    }
    private void OnCollisionEnter(Collision other){
        if(!other.gameObject.CompareTag("Ground")){
            AssignRandomDirection();
        }
    }
    private void AssignRandomDirection(){
        float newOrientation = transform.rotation.y + 180 + Random.Range(-90,90);
        transform.Rotate(new Vector3(0, newOrientation, 0));
    }
    // EACH ANIMAL MUST HAVE ITS ACTION
    protected abstract void DoAction();

    IEnumerator RepeatActions(){
        while(true){
            // randomly do action
            if (Random.Range(0,10) < 5){
                DoAction();
            }
            yield return new WaitForSeconds(2.5f);

            // also randomly turn
            if (Random.Range(0,10) < 5){
                AssignRandomDirection();
            }
            yield return new WaitForSeconds(2.5f);
        }
    }
}
