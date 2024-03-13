using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity!");

        // 1. 변수
        int level = 10; // 변수 이름 정하는 것이 선언, 값을 정하는 것이 초기화
        float strength = 15.5f; // 프로그래밍은 보통 선언 -> 초기화 -> 호출 순서로 함.
        string playerName = "dlqorns";
        bool isFullLevel = false;

        Debug.Log("What is his name?");
        Debug.Log(playerName);
        Debug.Log("What is his level?");
        Debug.Log(level);
        Debug.Log("Strength?");
        Debug.Log(strength);
        Debug.Log("is he full level player?");
        Debug.Log(isFullLevel);

        // 2. 그룹형 변수
        string[] monsters = {"슬라임", "사막뱀", "악마"};
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log("맵에 존재하는 몬스터");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);        
        Debug.Log(monsters[2]);
        Debug.Log("맵에 존재하는 몬스터의 레벨");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);

        List<string> items = new List<string>(); // 리스트 : 기능이 추가된 가변형 그룹형 변수
        items.Add("생명물약30");
        items.Add("마나물약30");



        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        items.RemoveAt(0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
