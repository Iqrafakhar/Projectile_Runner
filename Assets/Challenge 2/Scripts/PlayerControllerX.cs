using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float startDelay = 2.0f;
    private float endtime = 2.0f;
    void Start()
	{
		InvokeRepeating("dogRandomSpawn", 1,5);	
	}
    // Update is called once per frame
    void dogRandomSpawn()
    {
        // On spacebar press, send dog
	if (Input.GetKeyDown(KeyCode.Space))
		{ 
		    Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);         
		}
    }
}
