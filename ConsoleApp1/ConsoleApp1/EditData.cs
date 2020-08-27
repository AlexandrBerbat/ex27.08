using System.Data.SqlClient;
using System;
using System.Data;

namespace ConsoleApp1
{
    class EditData
    {
        public void Edit(SqlConnection conn)
        {
            Console.WriteLine("Выберите таблицу для изменения данных:\n" +
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

                    Console.WriteLine("ID фильма для изменения данных:");
                    int Film_FilmID = int.Parse(Console.ReadLine());

                    Console.WriteLine("Название фильма:");
                    string FilmName = Console.ReadLine();
                    Console.WriteLine("Дата релиза:");
                    string Film_ReleaseDate = Console.ReadLine();
                    Console.WriteLine("Страна релиза:");
                    string Film_CountryRelease = Console.ReadLine();
                    string EditExpression1 = String.Format("UPDATE Film SET name = '{0}', releaseDate = '{1}', releaseCountry = '{2}' WHERE filmID = {3} ", FilmName, Film_ReleaseDate, Film_CountryRelease, Film_FilmID);
                    conn.Open();

                    SqlCommand command = new SqlCommand(EditExpression1, conn);
                    int number = command.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Обновлено объектов: {0}", number);
                    break;
                case "2":

                    Console.WriteLine("ID фильма для изменения данных:");
                    int Film_Timetable_FilmID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Дата показа для изменения:");
                    string Film_Timetable_ShowDate = Console.ReadLine();


                    Console.WriteLine("Новый ID фильма:");
                    int Film_Timetable_FilmID_New = int.Parse(Console.ReadLine());
                    Console.WriteLine("Новая дата показа:");
                    string Film_Timetable_ShowDate_New = Console.ReadLine();

                    string EditExpression2 = String.Format("UPDATE Film_Timetable SET filmID = {0}, showDate = '{1}' WHERE filmID = {2} AND showDate = '{3}' ", Film_Timetable_FilmID_New, Film_Timetable_ShowDate_New, Film_Timetable_FilmID, Film_Timetable_ShowDate);
                    conn.Open();

                    SqlCommand command2 = new SqlCommand(EditExpression2, conn);
                    int number2 = command2.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Обновлено объектов: {0}", number2);

                    break;
                case "3":

                    Console.WriteLine("ID актера для изменения данных:");
                    int Actor_ActorID = int.Parse(Console.ReadLine());

                    Console.WriteLine("Новое имя актера:");
                    string ActorName = Console.ReadLine();
                    Console.WriteLine("Новая фамилия актера:");
                    string ActorSecName = Console.ReadLine();
                    Console.WriteLine("Новая дата рождения актера:");
                    string ActorDateOFBirth = Console.ReadLine();

                    string EditExpression3 = String.Format("UPDATE Actor SET name = '{0}', secondName = '{1}', dateOfBirth = '{2}' WHERE actorID = {3} ", ActorName, ActorSecName, ActorDateOFBirth, Actor_ActorID);
                    conn.Open();

                    SqlCommand command3 = new SqlCommand(EditExpression3, conn);
                    int number3 = command3.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Обновлено объектов: {0}", number3);

                    break;
                case "4":

                    Console.WriteLine("ID фильма для изменения данных:");
                    int Film_Actor_FilmID = int.Parse(Console.ReadLine());
                    Console.WriteLine("ID актера для изменения:");
                    int Film_Actor_ActorID = int.Parse(Console.ReadLine());


                    Console.WriteLine("новый ID фильма:");
                    int Film_Actor_FilmID_New = int.Parse(Console.ReadLine());
                    Console.WriteLine("новый ID актера:");
                    int Film_Actor_ActorID_New = int.Parse(Console.ReadLine());

                    string EditExpression4 = String.Format("UPDATE Film_Actor SET filmID = {0}, actorID = {1} WHERE filmID = {2} AND actorID = {3}", Film_Actor_FilmID_New, Film_Actor_ActorID_New, Film_Actor_FilmID, Film_Actor_ActorID);
                    conn.Open();

                    SqlCommand command4 = new SqlCommand(EditExpression4, conn);
                    int number4 = command4.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Обновлено объектов: {0}", number4);


                    break;
                case "5":

                    Console.WriteLine("ID режисера для изменения данных:");
                    int Director_DirectorID = int.Parse(Console.ReadLine());

                    Console.WriteLine("Новое имя режисера:");
                    string DirectorName = Console.ReadLine();
                    Console.WriteLine("Новая фамилия режисера:");
                    string DirectorSecName = Console.ReadLine();
                    Console.WriteLine("Новая дата рождения режисера:");
                    string DirectorDateOFBirth = Console.ReadLine();

                    string EditExpression5 = String.Format("UPDATE Director SET name = '{0}', secondName = '{1}', dateOfBirth = '{2}' WHERE directorID = {3} ", DirectorName, DirectorSecName, DirectorDateOFBirth, Director_DirectorID);
                    conn.Open();

                    SqlCommand command5 = new SqlCommand(EditExpression5, conn);
                    int number5 = command5.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Обновлено объектов: {0}", number5);


                    break;
                case "6":

                    Console.WriteLine("ID фильма для изменения данных:");
                    int Film_Director_FilmID = int.Parse(Console.ReadLine());
                    Console.WriteLine("ID режисера для изменения:");
                    int Film_Director_DirectorID = int.Parse(Console.ReadLine());


                    Console.WriteLine("новый ID фильма:");
                    int Film_Director_FilmID_New = int.Parse(Console.ReadLine());
                    Console.WriteLine("новый ID режисера:");
                    int Film_Director_DirectorID_New = int.Parse(Console.ReadLine());

                    string EditExpression6 = String.Format("UPDATE Film_Director SET filmID = {0}, directorID = {1} WHERE filmID = {2} AND directorID = {3}", Film_Director_FilmID_New, Film_Director_DirectorID_New, Film_Director_FilmID, Film_Director_DirectorID);
                    conn.Open();

                    SqlCommand command6 = new SqlCommand(EditExpression6, conn);
                    int number6 = command6.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Обновлено объектов: {0}", number6);

                    break;
                default:
                    Console.WriteLine("Выбранной таблицы не существует!");
                    break;
            }

        }

    }
}
