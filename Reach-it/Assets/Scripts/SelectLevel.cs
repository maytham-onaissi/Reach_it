using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    public void SelectBusyTown()
    {
        SceneManager.LoadScene(2);
    }

    public void SelectFuturisticCity()
    {
        SceneManager.LoadScene(3);
    }

    public void SelectTimeRift()
    {
        SceneManager.LoadScene(4);
    }

    public void SelectMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
