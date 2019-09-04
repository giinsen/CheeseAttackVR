using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public GameObject target;
    private Vector3 targetPosition;

    public float speed;

    private bool move = true;
    private Transform t;

    void Start()
    {
        targetPosition = target.transform.position;
        targetPosition.x = targetPosition.x + Random.Range(-0.05f, 0.05f);
        targetPosition.y = targetPosition.y + Random.Range(-0.05f, 0.05f);
        targetPosition.z = targetPosition.z + Random.Range(-0.05f, 0.05f);


        //transform.LookAt(target.transform);
    }

    void Update()
    { 
        if (move)
            transform.Translate((targetPosition - transform.position) * speed * Time.deltaTime);
        //if (Vector3.Distance(target.transform.position, transform.position) <= startDistance * 0.1)
        //{
        //    //stop souris et incrémenter cheese mouse
        //    move = false;
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Lamp")
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Cheese")
        {
            move=false;
        }
    }
}
