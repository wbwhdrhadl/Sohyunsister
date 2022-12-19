using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingWindow_Controller : MonoBehaviour
{
    public GameObject WindowPivot;

    private void OnTriggerEnter(Collider other)
    {
        WindowPivot.GetComponent<Animator>().SetInteger("State", 1);
    }

    private void OnTriggerExit(Collider other)
    {
        WindowPivot.GetComponent<Animator>().SetInteger("State", 2);
    }
}
