using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public float moveSpeed = 3.0f;
    [SerializeField]
    private Transform player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            // Handle the case where the player is not found (destroy, stop, or other behavior)
            return;
           
        }
        Vector3 directionToPlayer = player.position - transform.position;
        directionToPlayer.Normalize();
        transform.Translate(directionToPlayer * moveSpeed * Time.deltaTime);
    }
}
