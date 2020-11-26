using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wardrobe.BL;

namespace Wardrobe.DAL.Repositories
{
    public class ItemRepository : IItemRepository, IDisposable
    {
        public WardrobeContext context; 

        public ItemRepository(WardrobeContext context)
        {
            this.context = context;
        }

        public void DeleteItem(int itemID)
        {
            Item item = context.Items.Find(itemID);
            context.Items.Remove(item);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Item GetItemByID(int itemId)
            => context.Items.Find(itemId);
        

        public IEnumerable<Item> GetItems()
            => context.Items.ToList();

        public void InsertItem(Item item)
        {
            context.Items.Add(item);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateItem(Item item)
        {
            context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        private bool disposed = false; 

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }
    }
}
