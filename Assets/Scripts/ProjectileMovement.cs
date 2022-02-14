using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    [SerializeField] float InitialVelocity;
    [SerializeField] float Angle;
    [SerializeField] LineRenderer Line;
    [SerializeField] float step;


     // Update is called once per frame
    private void Update()
    {
        float angle = Angle * Mathf.Deg2Rad;
        DrawPath(InitialVelocity, angle, step);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StopAllCoroutines();
            StartCoroutine(Coroutine_Movment(InitialVelocity, angle));
        }
    }
    IEnumerator Coroutine_Movment(float initial_velocity, float angle)
    {
        float t = 0;
        while(t < 100)
        {
            float x = initial_velocity * t * Mathf.Cos(angle);
            float y = initial_velocity * t * Mathf.Sin(angle) - (1f/2f) * -Physics.gravity.y * Mathf.Pow(t,2);
            transform.position = new Vector3(x , y , transform.position.z);
            t += Time.deltaTime;
            yield return null;
        }
    }

    private void DrawPath(float initialvelocity, float angle,  float step )
    {
        step =Mathf.Max(0.01f, step);
    //tie at which the object draw and projectille
       float totalTime = 10;
       Line.positionCount = (int)(totalTime / step) + 2;
       int count = 0;
       //adding the step each iteration and counting the steps asdraw line
       for(float i = 0; i < totalTime; i+= step)
       {
           float x = initialvelocity * i * Mathf.Cos(angle);
           float y = initialvelocity * i * Mathf.Sin(angle) -0.5f * -Physics.gravity.y * Mathf.Pow(i, 2);
           Line.SetPosition(count , new Vector3(x , y , transform.position.z));
           count++;  
       }
        float x_final = initialvelocity * totalTime * Mathf.Cos(angle);
        float y_final = initialvelocity * totalTime * Mathf.Sin(angle) -0.5f * -Physics.gravity.y * Mathf.Pow(totalTime, 2);
        Line.SetPosition(count , new Vector3(x_final , y_final , transform.position.z));

    }
    // Start is called before the first frame update
   /* void Start()
    {
        
    }*/


}
