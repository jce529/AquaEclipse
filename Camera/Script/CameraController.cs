using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; //Ÿ�� ��ġ
    public float smoothing = 5f; //ī�޶� �̵� �ӵ�
    Vector3 offset; //ī�޶�� Ÿ�� ������ �Ÿ�


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - target.position; //ī�޶�� Ÿ�� ������ �Ÿ� ���
    }

    void LateUpdate() //LateUpdate�� Update �Ŀ� ȣ��Ǿ� ī�޶� ��ġ�� ������Ʈ
    {
        Vector3 targetCamPos = target.position + offset; //Ÿ�� ��ġ�� �������� ���Ͽ� ī�޶��� ��ǥ ��ġ ���
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime); //ī�޶� �ε巴�� �̵�
    }
}
