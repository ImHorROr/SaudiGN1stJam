using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicPotion : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Girl") && Input.GetKeyDown(KeyCode.Q))
        {
            other.GetComponent<girl>().setCanSpawn();
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Girl") && Input.GetKeyDown(KeyCode.Q))
        {
            other.GetComponent<girl>().setCanSpawn();
            gameObject.SetActive(false);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
