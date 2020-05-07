using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading;

namespace TDD.Dll
{
   public class MyStack
   {
       private int _currentIndex;
       private object[] _items;

       public MyStack(int capacity)
       {
           _items = new object [capacity];
           _currentIndex = 0;
       }

       public void Push(object x)
       {
           _items[_currentIndex] = x;
           _currentIndex++;
       }


       public object Pop()
       {
           if (_currentIndex <= 0)
           {
               throw new Exception();
           }

           var item = _items[_currentIndex - 1];
           _currentIndex--;
           return item;


       }
   }
}
