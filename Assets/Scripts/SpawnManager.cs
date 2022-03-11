using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instance;
    [SerializeField] private GameObject[] animals;
    [SerializeField] private float boundX;
    [SerializeField] private float boundZ;
    [SerializeField] private ParticleSystem poofer;
    void Awake(){
        if (Instance != null){
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    public void InstantiateAnimal(int index){
        // place animal in world
        Vector3 randomPos = new Vector3(Random.Range(-boundX,boundX), 0, Random.Range(-boundZ, boundZ));
        Instantiate(animals[index], randomPos, animals[index].transform.rotation);
        // poof particles
        Instantiate(poofer, randomPos + Vector3.up, poofer.transform.rotation);
        poofer.Play();
    }
}
