using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lose : MonoBehaviour
{
    public string scene;
    public void loadscene()
    {
        SceneManager.LoadScene(scene);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
            SceneManager.LoadScene("LOSE");

    }



}
