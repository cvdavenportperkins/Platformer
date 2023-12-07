using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    public Transform startPos;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 2;
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        transform.position = new Vector2(startPos.position.x, startPos.position.y);

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}

