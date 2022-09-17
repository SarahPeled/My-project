using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScript : MonoBehaviour
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
        other.gameObject.GetComponent<PlayerController>().score++;
        Destroy(gameObject);
    }

    void FixedUpdate()
    {
        transform.Rotate(1f, 1f, 1f);
    }
}
