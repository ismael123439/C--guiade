using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    pila();
    return;
  }
  public static void pila (){
    List<int> myList = new List<int>();
    myList.Add(1);
    myList.Add(2);
    myList.Add(3);
    myList.Add(4);
    Stack<int> myStack = new Stack<int>();
    foreach(var item in myList)
      myStack.Push(item);
    foreach (var item in myStack)
      Console.Write(item + ",");
    return;
  }
}