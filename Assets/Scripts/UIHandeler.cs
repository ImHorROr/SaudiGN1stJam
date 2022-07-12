using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIHandeler : MonoBehaviour
{
    [SerializeField] GameObject[] popUps;
    bool moved;
    bool talkToSomeone;
    int currentUI=0;
    [SerializeField] DIalogueTrigger ialogueTrigger;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && moved == false)
        {
            moved = true;
            Invoke("TurnOff",2f);
        }
        if (talkToSomeone == false && ialogueTrigger.GetHasReadIt() == true)
        {
            talkToSomeone = true;
            Invoke("TurnOff", 2f);

        }
    }
    void TurnOff()
    {
        popUps[currentUI].SetActive(false);
        currentUI++;
        Invoke("TurnOn", 2f);

    }
    void TurnOn()
    {
        popUps[currentUI].SetActive(true);
    }

}
