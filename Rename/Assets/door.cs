using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public Transform room;
    public Rigidbody2D rbP;
    public Vector2 Entry = (room.x + 19, room.y);
    

    void OnTriggerEnter2D()
    {
       
    }
}
