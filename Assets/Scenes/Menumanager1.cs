using UnityEngine;
using UnityEngine.SceneManagement;

public class Menumanager1 : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("開始遊戲");
        SceneManager.LoadScene("game");
    }

    public void ExitGame()
    {
        Debug.Log("結束遊戲");
    }

    public void ShowOptions()
    {
        Debug.Log("設定");
    }
}
