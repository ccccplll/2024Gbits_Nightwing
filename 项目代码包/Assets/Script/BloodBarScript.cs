using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ����Unity��UI��
using UnityEngine.UI;

public class BloodBarScript : MonoBehaviour
{
    // �������ֶ���
    public Image mask;
    // ��ȡ���ֵĳ�ʼ����
    private float originalSize;
    public float value = 1f;

    // ʹ�õ���ģʽ������Ѫ������
    public static BloodBarScript instance
    {
        get; private set;
    }

    // Awake()����������Start()����ִ��
    private void Awake()
    {
        // ��instanceʵ����Ϊ��ǰ��Ѫ����Ϸ����
        instance = this;
    }

    void Start()
    {
        // ���ֳ�ʼ����Ϊ��ʼʱ���ֵ�ǰ����
        originalSize = mask.rectTransform.rect.width;
    }

    private void Update()
    {
        this.changeLength(this.value);
    }

    // �ı����ֳ���
    public void changeLength(float value)
    {
        // �����ֳ�������Ϊˮƽ����ĳ�ʼ����*�ٷֱ�
        mask.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, originalSize * value);
    }
}
