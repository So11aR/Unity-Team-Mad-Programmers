using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] GameObject SettingsMenu;

    //При нажатии на кнопку "Настройки" окно настроек откроется либо закроется, в зависимости от того активно ли оно или нет в данный момент.
    public void Settings()
    {
        if (SettingsMenu.activeInHierarchy == false)
        {
            SettingsMenu.SetActive(true);
        }
        else if (SettingsMenu.activeInHierarchy == true)
        {
            SettingsMenu.SetActive(false);
        }
    }

    //Загрузить сцену с ID = 1 
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    //Выйти из игры
    public void ExitGame()
    {
        Application.Quit();
    }
}
