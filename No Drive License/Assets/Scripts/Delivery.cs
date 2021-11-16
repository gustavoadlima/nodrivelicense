using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool isPackageCollect = false;
    [SerializeField] float timeToDestroy = 0.2f;
    [SerializeField] Color32 carFullColor = new Color32();
    [SerializeField] Color32 carEmptyColor = new Color32();
    private SpriteRenderer spriterenderer;
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
    }
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "spot" && isPackageCollect)
        {
            Debug.Log("Delivery");
            isPackageCollect = false;
            spriterenderer.color = carEmptyColor;
        }
        if(collision.tag == "Package" && !isPackageCollect)
        {
            Debug.Log("Collect");
            isPackageCollect = true;
            Destroy(collision.gameObject, timeToDestroy);
            spriterenderer.color = carFullColor;
        }
    }
}
