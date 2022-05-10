using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle : MonoBehaviour
{

    public GameObject Player;
    public float movementSpeed = 10f;

    private float maxAngle = 15f;
    private Vector3 playerStartPos;

   void Update()
    {
        if (Input.GetKey(KeyCode.Q)) transform.Rotate(new Vector3(movementSpeed * Time.deltaTime, 0f, 0f));
        if (Input.GetKey(KeyCode.D)) transform.Rotate(new Vector3(-movementSpeed * Time.deltaTime, 0f, 0f));
        if (Input.GetKey(KeyCode.S)) transform.Rotate(new Vector3 (0f, 0f, movementSpeed * Time.deltaTime));
        if (Input.GetKey(KeyCode.Z)) transform.Rotate(new Vector3(0f, 0f, - movementSpeed * Time.deltaTime));
        if (Input.GetKeyDown(KeyCode.Space)) resetMaze();

    }

    void Start()
    {
        playerStartPos = Player.transform.position;



    }

    public void resetMaze()
    {
        
        transform.rotation = Quaternion.identity;
        Player.transform.position = playerStartPos;
        Player.GetComponent<Rigidbody>().velocity = Vector3.zero;   

    }
  
}
