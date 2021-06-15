using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("PlaySound");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator PlaySound()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(10, 20));
            GetComponent<AudioSource>().Play();
        }
    }
}
