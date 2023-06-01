using Naninovel;
using UnityEngine;
using UniRx;

public class PlayNaninovelScript : MonoBehaviour
{
    public string scriptName;

    public async void PlayScript()
    {
        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        await scriptPlayer.PreloadAndPlayAsync(scriptName);
    }
}


