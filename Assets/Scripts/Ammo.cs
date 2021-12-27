using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{

    [SerializeField] int ammoAmount = 10;
    /*  private class AmmoSlot
      {
          public AmmoType ammoType;
          public int ammoAmount;
      }*/
    private void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            ammoAmount = 10;
        }
    }

    public int GetCurrentAmmo()
    {
        return ammoAmount;
    }
    public void ReduceCurrentAmmo()
    {
        ammoAmount--;
    }
}
