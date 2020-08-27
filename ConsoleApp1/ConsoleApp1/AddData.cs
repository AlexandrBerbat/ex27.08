using System.Data.SqlClient;
using System;
using System.Data;

namespace ConsoleApp1
{
    class AddData
    {
        public void Add(SqlConnection conn)
        {
            Console.WriteLine("Выберите таблицу для добавления данных:\n" +
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
                    Console.WriteLine("Название фильма:");
                    string FilmName = Console.ReadLine();
                    Console.WriteLine("Дата релиза:");
                    string ReleaseDate = Console.ReadLine();
                    Console.WriteLine("Страна релиза:");
                    string ReleaseCountry = Console.ReadLine();
                    string AddExpression1 = String.Format("INSERT INTO Film(name, releaseDate, releaseCountry) VALUES('{0}','{1}','{2}')", FilmName, ReleaseDate, ReleaseCountry);
                    conn.Open();

                    SqlCommand command = new SqlCommand(AddExpression1, conn);
                    int number = command.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Добавлено объектов: {0}", number);
                    break;
                case "2":
                    Console.WriteLine("ID фильма:");
                    int FilmID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Дата показа:");
                    string ShowDate = Console.ReadLine();
                    string AddExpression2 = String.Format("INSERT INTO Film_Timetable(filmID, showDate) VALUES('{0}','{1}')", FilmID, ShowDate);
                    conn.Open();

                    SqlCommand command2 = new SqlCommand(AddExpression2, conn);
                    int number2 = command2.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Добавлено объектов: {0}", number2);

                    break;
                case "3":
                    Console.WriteLine("Имя актера:");
                    string ActorName = Console.ReadLine();
                    Console.WriteLine("Фамилия актера:");
                    string ActorSecName = Console.ReadLine();
                    Console.WriteLine("Дата рождения:");
                    string DateOfBirth = Console.ReadLine();
                    string AddExpression3 = String.Format("INSERT INTO Actor(name, secondName, dateOfBirth) VALUES('{0}','{1}','{2}')", ActorName, ActorSecName, DateOfBirth);
                    conn.Open();

                    SqlCommand command3 = new SqlCommand(AddExpression3, conn);
                    int number3 = command3.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Добавлено объектов: {0}", number3);
                    break;
                case "4":
                    Console.WriteLine("ID фильма:");
                    int Film_ActorID = int.Parse(Console.ReadLine());
                    Console.WriteLine("ID актера:");
                    int ActorID = int.Parse(Console.ReadLine());
                    string AddExpression4 = String.Format("INSERT INTO Film_Actor(filmID, actorID) VALUES({0},{1})", Film_ActorID, ActorID);
                    conn.Open();

                    SqlCommand command4 = new SqlCommand(AddExpression4, conn);
                    int number4 = command4.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Добавлено объектов: {0}", number4);

                    break;
                case "5":
                    Console.WriteLine("Имя режисера:");
                    string DirectorName = Console.ReadLine();
                    Console.WriteLine("Фамилия режисера:");
                    string DirectorSecName = Console.ReadLine();
                    Console.WriteLine("Дата рождения:");
                    string DirectorDateOfBirth = Console.ReadLine();
                    string AddExpression5 = String.Format("INSERT INTO Director(name, secondName, dateOfBirth) VALUES('{0}','{1}','{2}')", DirectorName, DirectorSecName, DirectorDateOfBirth);
                    conn.Open();

                    SqlCommand command5 = new SqlCommand(AddExpression5, conn);
                    int number5 = command5.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Добавлено объектов: {0}", number5);


                    break;
                case "6":
                    Console.WriteLine("ID фильма:");
                    int Film_DirectorID = int.Parse(Console.ReadLine());
                    Console.WriteLine("ID режисера:");
                    int DirectorID = int.Parse(Console.ReadLine());

                    string AddExpression6 = String.Format("INSERT INTO Film_Director(filmID, directorID) VALUES({0},{1})", Film_DirectorID, DirectorID);
                    conn.Open();

                    SqlCommand command6 = new SqlCommand(AddExpression6, conn);
                    int number6 = command6.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Добавлено объектов: {0}", number6);

                    break;
                default:
                    Console.WriteLine("Выбранной таблицы не существует!");
                    break;
            }


        }
    }
}
