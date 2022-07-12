using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoundPrincess : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sekelton"))
        {
            if (other.GetComponentInParent<PopUps>().posBody == false)
            {
                other.GetComponentInParent<PopUps>().posBody = true;
            }
        }
    }
    // Start is called before the first frame update

}
