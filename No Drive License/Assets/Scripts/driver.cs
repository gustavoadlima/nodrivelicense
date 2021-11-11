using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver : MonoBehaviour
{
    [SerializeField] float translateVelocity = 10f;
    [SerializeField] float rotateVelocity = 200f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xRotate = -(Input.GetAxis("Horizontal") * Time.deltaTime * rotateVelocity);
        float yTranslate = Input.GetAxis("Vertical") * Time.deltaTime * translateVelocity;
        transform.Rotate(0, 0, xRotate);
        transform.Translate(0, yTranslate, 0);
    }

}
