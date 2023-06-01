using UnityEngine;
using UnityEngine.UI;

public class EscapeButtonScript : MonoBehaviour
{
    private Button button;
    public GameObject pauseMenu; // Dodajemy referencjê do obiektu menu pauzy

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(TogglePause); // Zmieniamy nas³uch na TogglePause
        pauseMenu.SetActive(false); // Upewniamy siê, ¿e menu pauzy jest wy³¹czone na pocz¹tku
    }

    public void TogglePause()
    {
        // Prze³¹czamy widocznoœæ menu pauzy
        pauseMenu.SetActive(!pauseMenu.activeSelf);

        // Zatrzymujemy lub wznawiamy czas w zale¿noœci od stanu menu pauzy
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