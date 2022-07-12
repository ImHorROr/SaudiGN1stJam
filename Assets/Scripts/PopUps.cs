using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUps : MonoBehaviour
{
    [SerializeField] GameObject[] helpPopUps;
    int currentUI =0;
    public bool moveOnWater =false;
    public bool goToPrinceLand = false;
    public bool getKilled = false;
    public bool posBody = false;
    public bool spawnBody = false;
    public bool posPirateBody = false;
    public bool collectMoney = false;
    public bool leave = false;

    bool[] hasPlayed = new bool[8];
    void Start()
    {
        foreach (var item in helpPopUps)
        {
            item.gameObject.SetActive(false);
        }
        if (helpPopUps[currentUI] != null)
        {
            helpPopUps[currentUI].gameObject.SetActive(true);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        if(hasPlayed[0] == false)
        {
            if (moveOnWater == true)
            {
                hasPlayed[0] = true;
                Invoke("TurnOff", 2f);
            }
        }
        if (hasPlayed[1] == false)
        {
            if (goToPrinceLand == true)
            {
                hasPlayed[1] = true;
                Invoke("TurnOff", 2f);
            }
        }
        if (hasPlayed[2] == false)
        {
            if (getKilled == true)
            {
                hasPlayed[2] = true;
                Invoke("TurnOff", 2f);
            }
        }
        if (hasPlayed[3] == false)
        {
            if (posBody == true)
            {
                hasPlayed[3] = true;
                Invoke("TurnOff", 2f);
            }
        }
        if (hasPlayed[4] == false)
        {
            if (spawnBody == true)
            {
                hasPlayed[4] = true;
                Invoke("TurnOff", 2f);
            }
        }
        if (hasPlayed[5] == false)
        {
            if (posPirateBody == true)
            {
                hasPlayed[5] = true;
                Invoke("TurnOff", 2f);
            }
        }
        if (hasPlayed[6] == false)
        {
            if (collectMoney == true)
            {
                hasPlayed[6] = true;
                Invoke("TurnOff", 2f);
            }
        }
        if (hasPlayed[7] == false)
        {
            if (leave == true)
            {
                hasPlayed[7] = true;
                Invoke("TurnOff", 2f);
            }
        }
    }
    void TurnOff()
    {
        helpPopUps[currentUI].SetActive(false);
        currentUI++;
        Invoke("TurnOn", 2f);

    }
    void TurnOn()
    {
        helpPopUps[currentUI].SetActive(true);
    }

}
