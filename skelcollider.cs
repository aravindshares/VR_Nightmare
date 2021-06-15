using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skelcollider : MonoBehaviour
{
    [SerializeField]
    private GameObject skeleton;
    [SerializeField]
    Text directionText;
    private void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.CompareTag("Player"))
        {
            skeleton.SetActive(true);
            directionText.text = "Reach the Temple Arch";
        }
    }
}
