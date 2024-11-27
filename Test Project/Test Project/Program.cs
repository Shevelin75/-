using System;
using System.Collections.Generic;
using InspectorLib;

namespace Test_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionInsp inspector = new FunctionInsp();

            Console.WriteLine($"Главный инспектор: {inspector.GetInspector()}");
            Console.WriteLine($"Название автоинспекции: {inspector.GetCarInspection()}");

            bool inspectorChanged = inspector.SetInspector("Миронов А.В.");
            Console.WriteLine($"Инспектор изменен: {inspectorChanged}");
            Console.WriteLine($"Новый главный инспектор: {inspector.GetInspector()}");

            int randomNumber = inspector.GenerateRandomNumber();
            string generatedNumber = inspector.GenerateNumber('А', randomNumber);
            Console.WriteLine($"Сгенерированный госномер: {generatedNumber}");

            List<string> workersList = inspector.GetWorker();
            Console.WriteLine("Список сотрудников:");
            foreach (string worker in workersList)
            {
                Console.WriteLine(worker);
            }

            bool workerAdded = inspector.AddWorker("Смирнов П.П.");
            Console.WriteLine($"Сотрудник добавлен: {workerAdded}");


            Console.ReadKey();
        }
    }
}
