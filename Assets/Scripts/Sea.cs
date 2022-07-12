using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sea : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && other.GetComponent<Animator>().GetBool("Fall") == false)
        {
            if(SceneManager.GetActiveScene().name == "FristDeathCutScene")
            {
                return;
            }
            other.GetComponent<Animator>().SetBool("Fall", true);
            other.GetComponent<ThirdPersonController>().setIsFalling(true);
            Invoke("ReloadScenre", 2f);
            //other.transform.position = other.transform.position - pos;
        }
        if (other.CompareTag("Sekelton"))
        {
            gameObject.GetComponent<BoxCollider>().isTrigger = false;
            if (other.GetComponentInParent<PopUps>().moveOnWater == false)
            {
                other.GetComponentInParent<PopUps>().moveOnWater = true;
            }
        }
    }
    void ReloadScenre()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
