using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Encostando em outro objeto");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enconstou no trigger");
    }
}
