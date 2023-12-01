using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    public Button quitButton;

    void Start()
    {

        quitButton.onClick.AddListener(QuitGame);
    }

    void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}
