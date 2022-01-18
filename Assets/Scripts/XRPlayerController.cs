using UnityEngine;
using UnityEngine.XR;

public class XRPlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;
    [SerializeField] private XRNode _controllerNode = XRNode.LeftHand;

    private InputDevice _controller;

    void Start()
    {
        GetInputDevice();
    }

    float triggerValue;
    void Update()
    {
        UpdateMovement();

        
    }

    private void GetInputDevice()
    {
        // XRNode から デバイスのインスタンスを取得
        _controller = InputDevices.GetDeviceAtXRNode(_controllerNode);
        Debug.Log(_controllerNode);
        Debug.Log(_controller.name);
        Debug.Log(_controller.isValid);
    }

    private void UpdateMovement()
    {
        // 入力タイプ primary2DAxis の取得
        InputFeatureUsage<Vector2> primary2DVector = CommonUsages.primary2DAxis;
        InputFeatureUsage<float> trigger = CommonUsages.trigger;

        // primary2DVector のデータ格納用の変数
        Vector2 primary2DValue;

        if (_controller.TryGetFeatureValue(primary2DVector, out primary2DValue) && primary2DValue != Vector2.zero)
        {
            // 前後方向 2軸では xの移動量 -> 3軸では xの移動量になる
            // 左右方向 2軸では yの移動量 -> 3軸では zの移動量になる
            float xAxis = primary2DValue.x * _speed * Time.deltaTime;
            float zAxis = primary2DValue.y * _speed * Time.deltaTime;

            // ローカル空間からワールド空間へ方向ベクトルを変換し，移動量をかけたものを加える
            transform.position += transform.TransformDirection(Vector3.right) * xAxis;
            transform.position += transform.TransformDirection(Vector3.forward) * zAxis;
        }

        if (_controller.TryGetFeatureValue(trigger, out triggerValue) && triggerValue>0.5f){
            Vector3 newPos = transform.position;
            newPos.y += 1 * triggerValue;
            transform.position = newPos;
        }
    }
}
