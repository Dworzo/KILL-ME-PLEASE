using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossDying : MonoBehaviour
{

    public float maxHealth = 100f;
    public float bossHealth = 1f;

    private void Start()
    {
        bossHealth = maxHealth;
   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bomb")
        {
            bossHealth = bossHealth - 25;
            Debug.Log("boss hurt");
            Debug.Log(bossHealth);
        }
    }
    private void Update()
    {
        if (bossHealth > maxHealth)
        {
            bossHealth = maxHealth;
        }
        else if (bossHealth <= 0f)
        {
            boss_Died();
        }
    }

    private void boss_Died()
    {
        bossHealth = 0f;
        Debug.Log("boss Died");
        SceneManager.LoadScene(1);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
