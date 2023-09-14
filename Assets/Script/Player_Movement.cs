using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField]
    private Transform Player;
    [SerializeField]
    private float Movement_speed = 10;

    public float Health;

    [SerializeField]
    private Transform Enemy;

    [SerializeField]
    private Health_register HR;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Health_go(1);
        if (Input.GetKey(KeyCode.W))
        {
            print("You are pressing W!");
            float x = Player.localPosition.x + Movement_speed * Time.deltaTime;
            float y = (Player.localPosition.y);
            float z = (Player.localPosition.z);
            Vector3 pos = new Vector3(x, y, z);
            Player.position = pos;
            print(" X: " + x + " Z: " + z);
            // print("PlayerPosition" + pos);
        }

        if (Input.GetKey(KeyCode.S))
        {
            print("You are pressing S!");
            float x = Player.localPosition.x - Movement_speed * Time.deltaTime;
            float y = (Player.localPosition.y);
            float z = (Player.localPosition.z);
            Vector3 pos = new Vector3(x, y, z);
            Player.position = pos;
            // print(" X: " + x + " Z: " + z);
            //print("PlayerPosition" + pos);
        }

        if (Input.GetKey(KeyCode.A))
        {
            print("You are pressing A!");
            float x = Player.localPosition.x;
            float y = (Player.localPosition.y);
            float z = (Player.localPosition.z + Movement_speed * Time.deltaTime);
            Vector3 pos = new Vector3(x, y, z);
            Player.position = pos;
            // print(" X: " + x + " Z: " + z);
            //print("PlayerPosition" + pos);
        }
        if (Input.GetKey(KeyCode.D))
        {
            print("You are pressing D!");
            float x = Player.localPosition.x;
            float y = (Player.localPosition.y);
            float z = (Player.localPosition.z) - Movement_speed * Time.deltaTime;
            Vector3 pos = new Vector3(x, y, z);
            Player.position = pos;
            // print(" X: " + x + " Z: " + z);
            //print("PlayerPosition" + pos);
        }

       

        {
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
       
        print("Attacked");
        HR.Health_point(1);
    }
    private void Health_go( float damage)
    {
      if (Input.GetKey(KeyCode.Space))
        {
            HR.Health_point(1);
        }
        
    }
} 
