using UnityEngine;

public class ClothesController : ItemBase
{

    SpriteRenderer SprRen;
    bool Equipped = false;

    public override void SetUp()
    {
        SprRen = GetComponent<SpriteRenderer>();
        SprRen.sprite = ClothingRepository.TopUnequippedSprites[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
