using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void OnClickStart()
    {

        Debug.Log("���� ���� ��ư Ŭ����");
        //��ŸƮ��ư Ŭ���� ���� ����
        SceneManager.LoadScene("InGame");
    }
}
