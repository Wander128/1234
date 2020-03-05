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

    void Start()
    {
    }

    void Update()
    {
        Counter = Counter + Time.deltaTime;
        if (Counter > emision)
        {
            Counter = 0;
            rangoRandom = new Vector3(transform.position.x, transform.position.y,
            Random.Range(MinR, MaxR));
            Instantiate(Enemigo, rangoRandom, transform.rotation);
        }

    }
}