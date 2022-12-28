using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;
    private Vector3 respawnPoint;
    public GameManagerScrp gameManager;
    [SerializeField] private AudioSource playerSoundEffect;

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        respawnPoint = transform.position;
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
        
        if (currentHealth > 0)
        {
            anim.SetTrigger("hurt");
            transform.position = respawnPoint;
            playerSoundEffect.Play();
        }
        else
        {
            if(!dead)
            {
                anim.SetTrigger("death");
                GetComponent<PlayerMovement>().enabled = false;
                dead = true;
                playerSoundEffect.Play();
                gameManager.gameOver();
            }       
        }
    }
}
