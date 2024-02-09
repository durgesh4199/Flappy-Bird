using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionPipe : MonoBehaviour
{
    private SManager sceneMCode;
    // Start is called before the first frame update
    void Start()
    {
        sceneMCode = GameObject.Find("SceneManager").GetComponent<SManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            sceneMCode.PlayerIsDead();
            Destroy(other.gameObject);
        }
    }
}
