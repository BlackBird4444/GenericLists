using System.Text;
using System.Reflection;

class GenericList<T>
{
    private T[] array;
    public GenericList()
    {
        array = Array.Empty<T>();
    }

    public void Add(T item)
    {
        if (item == null)
        {
            throw new ArgumentException("GenericList does not allow for null values to be added.");
        }
        // TODO: Understand how badly this performs as we are creating a new array every call to Add()
        //       How does IList<> do this in a performant way?  Is it backed by an array or something else?
        array = array.Append(item).ToArray<T>();
    }

    public void Remove(T item)
    {
        if (item == null)
        {
            throw new ArgumentException("GenericList does not allow for null values to be added.");
        }

        var itemToRemove = array.FirstOrDefault<T>(x =>
        {
            return x!.Equals(item);
        });

        if (itemToRemove == null)
        {
            return;
        }

        // TODO: Is there a better way than enumerating?
        var newArray = Array.Empty<T>();
        foreach (var thing in array)
        {
            if (!thing.Equals(itemToRemove))
            {
                newArray = newArray.Append(thing).ToArray<T>();
            }
        }
        array = newArray;
    }

    public void Set(T item, int index)
    {
        array[index] = item;
    }

    public int Size()
    {
        return array.Length;
    }

    // TODO: See if there is a faster way than using Reflection
    public override string ToString()
    {
        var output = new StringBuilder();
        foreach (T item in array)
        {

            // if null move to next item in array
            if (item == null)
            {
                continue;
            }

            // loop through properties of item
            foreach (PropertyInfo property in item.GetType().GetProperties())
            {
                output.Append(property.Name + ":" + property.GetValue(item) + ",");
            }
        }
        return output.ToString();
    }
}