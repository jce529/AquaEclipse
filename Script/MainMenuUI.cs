using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void OnClickStart()
    {

        Debug.Log("게임 시작 버튼 클릭됨");
        //스타트버튼 클릭시 게임 시작
        SceneManager.LoadScene("InGame");
    }
}
