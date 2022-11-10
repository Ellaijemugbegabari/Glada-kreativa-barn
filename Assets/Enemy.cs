using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField, Range(0.1f, 1)]
    float speedDown = 0.5f; //G�r s� att fiender �ker ned�t - Adam

    [SerializeField, Range(1, 10)]
    float speed = 5; //Hastigheten fiender �ker i - Adam

    float timer;
    bool goRight = true;

    bool goLeft = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //print("ja");
        transform.position -= new Vector3(0, speedDown, 0) * Time.deltaTime;
        if (goRight)
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            //g� �t h�ger - Adam
        }
        else
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
            //g� v�nster - Adam

            if (goLeft)
            {
                goLeft = !goLeft;
            }

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Wall") //Fiender kolliderar med v�ggar - Adam
        {
            goRight = !goRight;
        }

    }
}

