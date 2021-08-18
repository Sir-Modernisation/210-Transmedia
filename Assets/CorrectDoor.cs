using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectDoor : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            door1.SetActive(false);
            door2.SetActive(false);
            door3.SetActive(false);
            
        }
    }

}
