using System;

namespace BezaoOOP
{
    public abstract class StoreItem
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; private set; }
        public string BarCode { get; }
        public string Description { get; private set; }
        public DateTime ExpiryDate { get; }
        public DateTime ManufactureDate { get; }
        public StoreItemType StoreItemType { get; }

        public StoreItem()
        {

        }
        public StoreItem(StoreItemRequest request)
        {
            Id = request.Id;
            Name = request.Name;
            Price = request.Price;
            Description = request.Description;
            ManufactureDate = request.ManufactureDate;
            StoreItemType = request.StoreItemType;
            ExpiryDate = request.StoreItemType == StoreItemType.Diary ? DateTime.Now.AddMonths(6)
                : request.StoreItemType == StoreItemType.Electronics ? DateTime.Now.AddMonths(24)
                : request.StoreItemType == StoreItemType.Alcohol ? DateTime.Now.AddYears(105) : DateTime.Now;
        }
    }

    public class StoreItemRequest
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; private set; }
        public string BarCode { get; }
        public string Description { get; private set; }
        public DateTime ManufactureDate { get; }

        public StoreItemType StoreItemType { get; }
    }

    public enum StoreItemType
    {
        Diary = 1,
        Electronics,
        Alcohol
    }

    public class Store
    {

        //Cash Register
        //Employees 
        //Customers
        //StoreItems
        //Name
        //Location
        //Rating
        //Shopping Cart
        //Inventory


        // Sell
        // Give Discount
        // Add Store Items
        // Remove expired store items
        // Update Inventory
        // Get details from the Inventory
    }

}
