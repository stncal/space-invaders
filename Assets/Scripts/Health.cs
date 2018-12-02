﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{

    public Image healthBar;
    public static int health;
   public int startingHealth = 100;
	public Text healthText;

    // Use this for initialization
    void Start()
    {
        health = startingHealth;
		healthText.text = health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
		
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
        {
            health = health - 20;
			healthText.text = health.ToString();
            healthBar.fillAmount = health / startingHealth;
        }
    }


}
