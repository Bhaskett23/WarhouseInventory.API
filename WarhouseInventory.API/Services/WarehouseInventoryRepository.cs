﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseInventory.API.Context;
using WarehouseInventory.API.Models;

namespace WarehouseInventory.API.Services
{
    public class WarehouseInventoryRepository : IWarehouseInventoryRepository
    {
        private readonly WarehouseInventoryContext _context;

        public WarehouseInventoryRepository()
        {
            _context = new WarehouseInventoryContext();
        }

        public Item GetItem(int itemId)
        {
            return _context.Items.FirstOrDefault(x => x.Id == itemId);
        }

        public IEnumerable<Item> GetItems()
        {
            return _context.Items;
        }

        public void AddItem(Item item)
        {
            item.Id = _context.Items.Max(x => x.Id) + 1;
            _context.Items.Add(item);
        }

        public void UpdateItem(ItemForCreation item)
        {
            
        }
    }
}
