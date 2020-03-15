using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageIndicator : MonoBehaviour
{
    [SerializeField]
    private  HealthPoints scoreManager;
    public string dead;
    private void OnTriggerEnter(Collider other)
    {
        //Śmierć
        if (other.gameObject.tag == "Player")
        {
            dead = "very";
            LoseHP();
        }
    }
    private void LoseHP()
    {
        scoreManager.LoseHP(25);
    }
}
