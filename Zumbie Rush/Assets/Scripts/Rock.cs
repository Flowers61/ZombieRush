using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    [SerializeField] Vector3 topPos;
    [SerializeField] Vector3 bottomPos;
    [SerializeField] float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Move(bottomPos));

        IEnumerator Move(Vector3 target)
        {
            while (Mathf.Abs((target - transform.localPosition).y) > 0.20f)
            {
                Vector3 direction = target.y == topPos.y ? Vector3.up : Vector3.down;
                transform.localPosition += direction * Time.deltaTime * speed;

                yield return null;
            }

            print("rached the target");

            yield return new WaitForSeconds(0.5f);

            Vector3 newTarget = target.y == topPos.y ? bottomPos : topPos;

            StartCoroutine(Move(newTarget));
        }
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
