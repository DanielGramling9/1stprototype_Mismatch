using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    //public Vector3 offset = new Vector3(0, 2, -10);
    // public float height = 2;
    //  public float depth = -10;
    public Vector3 offset = new Vector3(-20, 20, -20);
    void Start()
    {
        transform.rotation = Quaternion.Euler(35.264f, 45f, 0);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //  transform.position = new Vector3(
        // target.position.x, height, depth);
        Vector3 target = new Vector3(player.position.x, 0, player.position.z) + offset;
        transform.position = target;
    }
}
