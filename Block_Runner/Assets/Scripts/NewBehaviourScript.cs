using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rigid;
    public float forwardForce = 2000f;
    public float sidewaysForce = 1000f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        rigid.AddForce(0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey("d"))
		{
            rigid.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
		}
        if (Input.GetKey("a"))
        {
            rigid.AddForce((sidewaysForce * Time.deltaTime) *-1, 0, 0, ForceMode.VelocityChange);
        }

        if(rigid.position.y < -1f)
        {
             FindObjectOfType<GameManager>().EndGame();
        }


    }
}
