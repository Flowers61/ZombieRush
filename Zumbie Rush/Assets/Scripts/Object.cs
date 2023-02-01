using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour

    
{
    [SerializeField] float objSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * (objSpeed * Time.deltaTime));
    }
}
