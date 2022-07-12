using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] Transform dialoguePanle;
    public string[] lines;
    public float textSpeed;
    private int index;

    private void Start()
    {
        if (text == null) return;
        text.text = string.Empty;
        dialoguePanle.gameObject.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (text.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                text.text = lines[index];
            }
        }
    }
    public void StartDialogue()
    {
        text.text = string.Empty;

        index = 0;
        dialoguePanle.gameObject.SetActive(true);
        //Cursor.lockState = CursorLockMode.None;

        StartCoroutine(Type());
    }
    public void NextLine()
    {
        if (index < lines.Length - 1)
        {

            index++;
            text.text = string.Empty;
            StartCoroutine(Type());
        }
        else
        {
            dialoguePanle.gameObject.SetActive(false);
          //  Cursor.lockState = CursorLockMode.Locked;
        }
    }
    IEnumerator Type()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            text.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
}
