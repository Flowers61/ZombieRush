using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour

    
{
    [SerializeField] float objSpeed = 1;
    private float resetPos = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * (objSpeed * Time.deltaTime));

        if(transform.position.x >= resetPos)
        {
            Vector3 newPos = new Vector3(-105, transform.position.y, transform.position.z);
            transform.position = newPos;
        }
    }
}
