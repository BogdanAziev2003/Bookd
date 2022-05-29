using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryApp
{
    class Book
    {
        public int Id;
        public string Name;
        public int Age;
        public string Description;
        public string Author;
        public bool Reserved;

        public Book(int id, string bookName, string bookAuthor, int bookAge, string bookDescription, bool bookReserved)
        {
            Id = id;
            Name = bookName;
            Age = bookAge;
            Description = bookDescription;
            Reserved = bookReserved;
            Author = bookAuthor;
        }

        public bool addBookInDb(DB db)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `books`(`name`, `age`, `description`, `reserved`, `author`) VALUES (@name, @age, @description, @reserved, @author)", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@age", MySqlDbType.Int32).Value = Age;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = Description;
            command.Parameters.Add("@author", MySqlDbType.VarChar).Value = Author;
            command.Parameters.Add("@reserved", MySqlDbType.Bit).Value = Reserved;
            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            db.closeConnection();
            return false;
        }
    }
}
