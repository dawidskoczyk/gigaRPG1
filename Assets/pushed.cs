using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class pushed : MonoBehaviour
{
    [SerializeField] private Transform kordy;
    [SerializeField] private Transform boxkordy;

    float dysx;
    float dysy;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            dysx = kordy.position.x - boxkordy.position.x;
            dysy = kordy.position.y - boxkordy.position.y;
        }
        
        if (Input.GetKey(KeyCode.E))
        {
        boxkordy.position = new Vector3(kordy.position.x - dysx, kordy.position.y - dysy, boxkordy.position.z);

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //if (Input.GetKey(KeyCode.E))
            //{
               // boxkordy.position = new Vector3(kordy.position.x+5, kordy.position.y+5, boxkordy.position.z);

            //}

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
