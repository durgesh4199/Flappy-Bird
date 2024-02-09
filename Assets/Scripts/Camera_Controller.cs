using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    private Vector3 outBound = new Vector3(-7, 0, 0);
    private GameObject playerGB;
    // Start is called before the first frame update
    void Start()
    {
        
        playerGB = GameObject.Find("Player");
       
    }

    // Update is called once per frame
    void Update()
    {
        if(playerGB != null)
        {
            transform.position = new Vector3(playerGB.transform.position.x, playerGB.transform.position.y, transform.position.z) - outBound;
        }       
        if(transform.position.y < 0.4 || transform.position.y > 0.4)
        {
            transform.position = new Vector3(transform.position.x, 0.4f, transform.position.z);
        }
    }
}
