namespace UML_1Lesson_Part3;

public interface IterableCollection
{
    public Iterator createIterator();
}

public class ConcreteCollection : IterableCollection
{
    public Iterator createIterator()
    {
        throw new NotImplementedException();
    }
}
