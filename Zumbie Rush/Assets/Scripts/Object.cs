using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour

    
{
    [SerializeField] private float objSpeed = 1;
    [SerializeField] private float resetPos = 0f;
    [SerializeField] private float startPos = -105f;

    private Vector3 startingPos;

    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if(!GameManager.instance.GameOver)
        {
            transform.Translate(Vector3.right * (objSpeed * Time.deltaTime));

            if (transform.position.x >= resetPos)
            {
                Vector3 newPos = new Vector3(startPos, transform.position.y, transform.position.z);
                transform.position = newPos;
            }
        }

        if (GameManager.instance.GameReset && !GameManager.instance.PlayerActive)
        {
            transform.position = startingPos;
        }
    }
}
