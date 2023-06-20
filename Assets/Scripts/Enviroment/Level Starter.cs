using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countdown3;
    public GameObject countdown2;
    public GameObject countdown1;
    public GameObject countdownGo;
    public GameObject Fadein;

    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(2f);
        countdown3.SetActive(true);
        yield return new WaitForSeconds(1f);
        countdown2.SetActive(true);
        yield return new WaitForSeconds(1f);
        countdown1.SetActive(true);
        yield return new WaitForSeconds(1f);
        countdownGo.SetActive(true);
        PlayerMove.canMove = true;
    }
}
