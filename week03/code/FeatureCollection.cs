using Microsoft.VisualBasic;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary

    public Features[] Features {get; set;}
}

public class Features{
    public Information Properties {get; set;}
}
public class Information
{
    public string Place {get; set;}
    public decimal Mag {get; set;}
}