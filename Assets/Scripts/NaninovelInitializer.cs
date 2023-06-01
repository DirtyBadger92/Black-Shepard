using Naninovel;
using UnityEngine;

public class NaninovelInitializer : MonoBehaviour
{
    private async void Start()
    {
        await RuntimeInitializer.InitializeAsync();
    }
}