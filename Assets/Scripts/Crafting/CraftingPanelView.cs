﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Crafting Module View
/// </summary>

public class CraftingPanelView : MonoBehaviour
{
    private Transform m_Transform;
    private Transform tabs_Transform;
    private Transform contents_Transform;
    private Transform center_Transform;

    private GameObject prefab_TabsItem;
    private GameObject prefab_Content;
    private GameObject prefab_ContentItem;
    private GameObject prefab_Slot;
    private GameObject prefab_InventoryItem;

    private Dictionary<string, Sprite> tabIconDic;
    private Dictionary<string, Sprite> materialIconDic;

    public Transform M_Transform { get { return m_Transform; } }
    public Transform Tabs_Transform { get { return tabs_Transform; } }
    public Transform Contents_Transform { get { return contents_Transform; } }
    public Transform Center_Transform { get { return center_Transform; } }

    public GameObject Prefab_TabsItem { get { return prefab_TabsItem; } }
    public GameObject Prefab_Content { get { return prefab_Content; } }
    public GameObject Prefab_ContentItem { get { return prefab_ContentItem; } }
    public GameObject Prefab_Slot { get { return prefab_Slot; } }
    public GameObject Prefab_InventoryItem { get { return prefab_InventoryItem; } }

    private void Awake()
    {
        m_Transform = gameObject.GetComponent<Transform>();
        tabs_Transform = m_Transform.Find("Left/Tabs").GetComponent<Transform>();
        contents_Transform = m_Transform.Find("Left/Contents").GetComponent<Transform>();
        center_Transform = m_Transform.Find("Center").GetComponent<Transform>();

        prefab_TabsItem = Resources.Load<GameObject>("CraftingTabsItem");
        prefab_Content = Resources.Load<GameObject>("CraftingContent");
        prefab_ContentItem = Resources.Load<GameObject>("CraftingContentItem");
        prefab_Slot = Resources.Load<GameObject>("CraftingSlot");
        prefab_InventoryItem = Resources.Load<GameObject>("InventoryItem");

        tabIconDic = new Dictionary<string, Sprite>();
        materialIconDic = new Dictionary<string, Sprite>();

        // Generate all tabs' icon
        tabIconDic = ResourcesTools.LoadFolderAssets("TabIcon", tabIconDic);
        // Composite map material loading
        materialIconDic = ResourcesTools.LoadFolderAssets("Material", materialIconDic);
    }

    // Search a tab icon by name in dictionary
    public Sprite GetSpriteByName(string name)
    {
        return ResourcesTools.GetAssets(name, tabIconDic);
    }

    // Search material icon sprite by name in dictionary
    public Sprite GetMaterialIconSpriteByName(string name)
    {
        return ResourcesTools.GetAssets(name, materialIconDic);
    }
  
}
