using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public GameObject TriggerAudio;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TriggerAudio.SetActive(true);
        }
    }
}
