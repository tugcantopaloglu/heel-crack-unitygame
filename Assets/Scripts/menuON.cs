using UnityEngine;
using UnityEngine.EventSystems;

public class menuON : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private GameObject onObject;
    public void OnPointerDown(PointerEventData eventData)
    {
        
        if (onObject.activeSelf)
        {
            Debug.Log("buton kapalı!");
            onObject.SetActive(false);
        }
        else if(onObject.activeSelf ==false)
        {
            Debug.Log("buton açık!");
            onObject.SetActive(true);
        }
    }
}