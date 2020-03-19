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
    [SerializeField]
    private HealthBar healthBar;
    
    private void Start()
    {
        CurrentHP = maxHP;
        healthBar.SetMaxHealth(maxHP);
    }
    private void OnTriggerEnter(Collider other)
    {
  
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
        healthBar.SetHealth(CurrentHP);
    }
    void Dead()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
