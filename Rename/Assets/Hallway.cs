using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallway : MonoBehaviour
{
    public Transform player;
    public Transform Hall;
    public Rigidbody2D hallrb;


    Vector2 doorPos1;
    public Vector2 doorPos2;

    void Update()
    {
        doorPos1 = new Vector2(Hall.position.x + 10, Hall.position.y);
        doorPos2 = new Vector2(Hall.position.x + -10, Hall.position.y);

        if ((Mathf.Abs(doorPos1.x - player.position.x) < 2) && (Mathf.Abs(doorPos1.y - player.position.y)) < 4)
        {
            hallrb.simulated = false;
        }
        if ((Mathf.Abs(doorPos2.x - player.position.x) < 2) && (Mathf.Abs(doorPos2.y - player.position.y)) < 4)
        {
            hallrb.simulated = false;
        }
        else
        {
            hallrb.simulated = true;
        }
    }
}
