using System;

namespace Wardrobe.BL
{
    public enum ItemCategory
    {
        Footwear,
        Clothes,
        Accessory,
        Jewlery
    }

    public class Item
    {

        public string ItemName { get; set; }

        public string Brand { get; set; }

        public ItemCategory Category { get; set; }
    }
}
