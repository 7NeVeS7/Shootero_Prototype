using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HealthPoints : MonoBehaviour
{
    [SerializeField]
    private int maxHP = 100;
    [SerializeField]
    private int CurrentHP;
    
    private void Start()
    {
        CurrentHP = maxHP; 

    }
    private void OnTriggerEnter(Collider other)
    {
        //Śmierć
        if (other.gameObject.tag == "Enemy")
        {
            LoseHP(20);
            Check();
        }
    }
    public void LoseHP(int amount)
    {
        CurrentHP -= amount;
        Check();
    }
    void Check()
    {
        if (CurrentHP>maxHP)
        {
            CurrentHP = maxHP;
        }else if (CurrentHP<=0)
        {
            Dead();
        }
    }
    void Dead()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
