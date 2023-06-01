using UnityEngine;
using UnityEngine.SceneManagement;
using Naninovel;

public class BackToVisualNovel : MonoBehaviour
{
    public string sceneName;
    public string scriptName;
    public string labelName;

    public async void GoBack()
    {
        await SceneManager.LoadSceneAsync(sceneName);

        // Poczekaj na inicjalizacjê silnika Naninovel.
        await UniTask.WaitUntil(() => Engine.Initialized);

        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        await scriptPlayer.PreloadAndPlayAsync(scriptName, 0, 0, labelName);
    }
}








