using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class final : MonoBehaviour
{
    [SerializeField]
    private GameObject skull, credit, Direction;
    private float timestart = 5;
    private int a;
    [SerializeField]
    Text directionText;

    private void Update()
    {
        if (a==1)
        {
            timestart -= Time.deltaTime;
            if(timestart <= 0)
            {
                credit.SetActive(true);
                skull.SetActive(false);
            }
        }
    }
    private void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.CompareTag("Player"))
        {
            Direction.SetActive(false);
            skull.SetActive(true);
            a = 1;
            directionText.text = "Hope You Survived!!!";
        }
    }
}
