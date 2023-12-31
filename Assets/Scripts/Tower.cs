using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    // Tower Component
    [SerializeField] private SpriteRenderer _towerPlace;
    [SerializeField] private SpriteRenderer _towerHead;
    
    // Tower Properties
    [SerializeField] private int _shootPower = 1;
    [SerializeField] private float _shootDistance = 1f;
    [SerializeField] private float _shootDelay = 5f;
    [SerializeField] private float _bulletSpeed = 1f;
    [SerializeField] private float _bulletSplashRadius = 0f;
    
    public Vector2? PlacePosition { get; private set; }

    public void SetPlacePosition(Vector2? newPosition)
    {
        PlacePosition = newPosition;
    }
    
    // Fungsi yang digunakan untuk mengambil sprite pada Tower Head
    public Sprite GetTowerHeadIcon ()
    {
        return _towerHead.sprite;
    }
    
    public void LockPlacement ()
    {
        transform.position = (Vector2) PlacePosition;
    }
    public void ToggleOrderInLayer (bool toFront)
    {
        int orderInLayer = toFront ? 2 : 0;
        _towerPlace.sortingOrder = orderInLayer;
        _towerHead.sortingOrder = orderInLayer;
    }
}
