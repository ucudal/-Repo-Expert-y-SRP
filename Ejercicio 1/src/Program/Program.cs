﻿using System;

namespace SRP
{
    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns", "Erich Gamma & Others", "001-034");
            Book book2 = new Book("Pro C#", "Troelsen", "001-035");
            library agora = new library();
            book1.ShelveBook("A", "7");
            book2.ShelveBook("B", "3");
            agora.ShelveBook(book1);
            agora.ShelveBook(book2);
        }
    }
}