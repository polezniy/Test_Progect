using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleWallController : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("YOU ARE DEAD");
        GameController.Instance.death = true;
    }
}
