using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SManager : MonoBehaviour
{
    public bool IsPlayerDead = false;
    private Player_Controller playerCode;
    // Start is called before the first frame update
    void Start()
    {
        if(playerCode != null)
        {
            playerCode = GetComponent<Player_Controller>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsPlayerDead == true)
        {
            IsPlayerDead = false;
            SceneManager.LoadScene(0); 
   
        }
    }
    public void PlayerIsDead()
    {
        IsPlayerDead = true;
    }
}
