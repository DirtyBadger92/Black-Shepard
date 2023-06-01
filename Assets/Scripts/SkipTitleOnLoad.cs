using UnityEngine;
using Naninovel;

public class SkipTitleOnLoad : MonoBehaviour
{
    public static bool SkipTitle { get; set; } = false;

    private void Start()
    {
        if (SkipTitle)
        {
            var scriptPlayer = Engine.GetService<IScriptPlayer>();
            scriptPlayer.Play();
            SkipTitle = false;
        }
    }
}

