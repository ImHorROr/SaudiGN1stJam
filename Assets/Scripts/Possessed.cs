using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using Cinemachine;

public class Possessed : MonoBehaviour
{
    Animator animator;
    Collider charToPoss;
    [SerializeField] ParticleSystem particle;
    [SerializeField] GameObject instctions;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    //[SerializeField] UnityEvent possesd;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Girl") || other.CompareTag("Player"))
        {
            //SetUIText(textToWrite);
            //instctions.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {

                if (GetComponentInParent<PopUps>().posPirateBody == false && other.CompareTag("Player"))
                {
                    GetComponentInParent<PopUps>().posPirateBody = true;
                }
                charToPoss = other;
                transform.LookAt(charToPoss.transform);
                animator.SetTrigger("Poss");
                particle.Play();
                //Possess(other);

            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //instctions.SetActive(false);
    }
    public void Possess()
    {
        // possesd.Invoke();
        gameObject.SetActive(false);
        charToPoss.GetComponent<PlayerInput>().enabled = true;
        charToPoss.GetComponent<ThirdPersonController>().enabled = true;
        charToPoss.TryGetComponent<girl>(out girl girlo);
        if (girlo)
        {
            girlo.SetPoss(true);
        }
        Transform cam = charToPoss.transform.Find("PlayerCameraRoot");
        FindObjectOfType<CinemachineVirtualCamera>().m_Follow = cam;
    }
}
