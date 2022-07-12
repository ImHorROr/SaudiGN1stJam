using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessLand : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sekelton"))
        {
            if (other.GetComponentInParent<PopUps>().goToPrinceLand == false)
            {
                other.GetComponentInParent<PopUps>().goToPrinceLand = true;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
