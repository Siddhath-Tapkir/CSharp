public class Singlynode<T>
{
    public T data;
    public Singlynode<T> next;

    public Singlynode(T Value)
    {
        this.data = Value;
        this.next = null;
    }
}
public class SinglyLLL<T> : IDisposable
{
    private Singlynode<T> head;
    private Singlynode<T> tail;
    private int iCount;

    public SinglyLLL()
    {
        this.head = null;
        this.tail = null;
        this.iCount = 0;
    }

    public void Dispose()
    {
        while(iCount != 0)
        {
            DeleteFirst();
        }
        Console.WriteLine("Inside Dispose");
    }

    public void InsertFirst(T No)
    {
        Singlynode<T> newn = new Singlynode<T>(No);

        if(this.head == null)
        {
            this.head = newn;
            this.tail = newn;
        }
        else
        {
            newn.next = this.head;
            this.head = newn;
        }
        iCount++;
    }
    
    public void InsertLast(T No)
    {
        Singlynode<T> newn = new Singlynode<T>(No);
        
        if(this.head == null)
        {
            this.head = newn;
            this.tail = newn;
        }
        else
        {
            this.tail.next = newn;
            this.tail = this.tail.next;
        }
        iCount++;
    }

    public void DeleteFirst()
    {
        if(this.head == null && this.tail == null)
        {
            return;
        }
        if(this.head == this.tail)
        {
            this.head = null;
            this.tail = null;
        }
        else
        {
            Singlynode<T> target = null;
            target = this.head;
            this.head = this.head.next;

            target.next = null;
            target = null;
        }
        iCount--;
    }

    public void DeleteLast()
    {
        if(this.head == null && this.tail == null)
        {
            return;
        }
        
        if((this.head.next == null) || (this.head == this.tail))
        {
            this.head = null;
            this.tail = null;
        }
        else
        {
            Singlynode<T> target = this.head;

            while(target.next != this.tail)
            {
                target = target.next;
            }

            this.tail = target;
            this.tail.next = null;
            target = null;
        }
        iCount--;
    }

    public void Display()
    {
        Singlynode<T> temp = this.head;

        while(temp != null)
        {
            Console.Write("|"+temp.data+"|->");
            temp = temp.next;
        }
        Console.WriteLine("NULL");
    }

    public int Count()
    {
        return iCount;
    }

    public void InsertAtPos(T No, int iPos)
    {
        if((iPos == 0) || (iPos > (iCount + 1)))
        {
            Console.WriteLine("Invalid Position");
            return;
        }

        if(iPos < 0)
        {
            iPos = -(iPos);
        }

        if(iPos == 1)
        {
            InsertFirst(No);
            return;
        }

        if(iPos == (iCount + 1))
        {
            InsertLast(No);
            return;
        }

        Singlynode<T> newn = new Singlynode<T>(No);
        Singlynode<T> temp = this.head;

        for(int i = 1; i < (iPos - 1); i++)
        {
            temp = temp.next;
        }

        newn.next = temp.next;
        temp.next = newn;

        iCount++;
    }

    public void DeleteAtPos(int iPos)
    {
        if((iPos == 0) || (iPos > iCount))
        {
            Console.WriteLine("Invalid Position");
            return;
        }

        if(iPos < 0)
        {
            iPos = -(iPos);
        }

        if(iPos == 1)
        {
            DeleteFirst();
            return;
        }

        if(iPos == iCount)
        {
            DeleteLast();
            return;
        }

        Singlynode<T> temp = this.head;
        Singlynode<T> target = null;

        for(int i = 1; i < (iPos - 1); i++)
        {
            temp = temp.next;
        }

        target = temp.next;

        temp.next = target.next;

        target = null;

        iCount--;
    }
}
internal class question56
{
    public static void Main(string []A)
    {
        using(SinglyLLL<int> sobj = new SinglyLLL<int>())
        {

            sobj.InsertFirst(51);
            sobj.InsertFirst(21);
            sobj.InsertFirst(11);


            sobj.Display();

            Console.WriteLine(sobj.Count());
            sobj.InsertAtPos(31,3);


            sobj.Display();

            Console.WriteLine(sobj.Count());
            sobj.DeleteAtPos(3);


            sobj.Display();

            Console.WriteLine(sobj.Count());
        }
        
    }
}