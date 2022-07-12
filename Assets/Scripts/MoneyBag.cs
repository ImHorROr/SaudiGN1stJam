using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyBag : MonoBehaviour
{
    int money;
    [SerializeField] TextMeshProUGUI currentMoney;
    private void Start()
    {
        UpdateUI();

    }
    public void AddMoney(int i , AudioClip clip)
    {
        money += i;
        AudioSource source = GetComponent<AudioSource>();
        source.PlayOneShot(clip);
        UpdateUI();
        if(money >= 70)
        {
            if(GetComponent<PopUps>().leave == false)
            {
                GetComponent<PopUps>().leave = true;
            }
        }
    }

    private void UpdateUI()
    {
        currentMoney.text = GetMoney().ToString();
    }

    public int GetMoney()
    {
        return money;
    }
}
