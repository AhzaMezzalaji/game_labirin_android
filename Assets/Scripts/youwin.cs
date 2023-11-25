using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youwin : MonoBehaviour
{
    public GameObject panel;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            panel.SetActive(true);
        }
    }
}
