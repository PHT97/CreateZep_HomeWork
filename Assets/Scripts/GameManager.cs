using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterType
{
    Knight,
    Elf
}
[System.Serializable]
public class Character
{
    public CharacterType CharacterType;
    public Sprite CharacterSprite;
    public RuntimeAnimatorController AnimatorController;
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public List<Character> CharacterList = new List<Character>();
    public Animator PlayerAnimator;

    private void Awake()
    {
        // instance�� null�̶��
        if (instance == null)
        {
            // �ڱ� �ڽ��� intance�� �ִ´�.
            instance = this;
            //OnLoad(���� �ε� �Ǿ�����) �ڽ��� �ı����� �ʰ� ����
            DontDestroyOnLoad(gameObject);
        }
        // �̹� �����Ѵٸ�
        else
        {
            Destroy(this.gameObject);
        }
    }
    // �÷��̾� �̸�
    private string playerName;
    // �÷��̾� �̸� ����
    public void SettingPlayerName(string name)
    {
        playerName = name;
    }

    // �÷��̾� �̸� �ҷ�����
    public string OutputPlayerName()
    {
        return playerName;
    }
}
