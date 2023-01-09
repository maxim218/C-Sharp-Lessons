using System;
using System.Text;
using System.Collections;

interface IStorage<T> {
    public void AddElement(T element);
    public int FindElementIndex(Predicate<T> check);
}

class StorageA<T> : IStorage<T> {
    public StorageA() => Console.WriteLine("--A--");
    private List<T> _list = new List<T>();
    public void AddElement(T element) => this._list.Add(element);
    public int FindElementIndex(Predicate<T> check) {
        for (int index = 0; index < _list.Count; index++) {
            T element = _list[index];
            bool ok = check(element);
            if (ok) return index;
        }
        return -1;
    }
}


class StorageB<T> : IStorage<T> {
    public StorageB() => Console.WriteLine("--B--");

    private class Node<K> {
        public K? content = default;
        public Node<K>? next = null;
    }

    private Node<T>? _first = null;
    private Node<T>? _last = null;

    public void AddElement(T element) {
        if (null == _first) {
            _first = new Node<T>();
            _first.content = element;
            _first.next = null;
            _last = _first;
        } else {
            if (null != _last) {
                _last.next = new Node<T>();
                _last.next.content = element;
                _last.next.next = null;
                _last = _last.next;
            }
        }
    }

    public int FindElementIndex(Predicate<T> check) {
        int index = -1;
        Node<T>? current = _first;
        while (null != current) {
            index++;
            if (null != current.content) {
                bool ok = check(current.content);
                if (ok) return index;
            }
            current = current.next;
        }
        return -1;
    }
}

class ProgramMain {
    static void RunStrategy(IStorage <int> storage) {
        storage.AddElement(11);
        storage.AddElement(22);
        storage.AddElement(33);
        storage.AddElement(44);
        storage.AddElement(55);
        Console.WriteLine(storage.FindElementIndex(x => 55 == x));
        Console.WriteLine(storage.FindElementIndex(x => 44 == x));
        Console.WriteLine(storage.FindElementIndex(x => 33 == x));
        Console.WriteLine(storage.FindElementIndex(x => 22 == x));
        Console.WriteLine(storage.FindElementIndex(x => 11 == x));
        Console.WriteLine(storage.FindElementIndex(x => 99 == x));
    }

    static void Main() {
        RunStrategy(new StorageA <int> ());
        Console.WriteLine("\n----------------------------------------\n");
        RunStrategy(new StorageB <int> ());
    }
}
