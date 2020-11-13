﻿using System;
using System.IO;

namespace main_namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            //run_practica_1();
            run_practica_2();
        }

        static void run_practica_1()
        {
            Practicum_1_1.task_1.run();
            Practicum_1_1.task_2.run();

            Practicum_1_2.task_1.run();
            Practicum_1_2.task_2.run();
            Practicum_1_2.task_3.run();

            Practicum_1_3.task_1.run();

            Practicum_1_4.task_1.run();
            Practicum_1_4.task_2.run();
        }

        static void run_practica_2()
        {
            string path = @"C:\users\admin\Documents";
            Practicum_2_1.task_1.run(path);
            Practicum_2_1.task_2.run();

            string file = @"C:\testfile.txt";
            Practicum_2_2.task_1.run(file);
            Practicum_2_2.task_2.run(file);


            string file_txt = @"C:\Users\Admin\Documents\code\1\1.txt";
            string file_gz = @"C:\Users\Admin\Documents\code\1\1.txt.gz";
            string file_out_txt = @"C:\Users\Admin\Documents\code\1\out.txt";
            Practicum_2_3.task_1.run(file_txt, file_gz);
            Practicum_2_3.task_2.run(file_gz, file_out_txt);

            //Practicum_2_4.task_1.run();
            Practicum_2_4.task_2.run();
        }
    }


   
}
