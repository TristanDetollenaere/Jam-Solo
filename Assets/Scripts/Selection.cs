using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
    public GameObject fadein;

    private void Start()
    {
        StartCoroutine(Waiting());
    }
        
    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(1);
        fadein.SetActive(false);
    }
}

