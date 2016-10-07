using System;

public class Product
{
    private string name;
    private decimal price;
    private string imageUrl;

    public string Name
    {
        get
        { return name; }
        set
        { name = value; }
    }

    public decimal Price
    {
        get
        { return price; }
        set
        { price = value; }
    }
    public string ImageUrl
    {
        get
        { return imageUrl; }
        set
        { imageUrl = value; }
    }

    public string GetHtml()
    {
        string htmlString;
        htmlString = "<h1>" + name + "</h1><br>";
        htmlString += "<h3>Costs: " + price.ToString() + "</h3><br>";
        htmlString += "<img src=" + imageUrl + ">";
        return htmlString;
    }

    public Product(string name, decimal price)
    {
        // These parameters have the same name as the internal variables.
        // The "this" keyword is used to refer to the class variables.
        // "this" refers to the current instance of the Product class.
        this.name = name;
        this.price = price;
    }
}

