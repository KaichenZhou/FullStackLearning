/*
Test your Knowledge
1. Describe the problem generics address.
By using a generic type parameter T, you can write a single class that other client code can use without incurring the cost or risk of runtime casts or boxing operations

2. How would you create a list of strings, using the generic List class?
GenericList<string> list = new GenericList<string>();
list.Add("");

3.How many generic type parameters does the Dictionary class have?
Two. Generic type parameters, or type parameters, are the placeholders in a generic type or method definition. 
The System.Collections.Generic.Dictionary<TKey,TValue> generic type has two type parameters, TKey and TValue, 
that represent the types of its keys and values.

4.True / False.When a generic class has multiple type parameters, they must all match. 
T

5. What method is used to add items to a List object?
List<T>.Add(T) Method

6. Name two methods that cause items to be removed from a List.
List<T>.Remove(T) Method
List<T>.Clear Method

7. How do you indicate that a class has a generic type parameter?
class DataStore<T>
{
    public T Data { get; set; }
}

the DataStore is a generic class. 
T is called type parameter, which can be used as a type of fields, properties, method parameters, return types, and delegates in the DataStore class. 
For example, Data is generic property because we have used a type parameter T as its type instead of the specific data type.

8. True/False. Generic classes can only have one generic type parameter.
F

9. True/False. Generic type constraints limit what can be used for the generic type.
T

10. True/False. Constraints let you use the methods of the thing you are constraining to.
T

Practice working with Generics
1. Create a custom Stack class MyStack<T> that can be used with any data type which
has following methods
1. int Count()
2. T Pop()
3. Void Push()

using System.Collections;
public class MyStack<T>
{
    MyList<T> t = new MyList<T>();

    int Count()
    {
        return t.Count;
    }
    T Pop()
    {
        T value = t.First.Value;
        t.RemoveFirst();
        return value;
    }
    void Push(T value)
    {
        t.AddFirst(value);
    }
}



2. Create a Generic List data structure MyList<T> that can store any data type.
Implement the following methods.
1. void Add (T element)
2. T Remove (int index)
3. bool Contains (T element)
4. void Clear ()
5. void InsertAt (T element, int index)
6. void DeleteAt (int index)
7. T Find (int index)

public class MyList<T>
{
    T[] list;
    int size = 0, 
    int capacity;
    
    void Resize()
    {

    }
    void Add(T element)
    {
        if (size == capacity)
        {
            Resize();
        }
        list[size] = element;
        size++;
    }

    T Remove (int index)
    {
        
        for (int i = index; i < size; i++)
        {
            if (i != size - 1)
            {
                list[i] = list[i + 1];
            }
            else
            {
                list[i] = default(T);
            }
        }
        size--;
        return list[index];
    }

    bool Contains (T element)
    {
        for (int i = 0; i < size; i++)
        {
            T currentValue = list[i];
            if (currentValue.Equals(element))
            {
                return true;
            }
        }
        return false;
    }
    void Clear()
    {
        list = new T[capacity];
        size = 0;
    }
    void InsertAt (T element, int index)
    {
        if (size == capacity)
        {
            Resize();
        }

        for (int i = size; i > index; i--)
        {
            list[i] = list[i - 1];
        }

        list[index] = element;
        size++;
    }
    void DeleteAt (int index)
    {
        for (int i = index; i < size - 1; i++)
        {
            list[i] = list[i + 1];
        }

        list[size - 1] = default(T);
        size--;
    }
    T Find (int index)
    {
        T element = list[index];
        return element;
    }
}




3. Implement a GenericRepository<T> class that implements IRepository<T> interface
that will have common /CRUD/ operations so that it can work with any data source
such as SQL Server, Oracle, In-Memory Data etc. Make sure you have a type constraint
on T were it should be of reference type and can be of type Entity which has one
property called Id. IRepository<T> should have following methods
1. void Add(T item)
2. void Remove(T item)
3. Void Save()
4. IEnumerable<T> GetAll()
5. T GetById(int id)


public class PeopleContext: DbContext {
    public PeopleContext(DbContextOptions options): base(options) {}
    public DbSet < Person > Person {
        get;
        set;
    }
    public DbSet < Address > Address {
        get;
        set;
    }
    
}
public class GenericRepository < T > : IRepository < T > where T: class 
{
    protected readonly PeopleContext context;
    public GenericRepository(PeopleContext context)
    {
        this.context = context;
    }
    public void Add(T entity){
    context.Set < T > ().Add(entity);
    }
    public void Remove(T entity) {
    context.Set < T > ().Remove(entity);
    }
    public IEnumerable<T> GetAll()
    {
        return context.Set<T>().ToList();
    }
}

*/