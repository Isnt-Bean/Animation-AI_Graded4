using UnityEngine;
using System.Collections;
using UnityEngine.Splines;

public class Jumptrigger : MonoBehaviour
{

    public GameObject[] splines;


    void Start()
    {
        for (int i = 0; i < splines.Length; i++)
        {
            splines[i].SetActive(false);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        { 
            //activate the spline animation
            for (int i = 0; i <  splines.Length; i++)
            {
                splines[i].SetActive(true);
            }
        }
    }

}
