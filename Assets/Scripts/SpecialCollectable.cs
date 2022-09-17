using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialCollectable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<PlayerController>().score+=5;

        Destroy(gameObject);
    }

    void FixedUpdate()
    {
        transform.Rotate(1f, 1f, 1f);
    }

}
