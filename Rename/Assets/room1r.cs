using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room1r : MonoBehaviour
{
    public Transform player;
    public Transform room;
    public Rigidbody2D roomrb;
    public Vector2 doorPos;


    void Update()
    {
        doorPos = new Vector2(room.position.x + 10, room.position.y);

        if ((Mathf.Abs(doorPos.x - player.position.x) < 2) && (Mathf.Abs(doorPos.y - player.position.y)) < 4 )
        {
            roomrb.simulated = false;
        }
        else
        {
            roomrb.simulated = true;
        }
    }
   

    
       

        
        
        
    

    
}
