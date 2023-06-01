using Naninovel;
using UnityEngine;
using UniRx;

public class ExitNaninovelMode : MonoBehaviour
{
    public async void ExitMode()
    {
        var stateManager = Engine.GetService<IStateManager>();
        await stateManager.ResetStateAsync();
    }
}
