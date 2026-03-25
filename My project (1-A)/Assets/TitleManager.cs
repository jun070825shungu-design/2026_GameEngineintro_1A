using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public void ButtonLog()
    {
        Debug.Log("버튼이 눌림");
    }

    public GameObject helpPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void GameStart()
    {
        SceneManager.LoadScene("PlayScene_door1");
    }
    public void OpenHelp()
    {
        helpPanel.SetActive(true);
    }
   
    public void CloseHelp()
    {
        helpPanel.SetActive(false);
    }
       
}
