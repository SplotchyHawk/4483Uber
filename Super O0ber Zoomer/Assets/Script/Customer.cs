using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public GameObject guy;
    private bool mesh = true;
    public static int dropoffCounter = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("We hit something captain!");

            if (Navigation.spawned == true)
            {
                if (mesh == true)
                {
                    guy.SetActive(false);
                    mesh = false;
                }
                else
                {
                    guy.SetActive(true);
                    mesh = true;
                    dropoffCounter++;
                }
                Navigation.spawned = false;
            }
        }
    }


   
}
