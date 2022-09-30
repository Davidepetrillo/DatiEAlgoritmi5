using DatiEAlgoritmi5;


/*
 * Two-way circular list
 * Struttura di archiviazione a catena di una tabella lineare. 
 * I nodi sono collegati in serie da due direzioni ed è collegato per formare un anello
 * Ogni nodo è composto da dati, punta al nodo precedente e punta al nodo succesivo
 */


class TestDoubeCircleLink
{
    private static Node tail;
    private static Node head;

    public static void Init()
    {
        head = new Node("A");
        head.next = null;
        head.prev = null;

        Node nodeB = new Node("B");
        nodeB.next = null;
        nodeB.prev = head;
        head.next = nodeB;

        Node nodeC = new Node("C");
        nodeC.next = null;
        nodeC.prev = nodeB;
        nodeB.next = nodeC;

        tail = new Node("D");
        tail.next = head;
        tail.prev = nodeC;
        nodeC.next = tail;
        head.prev = tail;

    }

    public static void Print()
    {
        Node p = head;

        do // Stampa dall'inizio alla fine
        {
            Console.Write(p.data + " -> ");
            p = p.next;

        } while (p != head);

        Console.Write(p.data + " \n\n");

        p = tail;

        do // Stampa dalla fine all'inizio
        {
            Console.Write(p.data + " -> ");
            p = p.prev;

        } while (p != tail);

        Console.Write(p.data + " \n\n");
    }

    public static void Main(string[] args)
    {
        Init();
        Print();
    }
}