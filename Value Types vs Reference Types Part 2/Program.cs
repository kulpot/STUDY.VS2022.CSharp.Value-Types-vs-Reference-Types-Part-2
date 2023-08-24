using System;

//ref link:https://www.youtube.com/watch?v=1luianXVURA&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=9
// stack - low room vs heap - high room storage
// semantics of change between ref/class vs struct/value types
// struct/value types = stack   vs  ref/class types = heap

//class Cow // ref/class
struct Cow  // struct/value
{
    int numSteaks;
    //Udder udder = new Udder();  // ref/class
    Udder udder;    // struct/value types
}

//class Udder     // ref/class
struct Udder  // struct/value
{
    float ouncesOfMilk;
}

///////


class Node      // link list knowledge
//struct Node     // error nodes cycle error -- 
{
    public Node next;
    int theIntInThisNode;
}

class MainClass
{
    static void Main()
    {
        //Cow betsy = new Cow();    // ref/class
        Cow betsy;  // struct/value

        ////////////

        Node first = new Node();
        first.next = new Node();
        first.next.next = new Node();

    }
}