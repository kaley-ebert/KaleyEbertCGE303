using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOnFall : MonoBehaviour
{
    //Set this in the inspector
    public float lowestY;

    // Update is called once per frame
    void Update()
    {
        //If the player is lower than the lowestY...
        if (transform.position.y < lowestY)
        {
            //make player lose
            ScoreManager.gameOver = true;
        } 
    }
}
