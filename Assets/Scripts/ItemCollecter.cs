using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollecter : MonoBehaviour
{
    private int meats = 0;

    [SerializeField] private Text MeatsText;
    [SerializeField] private AudioSource itemsSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Meat"))
        {
            itemsSoundEffect.Play();
            Destroy(collision.gameObject);
            meats++;
            MeatsText.text = "Score: " + meats;
        }
    }

    
}
