namespace UML_1Lesson_Part3;

public interface Iterator
{
    public void getNext();
    public bool hasMore();
}

public class ConcreteIterator : Iterator
{
    private ConcreteCollection collection;
    private object iterationState;

    public ConcreteIterator(ConcreteCollection c)
    {
        collection = c;
    }
    public void getNext()
    {
        throw new NotImplementedException();
    }

    public bool hasMore()
    {
        throw new NotImplementedException();
    }
}
