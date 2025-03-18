using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    public List<Rigidbody> allParts = new List<Rigidbody>();

    public void Shatter()
    {
        foreach(Rigidbody part in allParts)
        {
            part.isKinematic = false;
        }
    }
    
    
    /* original code for the model I downloaded
     [SerializeField] GameObject brokenBottlePrefab;
    
    void Update() // just for testing
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            Explode();
        }
    }
    
    void Explode()
    {
        GameObject brokenBottle = Instantiate(brokenBottlePrefab, this.transform.position, Quaternion.identity);
        brokenBottle.GetComponent<BrokenBottle>().RandomVelocities();
        Destroy(gameObject);
    }*/ 
}
