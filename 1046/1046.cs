﻿using System;
using System.Collections.Generic;

namespace beecrowd {
    class URI1042 {

        public static void Main (string[] args) {

            string[] ent = Console.ReadLine().Split(' ');

            int A = int.Parse(ent[0]);
            int B = int.Parse(ent[1]);

            if (A > B){

                A = A + 24;
                Console.WriteLine(A-B);

            } else {
                Console.WriteLine(A-B);
            }

        }
    }
}