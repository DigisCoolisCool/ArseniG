using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flickerlight : MonoBehaviour
{
    public bool isFlickering = false;
    public float timeDelay;
    

    // Update is called once per frame
    void Update()
    {
        if(isFlickering == false)
        {
            StartCoroutine(Flickeringlight());
        }
    }

    IEnumerator Flickeringlight()
    {
        isFlickering = true;
        gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(0.01f, 0.02f);
        yield return new WaitForSeconds(timeDelay);
        gameObject.GetComponent<Light>().enabled = true;
        timeDelay = Random.Range(0.01f, 0.02f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;
    }   
}
