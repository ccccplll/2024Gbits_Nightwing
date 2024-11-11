using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 调用Unity的UI库
using UnityEngine.UI;

public class BloodBarScript : MonoBehaviour
{
    // 创建遮罩对象
    public Image mask;
    // 获取遮罩的初始长度
    private float originalSize;
    public float value = 1f;

    // 使用单例模式，创建血条对象
    public static BloodBarScript instance
    {
        get; private set;
    }

    // Awake()方法优先于Start()方法执行
    private void Awake()
    {
        // 将instance实例化为当前的血底游戏对象
        instance = this;
    }

    void Start()
    {
        // 遮罩初始长度为初始时遮罩当前长度
        originalSize = mask.rectTransform.rect.width;
    }

    private void Update()
    {
        this.changeLength(this.value);
    }

    // 改变遮罩长度
    public void changeLength(float value)
    {
        // 将遮罩长度设置为水平方向的初始长度*百分比
        mask.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, originalSize * value);
    }
}
