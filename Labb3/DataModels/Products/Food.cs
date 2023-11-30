﻿using Labb3ProgTemplate.Enums;

namespace Labb3ProgTemplate.DataModels.Products;

public class Food : Product
{
    public override ProductTypes Type { get; }

    public Food(string name, double price) : base(name, price)
    {
        Type = ProductTypes.Food;
    }

}