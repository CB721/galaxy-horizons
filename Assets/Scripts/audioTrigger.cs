using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audioTrigger : MonoBehaviour
{
    public GameObject countDown;
    public AudioSource Soundtrack;
    public GameObject lapTimer;
    public GameObject LapPanel;
    public GameObject ExtraPanel;
    public GameObject CarBlock;
    void Start()
    {
        StartCoroutine (countStart());
    }
    IEnumerator countStart () {
        LapPanel.SetActive (false);
        ExtraPanel.SetActive (false);
        Soundtrack.Play();
        yield return new WaitForSeconds (0.5f);
        countDown.GetComponent<Text>().text = "5";
        countDown.SetActive(true);
        yield return new WaitForSeconds (1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "4";
        countDown.SetActive(true);
        yield return new WaitForSeconds (1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "3";
        countDown.SetActive(true);
        yield return new WaitForSeconds (1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "2";
        countDown.SetActive(true);
        yield return new WaitForSeconds (1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "1";
        countDown.SetActive(true);
        yield return new WaitForSeconds (1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "Go!";
        countDown.SetActive(true);
        CarBlock.SetActive(false);
        // CarController.m_Topspeed;
        // MyCar.GetComponent<RigidBody>().isKinematic = false;
        countDown.SetActive(false);
        lapTimer.SetActive(true);
        LapPanel.SetActive (true);
        ExtraPanel.SetActive (true);
    }
}
