using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyUnit : MonoBehaviour
{

    public GameObject Sponge;
    public GameObject Cannon;
    public GameObject Sniper;
    public GameObject Kick;
    public GameObject Mage;
    public GameObject Tree;


    public void ShopButton1( )
    {
        Instantiate(Sponge);
    }
    public void ShopButton2()
    {
        Instantiate(Cannon);
    }
    public void ShopButton3()
    {
        Instantiate(Sniper);
    }
    public void ShopButton4()
    {
        Instantiate(Kick);
    }
    public void ShopButton5()
    {
        Instantiate(Mage);
    }
    public void ShopButton6()
    {
        Instantiate(Tree);
    }
}
