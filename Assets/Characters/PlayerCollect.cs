using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    public int NumberOfItems {get; private set;}
	
	public void ItemCollected()
	{
	    NumberOfItems++;
	}
}