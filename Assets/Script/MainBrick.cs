using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MainBrick : MonoBehaviour
{
    private ScoreMana scoreMana;
    [SerializeField] private int pv;
    public DeathWall deathWall;

    private void Awake()
    {
        scoreMana = FindAnyObjectByType<ScoreMana>();
    }


    //Destruction de la brique
    private void OnCollisionEnter2D(Collision2D _collision)
    {
        if (_collision.gameObject.tag == "Ball")
        {
            pv -= 1;
            if (pv <= 0)
            {
 
                Destroy(gameObject);
                scoreMana.AddToScore(10);
              

            }
           
        }
    }
}
