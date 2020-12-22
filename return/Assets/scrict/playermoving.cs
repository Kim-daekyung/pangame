using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermoving : MonoBehaviour
{
    private Vector3 vector;//백터3

    public float runspeed;//플레이어 속도
    private float applyRunSpeed;//달리기속도
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)//방향키 입력할때 조건 들어감
        {
            if (Input.GetKey(KeyCode.LeftShift))//왼쪽 쉬프트를 눌렀을때 조건
            {
                applyRunSpeed = runspeed;//기본이속을 달리기속도에 추가
            }
                
            else
                applyRunSpeed = 0;

            vector.Set(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), transform.position.z);//방향키를 눌렀을때  그만큼 백터값을 넣음
            if (vector.x != 0)//방향키를 왼오른쪽으로 눌렀을때
            {
                transform.Translate(vector.x * (runspeed+applyRunSpeed), 0, 0);//오른쪽왼쪽 이동함
                
            }
            else if(vector.y != 0)//방향키를 위아래쪽으로 눌렀을때
            {
                transform.Translate(0, vector.y *(runspeed+ applyRunSpeed),0);//위아래쪽으로 이동함
            }
        }
    }
}
