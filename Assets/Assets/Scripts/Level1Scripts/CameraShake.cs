using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public PlayerMovement PM;
    public Animator camAnim;
    public Animator PlayerUI1, PlayerUI2, PlayerUI3;

    public void CamShake()
    {
        camAnim.SetTrigger("EnemyKillShake");
        Debug.Log("Shaking!1");
        ///*
        if (PM.playerLives >= 3)
        {
            camAnim.SetTrigger("GotHit");
            PlayerUI1.SetTrigger("PlayerHit");
            PlayerUI2.SetTrigger("PlayerHit");
            PlayerUI3.SetTrigger("PlayerHit");

            Debug.Log("GH");
        }
        else if (PM.playerLives == 2)
        {
            camAnim.SetTrigger("GotHit2");
            PlayerUI1.SetTrigger("PlayerHit");
            PlayerUI2.SetTrigger("PlayerHit");
            PlayerUI3.SetTrigger("PlayerHit");
            Debug.Log("GH2");
        }
        else if (PM.playerLives == 1)
        {
            camAnim.SetTrigger("GotHit2");
            PlayerUI1.SetTrigger("PlayerHit");
            PlayerUI2.SetTrigger("PlayerHit");
            PlayerUI3.SetTrigger("PlayerHit");

            Debug.Log("GH2");
        }
        else
        {
            camAnim.SetTrigger("GotHit2");
            PlayerUI1.SetTrigger("PlayerHit");
            PlayerUI2.SetTrigger("PlayerHit");
            PlayerUI3.SetTrigger("PlayerHit");
            Debug.Log("GH2");
        }//*/
    }

    //if lives is a certain number, use a certain shake. Not working?
    //public void playerCamShake()
   // {
       
    //}
}
