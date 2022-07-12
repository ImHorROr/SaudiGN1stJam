using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIalogueTrigger : MonoBehaviour
{
    bool hasReadIt;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && hasReadIt == false)
        {
            hasReadIt = true;
            GetComponent<Dialogue>().StartDialogue();
        }
    }
    public bool GetHasReadIt()
    {
        return hasReadIt;
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
