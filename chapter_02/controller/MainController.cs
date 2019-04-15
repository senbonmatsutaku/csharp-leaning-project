using chapter_02.domain.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chapter_02.controller
{
    public class MainController
    {
        private const int EXIT_PROCESS = 999;

        public static void Run()
        {
            try
            {
                while (true)
                {
                    int employeeId = GetEmployeeId();
                    if (employeeId == EXIT_PROCESS)
                    {
                        break;
                    }
                    else if (!IsValidEmployeeId(employeeId))
                    {
                        Console.WriteLine($"社員番号 {employeeId} さんは課題実施対象者ではありません。");
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine($"{employeeId} さんの課題を確認します。");
                            int taskNumber = GetTaskNumber();
                            if (taskNumber == EXIT_PROCESS)
                            {
                                break;
                            }
                            else if (!IsValidTaskNumber(taskNumber))
                            {
                                Console.WriteLine($"問 {taskNumber} は存在しません。");
                            }
                            else
                            {
                                DoOperationCheck(employeeId, taskNumber);
                            }
                        }
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

        private static int GetEmployeeId()
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

        private static int GetTaskNumber()
        {
            Console.Write("何番の問を確認しますか？(999で終了): ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int taskNumber))
            {
                return taskNumber;
            }
            else
            {
                throw new FormatException("入力文字列が正しい形式ではありませんでした。");
            }
        }

        private static bool IsValidTaskNumber(int taskNumber)
        {
            List<int> taskList = new List<int> { 1, 2, 3, 4 };
            return taskList.Any(x => x.Equals(taskNumber));
        }

        private static void DoOperationCheck(int employeeId, int taskNumber)
        {
            Console.WriteLine($"問 {taskNumber} を確認します。");
            Console.WriteLine("処理を開始しました。");
            Console.WriteLine("-------------------");
            ITask task = GetTaskService(employeeId);
            switch (taskNumber)
            {
                case 1:
                    task.LearnOperatorPriority();
                    break;
                case 2:
                    task.LearnTypeConversion();
                    break;
                case 3:
                    task.FortuneGame();
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"問 {taskNumber} は存在しません。");
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("処理を終了しました。");
        }

        private static ITask GetTaskService(int employeeId)
        {
            switch (employeeId)
            {
                case 92:
                    return new TaskServiceImplementedBy092();
                case 667:
                    return new TaskServiceImplementedBy667();
                default:
                    throw new ArgumentNullException($"{employeeId} さんの課題実装は存在しません。");
            }
        }
    }
}
