using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manageCollision : MonoBehaviour
{
    public AudioSource ammoPack;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        transform.GetChild(0).GetComponent<PlayerScript>().manageCollisions(hit);
    }
}
