using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerVol : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void OnEnable()
    {
       // StartCoroutine(Lower());
    }
    //IEnumerator Lower()
    //{
    //    //while (true)
    //    //{
    //    //    audio.volume = Mathf.Lerp(0, 1,1);
    //    //    yield return new WaitForSeconds(2f);
    //    //}
    //}
    // Update is called once per frame
    void Update()
    {
        
    }
}
