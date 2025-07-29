using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class WaterUIController : MonoBehaviour
{
    public GameObject bottleSlot;
    public Transform bottlsSlotParent;
    public Sprite emptyBottleSprite;
    public Sprite corruptedemptyBottleSprite;
    public Sprite waterBottleSprite;
    public Sprite corruptedWaterBottleSprite;

    private List<Image> bottleImages = new List<Image>();
    public WaterController waterController;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InitSlot();
    }

    // Update is called once per frame
    void Update()
    {
        updateBottls();
    }

    void InitSlot()
    {
        //���� ������ ������ŭ UI�� ����
        for (int i = 0; i < waterController.bottles.Count; i++)
        {
            GameObject newBottleSlot = Instantiate(bottleSlot, bottlsSlotParent);
            Image bottleImage = newBottleSlot.GetComponent<Image>();
            bottleImages.Add(bottleImage);
        }
    }

    void updateBottls()
    {
        //������ ���¿� ���� UI�� ������Ʈ
        for (int i = 0; i < waterController.bottles.Count; i++)
        {
            if (waterController.bottles[i][0] == 0)
            {
                //������ �������
                if (waterController.bottles[i][1] == 0)
                {
                    bottleImages[i].sprite = emptyBottleSprite; // ��ȭ�� �� ����
                }
                else
                {
                    bottleImages[i].sprite = corruptedemptyBottleSprite; // ������ �� ����
                }
            }
            else
            {
                //������ ���� ����
                if (waterController.bottles[i][1] == 0)
                {
                    bottleImages[i].sprite = waterBottleSprite; // ��ȭ�� ����
                }
                else
                {
                    bottleImages[i].sprite = corruptedWaterBottleSprite; // ������ ����
                }
            }
        }
    }
}
