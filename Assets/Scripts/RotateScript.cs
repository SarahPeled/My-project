using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public bool useFixedUpdate;
    public Mesh newMesh;
    // Start is called before the first frame update
    void Start()
    {
        MeshFilter meshF =
            gameObject.GetComponent<MeshFilter>();
        meshF.mesh = newMesh;
        GameObject sphere = GameObject.Find("Sphere");
        MeshFilter sphereMesh =
               sphere.GetComponent<MeshFilter>();
        sphereMesh.mesh = newMesh;
        MeshRenderer mr =
            sphere.GetComponent<MeshRenderer>();
        //enabling for components
        mr.enabled = true;
        // enabling for GameObjects
        sphere.SetActive(true);
           

        
    }

    // Update is called once per frame
    void Update()
    {
        if (!useFixedUpdate)
        {
            transform.Rotate(1f, 1f, 1f);
        }
    }

    void FixedUpdate()
    {
        if (useFixedUpdate)
        {
            transform.Rotate(1f, 1f, 1f);
        }
    }


}
