using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Wardrobe.BL;
using Wardrobe.CommonGUI;
using Wardrobe.CommonGUI.Base;
using Wardrobe.DAL;
using Wardrobe.DAL.Repositories;

namespace WardrobeGUI.ViewModels
{
    class AddItemViewModel : ViewModelBase
    {
        private IItemRepository itemRepository;

        public AddItemViewModel()
        {
            itemRepository = new ItemRepository(new WardrobeContext());
        }

        public AddItemViewModel(IItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
            AddItemCommand = new DelegateCommand(BtnTest);
        }

        public string ItemName { get; set; }
        public string Brand { get; set; }
        public ItemCategory SelectedCategory { get; set; }

        public ICommand AddItemCommand; 

        private void AddItem()
        {
            var item = new Item();
            item.Brand = this.Brand;
            item.ItemName = this.ItemName;
            item.Category = this.SelectedCategory;

            itemRepository.InsertItem(item);
        }

        private void BtnTest()
        {
            MessageBox.Show("Clicked");
        }
    }
}
