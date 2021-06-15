using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightGate : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    [SerializeField]
    GameObject gateSound;
    AudioSource gate;
    // Start is called before the first frame update
    void Start()
    {
        gate = gateSound.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.CompareTag("Player"))
        {
            animator.SetBool("right", true);
            gate.Play();
        }
    }
    private void OnTriggerExit(Collider col)
    {

        if (col.gameObject.CompareTag("Player"))
        {
            animator.SetBool("right", false);
            gate.Play();
        }
    }
}
