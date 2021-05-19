using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tpDeath : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject Player;

    void OnTriggerEnter2D(Collider2D other)
    {
        Player.transform.position = teleportTarget.transform.position;
    }
}
