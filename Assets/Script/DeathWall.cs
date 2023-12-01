using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class DeathWall : MonoBehaviour
{
    [SerializeField] private GameObject DeathPopUp; 

    private void Awake()
    {
        DeathPopUp.SetActive(false);
    }
    // Cette m�thode est appel�e lorsqu'un autre collider entre en collision avec la ligne de mort
    public void OnTriggerEnter2D(Collider2D collision)
    {

        // Collision qui tue le player
        if (collision.CompareTag("Ball"))
        {
            Destroy(collision.gameObject);
            GameOver();
        }
    }

    // M�thode appel�e lorsque le jeu est termin�
    public void GameOver()
    {
        DeathPopUp.SetActive(true);
    }

    private void Update()
    {
        if (!FindAnyObjectByType<MainBrick>())
        {
            GameOver();
        }
    }


}
