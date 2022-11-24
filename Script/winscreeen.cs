using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winscreeen : MonoBehaviour
{
    public GameObject winScreen;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            winScreen.SetActive(true);
        }
    }
    private void Start()
    {
        winScreen.SetActive(false);
    }
}
