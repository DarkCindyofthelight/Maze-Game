using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Won : MonoBehaviour
{
    public GameObject winText;
       public float delay;

    void Start()
    {
        winText.SetActive (false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            winText.SetActive (true);
           
            StartCoroutine (Countdown ());
        }
    }

    IEnumerator Countdown()
    {
        yield return new WaitForSeconds (delay);
        SceneManager.LoadScene (1);

    }

}
