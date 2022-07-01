using System;
using System.ComponentModel.DataAnnotations;

public class Articles
{
    public string Category{set;get;}
    public string Color{set;get;}
    public int Price{set;get;}
    public int Id{set;get;}
    public int Count{get;set;}
    public Articles(){}

    public override int GetHashCode()
    {
        return this.Id;
    }

    public override bool Equals(object obj)
    {
        var other = obj as Articles;
        if(obj is null)
            return false;
        return this.Id == other.Id;
    }
}
