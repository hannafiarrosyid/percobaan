using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    int hits = 0;
    private void  OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "player")
        {
            hits++;
            Debug.Log("anda terbentur:" + hits); 
        }
    }
}
