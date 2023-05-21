using UnityEngine;

public class TorchController : MonoBehaviour
{
    public Transform playerHand; // ������ �� ����� ��� ����� �������� ���� ������
    public Transform torchModel; // ������ �� ������ ������
    public float x, y, z;

    void Update()
    {
        // ���������� ������� � ������� ������ ������� ������� � �������� ���� ������
        torchModel.position = playerHand.position;
        torchModel.rotation = playerHand.rotation * Quaternion.Euler(x,y,z);
    }
}
