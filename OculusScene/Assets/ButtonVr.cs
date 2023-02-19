using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVr : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    bool isPressed;

    public Oculus.Voice.Demo.ButtonEventWatcher eventWatcher;

    // Start is called before the first frame update
    void Start()
    {
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            button.transform.localPosition = new Vector3(0, 0, 0);
            presser = other.gameObject;
            onPress.Invoke();
            isPressed = true;
            eventWatcher.OnButtonDown.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser)
        {
            button.transform.localPosition = new Vector3(0,0.22f,0);
            onRelease.Invoke();
            isPressed = false;
            eventWatcher.OnButtonUp.Invoke();
        }
    }

    public void buttonPressed()
    {
        Debug.Log("Pressed");
    }
}
