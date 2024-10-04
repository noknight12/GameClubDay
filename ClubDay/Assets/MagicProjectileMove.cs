using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicProjectileMove : MonoBehaviour
{
    Selecter selecter;
    Transform target;
    Enemy enemy;
   
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        selecter = GameObject.FindAnyObjectByType<Selecter>();
        target = selecter.target.gameObject.transform;
        enemy = selecter.target;
    }

    // Update is called once per frame
    void Update()
    {
        //rotate to look at the player
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);//correcting the original rotation


        //move towards the player
        if (Vector3.Distance(transform.position, target.position) > 1f)
        {//move if distance from target is greater than 1
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }

        if(Vector3.Distance(transform.position, target.position) < 1)
        {
            enemy.TakeHit();
        }

    }
}
