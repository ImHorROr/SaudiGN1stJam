using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killSekelton : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Sekelton"))
        {
            return;
        }
        other.GetComponent<Health>().RemoveHealth();
        if (other.GetComponent<Health>().GetHealth() <= 0)
        {
            other.GetComponentInParent<CharSwitch>().SwitchToNextChar("PlayerCameraRoot");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", 2f);
    }
    void Destroy()
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
