using UnityEngine;
using UnityEngine.UI;

public class ExitNaninovelButton : MonoBehaviour
{
    public ExitNaninovelMode naninovelExit;
    public Button button;

    private void Start()
    {
        button.onClick.AddListener(naninovelExit.ExitMode);
    }
}

