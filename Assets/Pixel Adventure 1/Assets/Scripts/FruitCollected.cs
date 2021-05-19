using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class FruitCollected : MonoBehaviour{
    public AudioSource audioData;

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Player")){

            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            audioData.Play();
            Destroy(gameObject, 0.5f);
        }
    }
}

