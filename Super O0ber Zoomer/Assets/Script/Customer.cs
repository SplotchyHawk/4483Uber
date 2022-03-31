using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public GameObject guy;
    public static bool mesh = true;
    public static int dropoffCounter = 0;
    public static int whichCharacter;
    public GameObject TextBox;
    public GameObject[] Characters;
    //private static int repeat;

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
                    TextBox.SetActive(true);
                    ChooseGuy();
                }
                else
                {
                    guy.SetActive(true);
                    mesh = true;
                    TextBox.SetActive(false);
                    dropoffCounter++;
                }
                Navigation.spawned = false;
            }
        }
    }
    
    private void ChooseGuy()
    {
        int random = Random.Range(0, Characters.Length);
        whichCharacter = random;

        for (int i = 0; i < Characters.Length; i++)
        {
            if (random == i)
            {
                Characters[i].SetActive(true);
            }
            else
            {
                Characters[i].SetActive(false);
            }
        }
    }


}
