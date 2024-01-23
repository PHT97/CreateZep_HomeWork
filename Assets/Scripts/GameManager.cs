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
        // instance가 null이라면
        if (instance == null)
        {
            // 자기 자신을 intance에 넣는다.
            instance = this;
            //OnLoad(씬이 로드 되었을때) 자신을 파괴하지 않고 유지
            DontDestroyOnLoad(gameObject);
        }
        // 이미 존재한다면
        else
        {
            Destroy(this.gameObject);
        }
    }
    // 플레이어 이름
    private string playerName;
    // 플레이어 이름 저장
    public void SettingPlayerName(string name)
    {
        playerName = name;
    }

    // 플레이어 이름 불러오기
    public string OutputPlayerName()
    {
        return playerName;
    }
}
