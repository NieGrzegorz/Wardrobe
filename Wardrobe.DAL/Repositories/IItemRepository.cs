using System;
using System.Collections.Generic;
using System.Text;
using Wardrobe.BL;

namespace Wardrobe.DAL.Repositories
{
    public interface IItemRepository: IDisposable
    {
        IEnumerable<Item> GetItems();

        Item GetItemByID(int studentId);

        void InsertItem(Item item);

        void DeleteItem(int itemID);

        void UpdateItem(Item item);

        void Save();
    }
}
