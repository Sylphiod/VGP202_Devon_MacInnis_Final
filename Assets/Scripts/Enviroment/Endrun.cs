using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Endrun : MonoBehaviour
{

    public GameObject liveCoin;
    public GameObject liveDis;
    public GameObject endScreen;
    public GameObject fadeOut;
    
    void Start()
    {
        StartCoroutine(EndSequence());
    }

   IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(2);
        liveCoin.SetActive(false);
        liveDis.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(4);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}
