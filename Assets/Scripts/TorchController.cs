using UnityEngine;

public class TorchController : MonoBehaviour
{
    public Transform playerHand; // —сылка на кость или точку прив€зки руки игрока
    public Transform torchModel; // —сылка на модель факела
    public float x, y, z;

    void Update()
    {
        // ”становите позицию и поворот факела равными позиции и повороту руки игрока
        torchModel.position = playerHand.position;
        torchModel.rotation = playerHand.rotation * Quaternion.Euler(x,y,z);
    }
}
