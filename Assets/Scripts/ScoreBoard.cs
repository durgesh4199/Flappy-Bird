using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] Text player_Score_Text;
    private int player_Score = 0;
    private bool CanAbleToAddScore = true;
    // Start is called before the first frame update
    void Start()
    {
             
    }
    private void FixedUpdate()
    {      
        if (CanAbleToAddScore == true)
        {
            StartCoroutine(ScorePerSec());
            CanAbleToAddScore = false;
        }
    }
    void Update()
    {
        player_Score_Text.text = "Score - 0" + (player_Score.ToString());
    }
    IEnumerator ScorePerSec()
    {
        player_Score += 1;
        yield return new WaitForSeconds(1);
        CanAbleToAddScore = true;
    }
}
