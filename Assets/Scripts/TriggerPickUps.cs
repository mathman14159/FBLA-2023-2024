using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPickUps : MonoBehaviour
{
    public int value;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Item"))
        {
            Destroy(other.gameObject);
            ScoreCounter.instance.IncreaseScore(value);
        }
        if(other.CompareTag("EnemyTop"))
        {
            Destroy(other.gameObject);
            ScoreCounter.instance.IncreaseScore(value);
        }
    }
}
