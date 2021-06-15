using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{
    public GameObject sound, light1, light2, light3, light4, bulb1, bulb2, bulb3, bulb4;  
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Instantiate(sound);
            Destroy(light1);
            Destroy(light2);
            Destroy(light3);
            Destroy(light4);
            Destroy(bulb1);
            Destroy(bulb2);
            Destroy(bulb3);
            Destroy(bulb4);
            this.GetComponent<BoxCollider>().enabled = false;
        }
    }
}

