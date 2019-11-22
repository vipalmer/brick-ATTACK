using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class brickpostion : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            collision.transform.position = new Vector3(9.54f, Random.Range(-3.5f, 3.9f), 0);
        }
    }
}
