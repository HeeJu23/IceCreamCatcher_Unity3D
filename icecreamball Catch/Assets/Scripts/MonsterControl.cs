using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterControl : MonoBehaviour
{
    public static int lifeCount = InitScene.life;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }

        else if (other.gameObject.tag == "cone" )
        {
            lifeCount--;
            Destroy(gameObject);
            Debug.Log(lifeCount);
        }

    }
}
