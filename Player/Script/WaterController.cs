using UnityEngine;

public class WaterController : MonoBehaviour
{
    public System.Collections.Generic.List<int[]> bottles = new System.Collections.Generic.List<int[]>();
    public bool PureWaterMod = false;
    public bool CorruptedWaterMod = false;

    public void AddBottle(int amout1)
    {
        // �� ������ int 2ĭ¥�� �迭
        for (int i = 0; i < amout1; i++)
        {
            int[] bottle_State = new int[2]; // [0]:0 = �� ����, 1 = ���� ����ִ� ����, [1]: 0 = ��ȭ��, 1 = ������
            bottles.Add(bottle_State); // ����Ʈ�� �߰�
            bottles[i][0] = 1; // ������ ���� ������
        }
    }

    public void UseBottle(int amount2)
    {

        for (int i = 0; i < amount2; i++)
        {
                bottles[waterCounter() + corruptedwaterCounter() - 1][0] = 0; // �������� ���� �����
        }
        
    }

    public void RecoveryWater()
    {
        for (int i = 0; i < bottles.Count; i++)
        {
            if (bottles[i][0] == 0) // ���빰�� ���� ������ ã��
            {
                bottles[i][0] = 1; // ������ ���� ä��
                Debug.Log("������ ä�������ϴ�.");
                return; // ������ ä�� �� �Լ� ����
            }
        }
    }

    public void RecoveryCorruptedWater()
    {
        for (int i = 0; i < bottles.Count; i++)
        {
            if (bottles[i][0] == 0) // ���빰�� ���� ������ ã��
            {
                bottles[i][0] = 1; // ������ ���� ä���
                bottles[i][1] = 1; // ���¸� ������ ���� ����
                Debug.Log("������ ������ ä�������ϴ�.");
                return; // ������ ������ ä�� �� �Լ� ����
            }
        }
    }

    public int waterCounter()
    {
        int count1 = 0;
        for (int i = 0; i < bottles.Count; i++)
        {
            if (bottles[i][0] == 1 && bottles[i][1] == 0) // ���� �ִ� ������ ã��
            {
                count1++;
            }
        }
        return count1; // ���� �ִ� ������ ������ ��ȯ
    }
    public int corruptedwaterCounter()
    {
        int count2 = 0;
        for (int i = 0; i < bottles.Count; i++)
        {
            if (bottles[i][0] == 1 && bottles[i][1] == 1) //������ ���� �ִ� ������ ã��
            {
                count2++;
            }
        }
        return count2; // ������ ���� �ִ� ������ ������ ��ȯ
    }
    void Start()
    {
        AddBottle(5); // ������ 5�� �߰�
    }

    void Update()
    {
        waterCounter();
        corruptedwaterCounter();
        if (corruptedwaterCounter() == 0) PureWaterMod = true; // ������ ������ ������ ������ �� ��� Ȱ��ȭ
        else PureWaterMod = false; // ������ ������ ������ ������ �� ��� ��Ȱ��ȭ 

        if (waterCounter() == 0) CorruptedWaterMod = true; // ������ ������ ������ �� ��� Ȱ��ȭ
        else CorruptedWaterMod = false; // ������ ������ ������ �� ��� ��Ȱ��ȭ


    }
}
