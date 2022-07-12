using StarterAssets;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class girl : MonoBehaviour
{
    [SerializeField] GameObject Ghost;
    [SerializeField] GameObject pirate;
    [SerializeField] GameObject instctions;
    [SerializeField] Transform spawnPos;


    [SerializeField] UnityEvent spawnBody;
    [SerializeField] UnityEvent LeaveGirl;
    [SerializeField] ParticleSystem particle;
    
    bool hasPossessedGirl = false;
    Animator animator;

    private int animIDSpeed;


    public bool canSpawn =false;
    public bool closeToSpawnPos = false;
    PopUps pop;
    // Start is called before the first frame update
    public void setCanSpawn()
    {
        canSpawn = true;
    }
    public void setCloseCanSpawn()
    {
        closeToSpawnPos = true;
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
        pop = FindObjectOfType<PopUps>();
        //pirate.gameObject.SetActive(false);
    }
    public void SetPoss(bool newState)
    {
        hasPossessedGirl = newState;
        if (hasPossessedGirl == true)
        {
            particle.Play();
            //instctions.SetActive(true);
            if (pop.posBody == false)
            {
                pop.posBody = true;

            }

        }
        else
        {
            particle.Stop();
            //instctions.SetActive(false);
        }
    }
    public void SpawnBody()
    {
        if (canSpawn == false) return;
        if (closeToSpawnPos == false) return;
        spawnBody?.Invoke();
        //pirate.transform.position = spawnPos.position;
        if (pop.spawnBody == false)
        {
            pop.spawnBody = true;

        }
        pirate.gameObject.SetActive(true);
        pirate.transform.position = spawnPos.position;
        Debug.Log("Here");
        animator.ResetTrigger("StartMagic");

    }
    public void PlayEffect(ParticleSystem sys)
    {
        Instantiate(sys);
        sys.gameObject.transform.position = spawnPos.position;
        sys.Play();
    }
 
    void Update()
    {
        if (hasPossessedGirl == false) return;
        //SetUIText(textToWrite);
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("StartMagic");

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<PlayerInput>().enabled = false;
            GetComponent<ThirdPersonController>().enabled = false;

            animator.SetFloat(Animator.StringToHash("Speed"), 0);
            animator.SetFloat(Animator.StringToHash("MotionSpeed"), 0);
            animator.SetBool("FreeFall", false);
            animator.SetBool("Jump" , false);
            Ghost.SetActive(true);
            Ghost.transform.position = transform.position;
            Ghost.GetComponent<Animator>().ResetTrigger("Poss");
            Ghost.GetComponent<Animator>().SetTrigger("Leave");
            LeaveGirl?.Invoke();
            SetPoss(false);
            Ghost.GetComponent<Animator>().ResetTrigger("Leave");
        }


    }
}
