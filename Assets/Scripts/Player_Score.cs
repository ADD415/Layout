using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour
{

    public UIManager uimanager;

    void OnTriggerEnter2D (Collider2D trig)
    {

        if (trig.gameObject.CompareTag("Coin"))
        {
            uimanager.Score_increase();
            Destroy(trig.gameObject);
        }
    }
}  
