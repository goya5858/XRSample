using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRGrabInteractable))] // Needs XRGrabInteractable Component;
public class InteractableSample : MonoBehaviour
{
    XRGrabInteractable m_InteractableBase;  // from XR toolkit

    void Start()
    {
        m_InteractableBase = GetComponent<XRGrabInteractable>();
        m_InteractableBase.onSelectExited.AddListener(DroppedGun); //When select end
        m_InteractableBase.onActivate.AddListener(TriggerPulled); // When Trigger is pulled
        // ect... 他にも色々なイベントリスナーあり
    }

    // Callbacks //イベントに連動して直接呼び出されるCallbacks
    void DroppedGun(XRBaseInteractor args)
    {
        //Some Actions or Functions can be here;
    }

    void TriggerPulled(XRBaseInteractor args)
    {
        SampleFunctionk();
        // Other Functions can be here;
        // Some Actions can be here;
    }

    // Sample Function //Callbackの内部で呼び出す関数
    protected virtual void SampleFunctionk()
    {
        //Some Actions;
    }
}
