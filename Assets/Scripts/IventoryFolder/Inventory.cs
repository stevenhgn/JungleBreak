using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    #region Singleton


    public static Inventory instance;

    void Awake()
    {
        if (instance != null) {
            Debug.LogWarning("More than one isntance of Inventory found!");
        }
        instance = this;
    }

    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int space = 6;

    public List<ItemScript> items = new List<ItemScript>();

    public bool Add (ItemScript item) {
        if (items.Count >= space) {
            Debug.Log("Not enough room");
            return false;
        }

        items.Add(item);

        if (onItemChangedCallback !=null) {
            onItemChangedCallback.Invoke();
        }


        return true;
    }

    public void Remove(ItemScript item) {
        items.Remove(item);

        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }

    }
		
}
