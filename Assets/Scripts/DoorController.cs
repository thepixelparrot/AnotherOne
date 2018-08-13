using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour {

    // Use this for initialization
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Application.LoadLevel("Domek2Inside");
    }

}
