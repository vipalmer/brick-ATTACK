using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class people : MonoBehaviour

{
	public float speed = 10f;
    public float shoeSpeed = 10f;
    public float jump;
    public GameObject shoe;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.RightArrow))
		{
            transform.Translate(speed * Time.deltaTime, 0, 0);
            //
        }

		//if (Input.GetKeyDown(KeyCode.UpArrow))
		//{
         //   Debug.Log("Jump");
            //transform.Translate(0, 25*Time.deltaTime, 0);
           // GetComponent<Rigidbody2D>().velocity = new Vector2(0, jump);
        //}//(x,y,z)
        //((x+1),y,z)
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(-speed * Time.deltaTime, 0, 0);
		}
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0,speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0,-speed * Time.deltaTime, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject shoecopy = Instantiate(shoe, transform.position, Quaternion.identity);
            shoecopy.GetComponent<Rigidbody2D>().velocity = new Vector2(shoeSpeed, 0);
               
        }    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.gameObject);
    }
}
