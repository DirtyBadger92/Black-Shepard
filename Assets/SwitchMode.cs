using Naninovel;
using UnityEngine;
using UniRx;

public class SwitchMode : MonoBehaviour
{
    public string scriptName;
    public string label;
    public bool isNaninovelMode = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isNaninovelMode)
            {
                ExitNaninovelMode();
            }
            else
            {
                PlayNaninovelScript();
            }
        }
    }

    private async void PlayNaninovelScript()
    {
        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        await scriptPlayer.PreloadAndPlayAsync(scriptName, label: label);
        isNaninovelMode = true;
    }

    private async void ExitNaninovelMode()
    {
        var stateManager = Engine.GetService<IStateManager>();
        await stateManager.ResetStateAsync();
        isNaninovelMode = false;
    }
}

