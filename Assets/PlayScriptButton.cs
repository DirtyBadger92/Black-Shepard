using UnityEngine;
using UnityEngine.UI;

public class PlayScriptButton : MonoBehaviour
{
    public PlayNaninovelScript naninovelPlayer;
    public Button button;

    private void Start()
    {
        button.onClick.AddListener(naninovelPlayer.PlayScript);
    }
}

