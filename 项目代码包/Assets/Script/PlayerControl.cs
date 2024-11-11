using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //�ٶ�
    public float moveSpeed = 1.5f;
    //��ȡ�����SpriteRenderer
    private SpriteRenderer sr;
    public GameObject playerImg;
    //�½�һ���������ĸ������ͼƬ���������ݿ�����unity������
    public Sprite[] tankSprite;
    void Start()
    {
        //��ȡplayer������
        sr = playerImg.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //��ȡˮƽ���ߵ��ƶ�
        float h = Input.GetAxisRaw("Horizontal");
        if (h < 0)//�ı�play��sprite ����ͼƬת��
        {
            //��
            sr.sprite = tankSprite[3];
        }
        else if (h > 0)
        {
            //��
            sr.sprite = tankSprite[1];
        }
        //x�� * �ƶ����� * �ƶ��ٶ� * ����ʱ���ƶ���������������
        transform.Translate(Vector3.right * h * moveSpeed * Time.deltaTime, Space.World);

        //��ȡ��ֱ������ƶ�
        float v = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector3.up * v * moveSpeed * Time.deltaTime, Space.World);
        if (v < 0)
        {
            //��
            sr.sprite = tankSprite[2];
        }
        else if (v > 0)
        {
            //��
            sr.sprite = tankSprite[0];
        }
    }
}

