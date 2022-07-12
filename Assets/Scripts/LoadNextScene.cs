using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }
    private void OnEnable()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.CompareTag("Player"))
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //}
    // Update is called once per frame
    void Update()
    {
        
    }
}
