using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            Vector3 newPos = target.transform.GetChild(0).transform.position;
            collider.gameObject.transform.position = new Vector3(newPos.x,newPos.y,collider.gameObject.transform.position.z);
        }
    }
}
