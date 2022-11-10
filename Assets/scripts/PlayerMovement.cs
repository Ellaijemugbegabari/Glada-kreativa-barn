using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    [SerializeField, Range(1, 10)]
    float speed;
    [SerializeField]
    KeyCode left;
    [SerializeField]
    KeyCode right;
    [SerializeField]
    KeyCode shoot;
    [SerializeField]
    GameObject bullet;
    [SerializeField, Range(1, 10)]
    float bulletspeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left)) //Skeppet åker till vänster
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(right)) //Skeppet åker till höger
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKeyDown(shoot)) //Skjuter lazrar
        {
            Instantiate(bullet, transform.position, bullet.transform.rotation); //Spawnar lazrar
        }
    }
}
