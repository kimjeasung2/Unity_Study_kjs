using System;
using UnityEngine;
using UnityEngine.EventSystems;
//[RequireComponent(typeof(MeshRenderer))]
//무조건 MeshRenderer 컴포넌트를 강제적으로 추가

public class MousePointer_Reactor : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    private Material _material;
    private Color _originalColor;
    public Color _mouseColor;
    private Vector3 _mousePosition;
    private Vector3 _mouseDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (_material != null)
        {
            _material.color = _mouseColor;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (_material != null)
        {
            _material.color = _originalColor;
        }
    }


    void Start()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        if(meshRenderer == null)
        {
            Debug.LogError("MeshRenderer 컴포넌트가 없습니다. " + gameObject.name);
            return;
        }
        _material = meshRenderer.material;
        _originalColor = _material.color;
    }

    // Update is called once per frame
    void Update()
    {
        


    }

 
}
