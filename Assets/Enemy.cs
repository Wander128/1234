using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Enemigo;
    float Counter;
    public float emision = 0.5f;
    public float MinR = -8;
    public float MaxR = 8;

    Vector3 rangoRandom;
    void Update()
    {
        Counter = Counter + Time.deltaTime;
        if (Counter > emision) {
            Counter = 0;
            rangoRandom = new Vector3(Random.Range(MinR, MaxR), transform.position.y, 
                transform.position.z);
            Instantiate(Enemigo, rangoRandom, transform.rotation);
            Instantiate(Enemigo, rangoRandom + new Vector3(1,1,0),transform.rotation);
            Instantiate(Enemigo, rangoRandom + new Vector3(2,0,0), transform.rotation);
        }
    }
}