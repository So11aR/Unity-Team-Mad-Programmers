using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] GameObject SettingsMenu;

    //��� ������� �� ������ "���������" ���� �������� ��������� ���� ���������, � ����������� �� ���� ������� �� ��� ��� ��� � ������ ������.
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

    //��������� ����� � ID = 1 
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    //����� �� ����
    public void ExitGame()
    {
        Application.Quit();
    }
}
