using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[SerializeField]
public class PanelManage : MonoBehaviour
{
    public GameObject main;
    public GameObject options;
    public void MainPanel()
    {
        main.SetActive(true);
        options.SetActive(false);
    }
    public void OptionsPanel()
    {
        main.SetActive(false);
        options.SetActive(true);
    }
    public void GoToPlay()
    {
        SceneManager.LoadScene(0);
    }
}
