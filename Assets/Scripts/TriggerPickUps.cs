using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPickUps : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Item"))
        {
            Destroy(other.gameObject);
        }
        if(other.CompareTag("EnemyTop"))
        {
            Destroy(other.gameObject);
        }
    }
}
