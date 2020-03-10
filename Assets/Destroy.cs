using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Destroy : MonoBehaviour
{
    public Text textConta;
    int numEnem;
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Player") {
            Destroy(collision.gameObject);
            numEnem++;
            textConta.text = numEnem.ToString();

        }
    }
}
