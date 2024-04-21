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
    public GameObject Camera;


    public void ShopButton1( )
    {
        Instantiate(Sponge, Camera.transform.position + Camera.transform.rotation * Vector3.forward * 20, Camera.transform.rotation);

    }
    public void ShopButton2()
    {
        Instantiate(Cannon, Camera.transform.position + Camera.transform.rotation * Vector3.forward * 20, Camera.transform.rotation);
    }
    public void ShopButton3()
    {
        Instantiate(Sniper, Camera.transform.position + Camera.transform.rotation * Vector3.forward * 20, Camera.transform.rotation);
    }
    public void ShopButton4()
    {
        Instantiate(Kick, Camera.transform.position + Camera.transform.rotation * Vector3.forward * 20, Camera.transform.rotation);
    }
    public void ShopButton5()
    {
        Instantiate(Mage, Camera.transform.position + Camera.transform.rotation * Vector3.forward * 20, Camera.transform.rotation);
    }
    public void ShopButton6()
    {
        Instantiate(Tree, Camera.transform.position + Camera.transform.rotation * Vector3.forward * 20, Camera.transform.rotation);
    }
}
