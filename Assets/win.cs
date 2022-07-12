using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    CharSwitch switcher;
    // Start is called before the first frame update
    void Start()
    {
        switcher = FindObjectOfType<CharSwitch>();
    }

    // Update is called once per frame
    void Update()
    {
        if(switcher.currentChar == 0)
        {
            GetComponent<BoxCollider>().isTrigger = false;
        }
        else if (switcher.currentChar == 1)
        {
            GetComponent<BoxCollider>().isTrigger = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.GetComponentInParent<MoneyBag>().GetMoney() >= 70)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        
    }
    
}
