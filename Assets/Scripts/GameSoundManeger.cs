using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class GameSoundManeger : MonoBehaviour
{
    public GameObject LoseM;
    public GameObject GameSoundManegerer;
    public AudioSource myFX;
    public AudioClip dieFX;
    void Update()
    {
        if(LoseM.active == true)
        {
            myFX.PlayOneShot(dieFX);
            GameSoundManegerer.active = false;      //Не ругайся, пусть живёт
        }
    }
}
