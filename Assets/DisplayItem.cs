using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class DisplayItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [SerializeField] GameObject _linesheetPrefab;
    [SerializeField] UnityEvent PointerClickedAction;

    public LinesheetTemplate Linesheet { get; private set; }

    public void OnPointerClick(PointerEventData eventData)
    {
        PointerClickedAction?.Invoke();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Linesheet.Show(0.5f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Linesheet.Hide(1.0f, 0.5f);
    }

    // Start is called before the first frame update
    void Start()
    {
        Linesheet = Instantiate(_linesheetPrefab).GetComponent<LinesheetTemplate>();
    }
}
