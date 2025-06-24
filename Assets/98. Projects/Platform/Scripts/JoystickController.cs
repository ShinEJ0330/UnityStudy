using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] private CharaterController_Joystick joystickController;
    [SerializeField] private GameObject backGroundUI;
    [SerializeField] private GameObject handlerUI;

    private Vector2 startPos, currPos;

    void Start()
    {
        backGroundUI.SetActive(false);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        backGroundUI.SetActive(true);
        backGroundUI.transform.position = eventData.position;
        startPos = eventData.position;
    }
    public void OnDrag(PointerEventData eventData)
    {
        currPos = eventData.position;
        Vector2 dragDir = currPos - startPos;

        float maxDist = Mathf.Min(dragDir.magnitude, 75f);

        handlerUI.transform.position = startPos + dragDir.normalized * maxDist;

        joystickController.InputJoystick(dragDir.x, dragDir.y);
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        joystickController.InputJoystick(0, 0);
        handlerUI.transform.localPosition = Vector2.zero;
        backGroundUI.SetActive(false);
    }
}