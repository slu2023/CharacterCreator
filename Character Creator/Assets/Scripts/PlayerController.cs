using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public SpriteRenderer ArmorRenderer;
    public SpriteRenderer WeaponRenderer;
    public SpriteRenderer MagicRenderer;

    public void SetArmor(Sprite newSprite)
    {
        ArmorRenderer.sprite = newSprite;
        // GameObject.SetActive(false);
        // GameObject.SetActive(true);
        // GameObject.SetActive(false);
    
    }

    public void SetWeapon(Sprite newSprite)
    {
        WeaponRenderer.sprite = newSprite;
        // GameObject.SetActive(true);
        // GameObject.SetActive(false);
        // GameObject.SetActive(false);
    }

    public void SetMagic(Sprite newSprite)
    {
        MagicRenderer.sprite = newSprite;
        // GameObject.SetActive(false);
        // GameObject.SetActive(true);
        // GameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
