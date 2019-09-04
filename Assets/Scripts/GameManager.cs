using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject candle;

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            candle.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
