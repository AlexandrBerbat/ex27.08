using System.Data.SqlClient;
using System;
using System.Data;

namespace ConsoleApp1
{
    class DeleteData
    {
        public void Delete(SqlConnection conn)
        {
            Console.WriteLine("Выберите таблицу для удаления данных:\n" +
                "1. Film\n" +
                "2. Film_Timetable\n" +
                "3. Actor\n" +
                "4. Film_Actor\n" +
                "5. Director\n" +
                "6. Film_Director");
            string addChoice = Console.ReadLine();

            switch (addChoice)
            {
                case "1":
                    Console.WriteLine("ID фильма:");
                    int FilmID = int.Parse(Console.ReadLine());

                    string DeleteExpression1 = String.Format("DELETE FROM Film WHERE filmID={0}", FilmID);
                    conn.Open();

                    SqlCommand command = new SqlCommand(DeleteExpression1, conn);
                    int number = command.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Удалено объектов: {0}", number);
                    break;
                case "2":

                    Console.WriteLine("ID фильма:");
                    int Film_Timetable_FilmID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Дата показа для изменения:");
                    string Film_Timetable_ShowDate = Console.ReadLine();

                    string DeleteExpression2 = String.Format("DELETE FROM Film_Timetable WHERE filmID={0} and showDate = '{1}'", Film_Timetable_FilmID, Film_Timetable_ShowDate);
                    conn.Open();

                    SqlCommand command2 = new SqlCommand(DeleteExpression2, conn);
                    int number2 = command2.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Удалено объектов: {0}", number2);

                    break;
                case "3":

                    Console.WriteLine("ID актера:");
                    int ActorID = int.Parse(Console.ReadLine());

                    string DeleteExpression3 = String.Format("DELETE FROM Actor WHERE actorID={0}", ActorID);
                    conn.Open();

                    SqlCommand command3 = new SqlCommand(DeleteExpression3, conn);
                    int number3 = command3.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Удалено объектов: {0}", number3);

                    break;

                case "4":

                    Console.WriteLine("ID фильма:");
                    int Film_Actor_FilmID = int.Parse(Console.ReadLine());
                    Console.WriteLine("ID актера:");
                    int Film_Actor_ActorID = int.Parse(Console.ReadLine());

                    string DeleteExpression4 = String.Format("DELETE FROM Film_Actor WHERE filmID={0} and actorID = {1}", Film_Actor_FilmID, Film_Actor_ActorID);
                    conn.Open();

                    SqlCommand command4 = new SqlCommand(DeleteExpression4, conn);
                    int number4 = command4.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Удалено объектов: {0}", number4);


                    break;
                case "5":

                    Console.WriteLine("ID режисера:");
                    int DirectorID = int.Parse(Console.ReadLine());

                    string DeleteExpression5 = String.Format("DELETE FROM Director WHERE directorID={0}", DirectorID);
                    conn.Open();

                    SqlCommand command5 = new SqlCommand(DeleteExpression5, conn);
                    int number5 = command5.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Удалено объектов: {0}", number5);

                    break;
                case "6":

                    Console.WriteLine("ID фильма:");
                    int Film_Director_FilmID = int.Parse(Console.ReadLine());
                    Console.WriteLine("ID актера:");
                    int Film_Director_DirectorID = int.Parse(Console.ReadLine());

                    string DeleteExpression6 = String.Format("DELETE FROM Film_Director WHERE filmID={0} and directorID = {1}", Film_Director_FilmID, Film_Director_DirectorID);
                    conn.Open();

                    SqlCommand command6 = new SqlCommand(DeleteExpression6, conn);
                    int number6 = command6.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Удалено объектов: {0}", number6);

                    break;
                default:
                    Console.WriteLine("Выбранной таблицы не существует!");
                    break;
            }

        }
    }
}
