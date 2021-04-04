using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceenTransitions : MonoBehaviour
{
    public UIManager manager;

    public void Room()
    {
        manager.livesTransfer();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Room2()
    {
        manager.livesTransfer();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Room3()
    {
        manager.livesTransfer();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void Room4()
    {
        manager.livesTransfer();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void Room5()
    {
        manager.livesTransfer();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void Room6()
    {
        manager.livesTransfer();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    public void Room7()
    {
        manager.livesTransfer();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
    }

    public void Room8()
    {
        manager.livesTransfer();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
    }
}
