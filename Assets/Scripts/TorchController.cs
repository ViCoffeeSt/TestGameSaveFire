using UnityEngine;

public class TorchController : MonoBehaviour
{
    public Transform playerHand;
    public Transform torchModel;

    void Update()
    {
        torchModel.position = playerHand.position;
        torchModel.rotation = playerHand.rotation;
    }
}
