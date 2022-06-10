using System.Text;
using System.Reflection;

class MattsList<T>
{
    private T[] array;
    public MattsList()
    {
        array = new T[10];
    }

    public void Add(T item)
    {
        // TODO: Figure out how to properly dispose of array (value type)
        var newArray = array.Append(item).ToArray<T>();
        array = newArray;
        newArray = null;
    }

    public void Set(T item, int index)
    {
        array[index] = item;
    }

    public int Size()
    {
        return array.Count<T>();
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