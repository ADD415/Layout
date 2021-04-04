using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Player playerTemplate;
    public Player playerDamaged;
    public Player playerSpine;
    public Player playerRibs;
    public Player playerArm;
    public Player playerBothArms;
    public int value = 1;

    void Start()
    {
        //spawnPlayer();
        if (value <= 1)
        {
            spawnPlayer();
        }
        else if  (value >=2)
        {
            spawnPlayerRibs();
        }
    }

  
    public void spawnPlayer()
    {
        Player playerClone = Instantiate(playerTemplate);

        playerClone.transform.position = transform.position;   

        playerClone.gameObject.SetActive(true);
    }

    public void spawnPlayerDamaged()
    {
        Player playerClone = Instantiate(playerDamaged);

        playerClone.transform.position = transform.position;

        playerClone.gameObject.SetActive(true);
    }

    public void spawnPlayerSpine()
    {
        Player playerClone = Instantiate(playerSpine);

        playerClone.gameObject.SetActive(true);
    }

    public void spawnPlayerRibs()
    {
        Player playerClone = Instantiate(playerRibs);

        playerClone.gameObject.SetActive(true);
    }

    public void spawnPlayerArm()
    {
        Player playerClone = Instantiate(playerArm);

        playerClone.gameObject.SetActive(true);
    }

    public void spawnPlayerBothArms()
    {
        Player playerClone = Instantiate(playerBothArms);

        playerClone.gameObject.SetActive(true);
    }

    public void ValueIncrease()
    {
        value++;
        print(value);
    }

    public void CheckValue()
    {
        if (value <= 1  )
        {
            spawnPlayerDamaged();
        }
        else
        {
            spawnPlayerSpine();
        }
    }
}
