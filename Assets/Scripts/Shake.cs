using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public Animator camshake;

    public void CamShake()
    {
        camshake.SetTrigger("shake");
    }

    public void PlayerShakeUp()
    {
        camshake.SetTrigger("playerup");
    }

    public void PlayerShakeDown()
    {
        camshake.SetTrigger("playerdown");
    }
}
