using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageIndicator : MonoBehaviour
{
    [SerializeField]
    private int MaxHP=100;
    [SerializeField]
    private int CurrentHP;
    [SerializeField]
    private int DamageReceived=20;
    private void Start()
    {
        CurrentHP = MaxHP;
    }
    private void OnTriggerEnter(Collider other)
    {
        //Śmierć
        if (other.gameObject.tag == "Projectile")
        {
            CurrentHP -= DamageReceived;
            Check();
        }
    }
    private void Check()
    {
        if (CurrentHP<=0)
        {
            Destroy(gameObject);
        }
    }
   
}
