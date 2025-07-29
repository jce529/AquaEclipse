using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [Header("HP")]
    public Slider HP_Bar; // �÷��̾� HP �����̴�

    [Header("WaterUI")]
    public GameObject WaterIconPrefab; // ������ �� ������ ������
    public Transform watePanel; // �� �������� ��ġ�� �г�
    public Sprite pureSprite; // ������ �� ������ ��������Ʈ
    public Sprite corruptedSprite; // ������ �� ������ ��������Ʈ

    private Image[] waterIcons; // �� �������� ������ �迭

    public void InitWaterIcon(int maxCount)
    {
        waterIcons = new Image[maxCount]; // �� ������ �迭 �ʱ�ȭ

        for (int i = 0; i < maxCount; ++i)
        {
            GameObject PureWatericon = Instantiate(WaterIconPrefab, watePanel); // ������ �� ������ ����

            waterIcons[i] = PureWatericon.GetComponent<Image>(); // �������� Image ������Ʈ ��������
        }

    }

    public void updateHP(int current, int max)
    {
        HP_Bar.value = current; // ���� HP ���� �����̴��� ����
        HP_Bar.maxValue = max; // �����̴��� �ִ밪 ����
    }

    public void updateWater(int currentWater, int corruptedCount)
    {
        for (int i = 0; i < waterIcons.Length; ++i)
        {
            if (i < currentWater)
            {
                if (i >= currentWater - corruptedCount)
                {
                    waterIcons[i].sprite = pureSprite; // ������ �� ������ ����
                }
                else
                {
                    waterIcons[i].sprite = corruptedSprite; // ������ �� ������ ����
                }
            }
        }
    }
}