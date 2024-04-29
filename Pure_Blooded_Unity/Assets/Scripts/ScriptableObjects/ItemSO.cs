using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Scriptable objects/Item")]
public class ItemSO : ScriptableObject //ScriptableObject para los atributos de los items
{
    //General
    [SerializeField] private string itemName;
    [SerializeField] private string itemDescription;
    [SerializeField] private Sprite itemImage;
    [SerializeField] private GameObject itemPrefab;

    //States
    [SerializeField] private bool canInteract; //Al final creo q todos podran interactuar de alguna forma (ej: una llave abre, la linterna prende y apaga, una nota se puede  lerr, etc)

    //Public getters (Sirven para poder cargar los datos default segun el tipo de item q sea desde InventoryItem, cada item de la escena debe tener un ItemSO asignado)
    public string GetItemName() => itemName;
    public string GetItemDescription() => itemDescription;
    public Sprite GetItemImage() => itemImage;
    public bool GetInteractState() => canInteract;
    public GameObject GetItemPrefab() => itemPrefab;
}
