using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoHolderManager : MonoBehaviour
{
    public BirdScript bs;

    public Text ammotext;

    private void Update()
    {
        ammotext.text = bs.Ammo.ToString();
    }
   

    
}
