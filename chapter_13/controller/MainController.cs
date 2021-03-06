﻿using chapter_13.domain.service;
using chapter_13.domain.service.student092;
using chapter_13.domain.service.student667;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chapter_13.controller
{
    class MainController
    {
        private const int EXIT_PROCESS = 999;

        public static void Run()
        {
            try
            {
                while (true)
                {
                    int employeeId = getEmployeeId();
                    if (employeeId == EXIT_PROCESS)
                    {
                        break;
                    }
                    else if (!IsValidEmployeeId(employeeId))
                    {
                        Console.WriteLine($"社員番号{employeeId}さんは課題実施対象者ではありません。");
                    }
                    else
                    {
                        Console.WriteLine($"{employeeId}さんの課題を確認します。");
                        MakeCharacter(employeeId);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                System.Environment.ExitCode = 1;
            }
            finally
            {
                Console.WriteLine("プログラムを終了します。");
            }
        }

        private static int getEmployeeId()
        {
            Console.WriteLine("誰の課題を確認しますか？");
            Console.Write("社員番号(999で終了): ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int employeeId))
            {
                return employeeId;
            }
            else
            {
                throw new FormatException("入力文字列が正しい形式ではありませんでした。");
            }
        }

        private static bool IsValidEmployeeId(int employeeId)
        {
            List<int> employeesList = new List<int> { 92, 667 };
            return employeesList.Any(x => x.Equals(employeeId));
        }

        private static void MakeCharacter(int employeeId)
        {
            Console.WriteLine($"{employeeId}さんの課題");

            switch (employeeId)
            {
                case 92:
                    RunTask(new Task092());
                    break;
                case 667:
                    RunTask(new Task667());
                    break;
                default:
                    throw new ArgumentNullException($"{employeeId}さんの課題は存在しません。");
            }
        }

        private static void RunTask(ITask task)
        {
            Information("１");
            String s1 = "・？";
            Console.WriteLine($"判定文字列：{s1}");
            Console.WriteLine($"結果　　　：{task.Task1(s1)}");

            Information("２");
            String s2 = "A10";
            Console.WriteLine($"判定文字列：{s2}");
            Console.WriteLine($"結果　　　：{task.Task2(s2)}");

            Information("３");
            String s3 = "UCYZ";
            Console.WriteLine($"判定文字列：{s3}");
            Console.WriteLine($"結果　　　：{task.Task3(s3)}");
        }

        private static void Information(String taskNumber)
        {
            Console.WriteLine($"-------------------");
            Console.WriteLine($"課題{taskNumber}の確認");
            Console.WriteLine($"-------------------");
            Console.WriteLine($"次に進む（リターンキーを押してください。）");
            var input = Console.ReadLine();
        }
    }
}
