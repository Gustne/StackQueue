Stak stak = new Stak();


stak.Push(49);
stak.Push(3);
stak.Push(4);
Console.WriteLine(stak.ToString());

Console.WriteLine(stak.Pop());
Console.WriteLine(stak.Pop());
Console.WriteLine(stak.Pop());


Koe koe = new Koe();

koe.Enqueue(5);
koe.Enqueue(6);
koe.Enqueue(7);

Console.WriteLine(koe.ToString());
Console.WriteLine(koe.Dequeue());
Console.WriteLine(koe.Dequeue());
Console.WriteLine(koe.Dequeue());
Console.WriteLine(koe.Dequeue());

class Stak
{
    private Node top;

    public Stak()
    {
        top = null;
    }

    public Stak(Node top)
    {
        this.top = top;
    }

    public void Push(int value)
    {
        Node node = new Node(value, top);
        node.data = value;
        node.next = top;
        top = node;
    }

    public int? Pop()
    {
        if (top != null)
        {
            int value = top.data;
            top = top.next;
            return value;
        }
        else
        {
            return null;
        }
    }

    public override string ToString()
    {
        String str = "fra toppen er der følgende i stakken: ";
        bool firstInput = true;
        Node temp = this.top;
        while (temp != null)
        {
            if (firstInput)
            {
                str = str + temp.ToString();
                firstInput = false;
            }
            else
            {
                str = str + ", " + temp.ToString();
            }

            temp = temp.next;
        }

        return str;
    }
}


class Koe
{

    private Node head;
    private Node tail;
    private int count;

    public Koe()
    {
        this.head = null;
        this.tail = null;
        count = 0;
    }

    public void Enqueue(int value)
    {
        if (count == 0)
        {
            this.head = new Node(value, null);
            count++;
        }
        else if (count == 1)
        {
            this.tail = new Node(value, null);
            this.head.next = this.tail;
            count++;
        }
        else
        {
            this.tail.next = new Node(value, null);
            this.tail = this.tail.next;
            count++;
        }

    }

    public int? Dequeue()
    {
        if(count == 0)
        {
            return null;
        }
        else if (count == 1)
        {
            int value = this.head.data;
            this.head = null;
            count--;
            return value;
        }
        else
        {
            int value = this.head.data;
            this.head = this.head.next;
            count--;
            return value;
            
        }

    }

    public override string ToString()
    {
        String str = "Køen er følgende: ";
        bool firstInput = true;
        Node temp = this.head;
        while (temp != null)
        {
            if (firstInput)
            {
                str = str + temp.ToString();
                firstInput = false;
            }
            else
            {
                str = str + ", " + temp.ToString();
            }
            
            temp = temp.next;

        }

        return str;
    }

}
public class Node
{
    public Node()
    {
        this.data = 0;
        this.next = null;
    }
    public Node(int data, Node next)
    {
        this.data = data;
        this.next = next;
    }

    public override string ToString()
    {
        return $"{this.data}" ;
    }
    public int data { get; set; }
    public Node next { get; set; }

}