using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CharSwitch : MonoBehaviour
{
    [SerializeField] Transform[] chars;
    public int currentChar = 0;
    [SerializeField] CinemachineVirtualCamera cam;
    [SerializeField] Transform sekeltonSpawnPos;
    Transform GhostSpawnPos;
    [SerializeField] GameObject Pause;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in chars)
        {
            item.gameObject.SetActive(false);
        }
        chars[0].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            SwitchToNextChar("PlayerCameraRoot");
        }
        if (Input.GetKeyDown(KeyCode.Escape)) 
          {
            Pause.gameObject.SetActive(!Pause.active);
          }
        }

    public void SwitchToNextChar(string camName)
    {
        chars[currentChar].gameObject.SetActive(false);
        currentChar++;
        if(currentChar == 0)
        {
            chars[currentChar].transform.position = sekeltonSpawnPos.position;
        }
        cam.Follow = chars[currentChar].Find(camName);
        if(currentChar ==1)
        {
            chars[currentChar].transform.position = chars[0].transform.position;
        }
        chars[currentChar].gameObject.SetActive(true);
    }
}
