using UnityEngine;
using UnityEngine.UI;

public class EscapeButtonScript : MonoBehaviour
{
    private Button button;
    public GameObject pauseMenu; // Dodajemy referencj� do obiektu menu pauzy

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(TogglePause); // Zmieniamy nas�uch na TogglePause
        pauseMenu.SetActive(false); // Upewniamy si�, �e menu pauzy jest wy��czone na pocz�tku
    }

    public void TogglePause()
    {
        // Prze��czamy widoczno�� menu pauzy
        pauseMenu.SetActive(!pauseMenu.activeSelf);

        // Zatrzymujemy lub wznawiamy czas w zale�no�ci od stanu menu pauzy
        if (pauseMenu.activeSelf)
        {
            Time.timeScale = 0f; // Zatrzymujemy czas
        }
        else
        {
            Time.timeScale = 1f; // Wznawiamy czas
        }
    }
}