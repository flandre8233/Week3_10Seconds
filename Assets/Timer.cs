using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void OnTimeEnd();

public class Timer : MonoBehaviour
{
    float LimitTime;
    float CurrentTime;
    OnTimeEnd OnTimeEndDelegate;
    public static Timer Create(float _LimitTime, OnTimeEnd _OnTimeEndDelegate)
    {
        GameObject NewObject = new GameObject();
        Timer TargetComponent = NewObject.AddComponent<Timer>();
        NewObject.name = TargetComponent.GetType().Name;
        TargetComponent.LimitTime = _LimitTime;
        TargetComponent.OnTimeEndDelegate = _OnTimeEndDelegate;
        return TargetComponent;
    }
    // Start is called before the first frame update
    void Start()
    {
        CurrentTime = LimitTime;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime = Mathf.Clamp(CurrentTime - Time.deltaTime, 0, LimitTime);
        if (CurrentTime <= 0)
        {
            if (OnTimeEndDelegate != null)
            {
                OnTimeEndDelegate.Invoke();
            }
            Destroy(gameObject);
        }
    }

    public float GetCurrentTime()
    {
        return CurrentTime;
    }

    public float GetProgress()
    {
        return 1 - (CurrentTime / LimitTime);
    }
}
