using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    [SerializeField] private InputField playerinputName;

    private string playerName = null;

    private void Awake()
    {
        //playerName = playerinputName.GetComponent<InputField>().text;
    }

    // �÷��̾� �̸� ����
    public void PlayerInputNameSave()
    {
        // Player Name 2 ~ 10 ���� ���� ����
        if (playerinputName.text.Length > 1 && playerinputName.text.Length < 11)
        {
            // ���� ������ �̸� ����
            playerName = playerinputName.text;
            // ���� �Ŵ����� �̸� ����
            GameManager.instance.SettingPlayerName(playerName);
            // �� �̵�
            SceneManager.LoadScene("MainScene");
        }
    }
}