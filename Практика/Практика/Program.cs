using System;
using System.IO;

namespace main_namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main run");
            run();
        }
        static void run()
        {
            //run_practica_1();
            //run_practica_2();
            //run_practica_3();
            //run_practica_4();
            // run_practica_5();
            // run_practica_6();
            // ../Practica_7
            // run_practica_8();
            // ../Practica_9
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
        static void run_practica_3()
        {
            // С рег выражениями потом покопаюсь
            Practicum_3_1.task_1.run();
            Practicum_3_1.task_2.run();
            
            Practicum_3_2.task_1.run();
        }
        static void run_practica_4()
        {
            Practicum_4_1.task_1.run();
            Practicum_4_2.task_1.run();
            Practicum_4_2.task_2.run();
            Practicum_4_3.task_1.run();
            Practicum_4_4.task_1.run();
            Practicum_4_5.task_1.run();

        }
        static void run_practica_5()
        {
            Practicum_5_1.task_1_and_2.run();
            Practicum_5_2.task_1.run();
        }
        static void run_practica_6()
        {
            Practicum_6_1.task_1.run();
        }

        static void run_practica_8()
        {
            Practicum_8_1.task_1.run();
            Practicum_8_2.task_1.run();
            Practicum_8_3.task_1.run();
        }
    }
}
