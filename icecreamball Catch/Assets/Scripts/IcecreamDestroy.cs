using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcecreamDestroy : MonoBehaviour
{

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "cone")
        {
            gameObject.transform.parent = GameObject.Find("icecreamcone").transform;
        }

        else if (other.gameObject.tag == "Chocolate")
        {
            gameObject.transform.parent = GameObject.Find("icecreamcone").transform;
        }

        else if (other.gameObject.tag == "Greentea")
        {
            gameObject.transform.parent = GameObject.Find("icecreamcone").transform;
        }

        else if (other.gameObject.tag == "Pistachio")
        {
            gameObject.transform.parent = GameObject.Find("icecreamcone").transform;
        }

        else if (other.gameObject.tag == "Strawberry")
        {
            gameObject.transform.parent = GameObject.Find("icecreamcone").transform;
        }

        else if (other.gameObject.tag == "Vanila")
        {
            gameObject.transform.parent = GameObject.Find("icecreamcone").transform;
        }
    }

}
