public Part AddPart(string name, string article, decimal price, int stock)
{
    var p = new Part { Name = name, Article = article, Price = price, Stock = stock };
    Parts.Add(p);
    SaveAll();
    return p;
}

public void UpdatePart(Part part, string name, string article, decimal price, int stock)
{
    part.Name = name;
    part.Article = article;
    part.Price = price;
    part.Stock = stock;
    SaveAll();
}

public void DeletePart(Part p)
{
    Parts.Remove(p);
    SaveAll();
}