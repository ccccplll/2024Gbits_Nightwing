using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //速度
    public float moveSpeed = 1.5f;
    //获取对象的SpriteRenderer
    private SpriteRenderer sr;
    public GameObject playerImg;
    //新建一个数组存放四个方向的图片，数组内容可以在unity内拖入
    public Sprite[] tankSprite;
    void Start()
    {
        //获取player的属性
        sr = playerImg.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //获取水平防线的移动
        float h = Input.GetAxisRaw("Horizontal");
        if (h < 0)//改变play的sprite 更换图片转向
        {
            //左
            sr.sprite = tankSprite[3];
        }
        else if (h > 0)
        {
            //右
            sr.sprite = tankSprite[1];
        }
        //x轴 * 移动方向 * 移动速度 * 按照时间移动，按照世界坐标
        transform.Translate(Vector3.right * h * moveSpeed * Time.deltaTime, Space.World);

        //获取垂直方向的移动
        float v = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector3.up * v * moveSpeed * Time.deltaTime, Space.World);
        if (v < 0)
        {
            //下
            sr.sprite = tankSprite[2];
        }
        else if (v > 0)
        {
            //上
            sr.sprite = tankSprite[0];
        }
    }
}

