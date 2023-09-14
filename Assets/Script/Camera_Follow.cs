using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    //public Vector3 offset = new Vector3(0, 2, -10);
    public float height = 2;
    public float depth = -10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(
        target.position.x, height, depth);
       
    }
}
