using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void GotoSpaceScene()
    {
        SceneManager.LoadScene("SpaceScene");
    }
}

