using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoublyLinkedList;

public class LinkedList<T>
{
    private Node<T> first;
    private Node<T> last;
    private int count = 0;

    private LinkedList(Node<T> first)
    {
        this.first = first;
        last = first;
        count++;
    }
    public LinkedList(T data) 
        : this(new Node<T>(data))
    {
        
    }

    public void AddFirst(T data)
    {
        Node<T> n = new(data);
        n.After = first;
        first.Before = n;
        first = n;
        count++;
    }
    
    public void AddLast(T data)
    {
        Node<T> n = new(data);
        n.Before = last;
        last.After = n;
        last = last.After;
        count++;
    }
    public T RemoveFirst()
    {
        if (count == 0) throw new Exception(" Empty list");
        Node<T> f = first;
        first = first.After;
        first.Before = null;
        count--;
        return f.Data;
        
    }
    public T RemoveLast()
    {
        if (count == 0) throw new Exception(" Empty list");
        Node<T> l = last;
        last.Before.After = null;
        last = last.Before;
        count--;
        return l.Data;
    }
    public T[] ToArray()
    {
        T[] arr = new T[count];
        Node<T> node = first;
        int br = 0;
        while(node.After != null)
        {
            arr[br] = node.Data;
            node = node.After;
            br++;
        }
        arr[br] = node.Data;
        return arr;
    }
    private class Node<P>
    {
        private P data;
        private Node<P> before;
        private Node<P> after;

        public Node<P> Before { get => before; set => before = value; }
        public Node<P> After { get => after; set => after = value; }
        public P Data { get => data; set => data = value; }

        public Node(P data, Node<P> before, Node<P> after)
        {
            this.data = data;
            this.before = before;
            this.after = after;
        }
        public Node(P data)
        {
            this.data = data;
            before = after = null;
        }
    }
}
