using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeny : MonoBehaviour
{
    // Start is called before the first frame update
    MoneyBag bag;
    [SerializeField] AudioClip[] moeny;
    [SerializeField] int amount =10;
    void Start()
    {
        bag = FindObjectOfType<MoneyBag>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int random = Random.Range(0, moeny.Length - 1);
            bag.AddMoney(amount, moeny[random]);
            gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
