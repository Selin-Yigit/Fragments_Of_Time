using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        PlayerCollect playerCollect = other.GetComponent<PlayerCollect>();
		
		if(playerCollect != null)
		{
		    playerCollect.ItemCollected();
			gameObject.SetActive(false);
		}
    }
}

/* Bu script Toplanacaklara ekleniyor*/