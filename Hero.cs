class Hero : object
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Role { get; set; }
    public string? Secondary { get; set; }
    public string? Image { get; set; }

    // START HERE: Override Equals()

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            throw new NullReferenceException();
        }

        Hero tempObj = null;

        try
        {
            tempObj = (Hero)obj;
        }
        catch
        {
            return false;
        }

        if (tempObj.Id == this.Id)
        {
            return true;
        }

        return false;
    }
}
