using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class Action : ScriptableObject
{
    public UnityAction raise;

    public void RasieAction()
    {
        raise?.Invoke();
    }
}
