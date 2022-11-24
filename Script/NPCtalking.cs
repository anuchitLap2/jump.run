using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCtalking : MonoBehaviour
{
    public GameObject PressEui;
    public GameObject TEXTNPCza;
    public bool isnear=false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isnear=true;
            PressEui.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isnear=false;
            PressEui.SetActive(false);
        }
    }
    private void Update()
    {
        if (isnear)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                TEXTNPCza.SetActive(true);
                Invoke("hidetext", 3);
            }
        }
    }
    public void hidetext()
    {
        TEXTNPCza?.SetActive(false);
    }
    private void Start()
    {
        PressEui.SetActive(false);
    }
}
