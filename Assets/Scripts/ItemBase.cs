using UnityEngine;

public class ItemBase : MonoBehaviour
{
    public ClothingRepository ClothingRepository;

    public enum ClothingSlot { Top, Bottom, Shoes };
    public ClothingSlot Slot;
    public int ClothingIndex;

    void Start()
    {
        ClothingRepository = GameObject.Find("ClothingRepo").GetComponent<ClothingRepository>();
        SetUp();
    }

    public virtual void SetUp() { }
}
