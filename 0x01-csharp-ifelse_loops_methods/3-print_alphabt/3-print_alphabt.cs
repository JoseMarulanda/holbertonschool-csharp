﻿using System;

class Program
{
    static void Main(string[] args)
    {
        char i;
        for (i = 'a'; i <= 'z'; i++) {
            if (i != 'q' && i != 'e') {
                Console.Write("{0}", i);                
            }
            else {
                continue;
            }
        }
    }
}