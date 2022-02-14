using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = 30;
    private float bottomLimit = -20;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x > leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.x < bottomLimit)
        {
            Destroy(gameObject);
        }
	/*else if(transform.position.y > topLimit)
	{
	    Destroy(gameObject);
	}
	else if(transform.position.y > downLimit)
	{
	    Destroy(gameObject);
	}*/

    }
}
