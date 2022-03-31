using System.Collections;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {

        while (true)
        {

            for (int i = 0; i < transform.childCount; i++)
            {

                if (!transform.GetChild(i).gameObject.activeInHierarchy)
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                    int count = Random.Range(3, 6);
                    yield return new WaitForSeconds(count);
                }
            }
        }
    }
}
