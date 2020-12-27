using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room1r : MonoBehaviour
{
    public Transform player;
    public Transform room;

    public Vector2 doorPos;


    void Update()
    {
        doorPos = new Vector2(room.position.x + 20, room.position.y);
    }
   

    void OnTriggerEnter2D(Collider2D Wall)
    {
       

        if (Mathf.Abs(player.position.x - doorPos.x) < 50  && Mathf.Abs(player.position.y - doorPos.y) < 50)
        {
            Wall.enabled = false;
        }
        else
        {
            Wall.enabled = true;
        }
    }
}
