using System;
using System.Collections.Generic;


//Дано список List <T> з об'єктами одного типу Obj, у якого в свою чергу є властивість Id.
//Організувати пошук для знаходження елемента колекції по його властивості

namespace Base;

class Program
{
    static void Main(string[] args)
    {
        List<Obj> objectsList = new List<Obj>()
        {
            new Obj () {Object="sunflower", Id = 1256},
            new Obj () {Object="snowdrop", Id = 8737},
            new Obj () {Object="bluebell", Id = 3780},
            new Obj () {Object="aster", Id = 5893},
            new Obj () {Object="daffodil", Id = 1909},
            new Obj () {Object="rose", Id = 2716},
            new Obj () {Object="dasy", Id = 6503},
        };
        foreach (Obj el in objectsList)
        {

            Console.WriteLine(el.Id);
        }
        Console.Write("Виберіть Id об'єкта: ");
        int id = Int32.Parse(Console.ReadLine());
        var test = objectsList.FirstOrDefault(i=> i.Id==id);
        Console.WriteLine("Назва шуканого об'єкта " + test.Object);
        Console.ReadKey();
    }
    
} 
class Obj
{
    
    public string Object { get; set; }
    public int Id { get; set; }

}


