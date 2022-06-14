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
        // TODO: Understand how badly this performs as we are creating a new array every call to Add()
        //       How does IList<> do this in a performant way?  Is it backed by an array or something else?
        array = array.Append(item).ToArray<T>();
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