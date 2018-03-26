using System.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;

namespace JakubWoszczynaZad3
{/// <summary>
/// Klasa klient przechowujaca informacje o kliencie
/// </summary>
    class Client
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public int PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Client() { }
        /// <summary>
        /// Metoda wywolujaca nowe okno i pokazujaca informacje o kliencie
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="client"></param>
        public void ShowClient(SqlConnection connection, Client client)
        {
            InsertClient(connection, client);

            ClientForm clientForm = new ClientForm();
            clientForm.Show();
            clientForm.FillDataGridView();
        }
        /// <summary>
        /// Metoda dodająca nowego klienta do bazy danych
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="client"></param>
        /// <returns></returns>
        public static DataTable InsertClient(SqlConnection connection, Client client)
        {
            try
            {
                int idAddress = 0;
                int idContact = 0;
                SqlCommand command = new SqlCommand($"INSERT INTO Address(City, Street, HouseNumber) values('{client.City}', '{client.Street}', '{client.HouseNumber}')\n" +
    $"INSERT INTO Contact(PhoneNumber, Mail) values ('{client.PhoneNumber}','{client.Mail}')", connection);

                SqlCommand cmdAddress = new SqlCommand("SELECT MAX(Id) FROM Address", connection);
                SqlCommand cmdContact = new SqlCommand("SELECT MAX(Id) FROM Contact", connection);

                connection.Open();
                command.ExecuteNonQuery();
                SqlDataReader address = cmdAddress.ExecuteReader();
                address.Read();
                idAddress = address.GetInt32(0);
                connection.Close();

                connection.Open();
                SqlDataReader contact = cmdContact.ExecuteReader();
                contact.Read();
                idContact = contact.GetInt32(0);
                connection.Close();

                SqlCommand command3 = new SqlCommand($"INSERT INTO Client (IdAddress,IdContact,Name, Surname) values ('{idAddress}','{idContact}','{client.Name}','{client.Surname}')", connection);
                connection.Open();
                command3.ExecuteNonQuery();
                connection.Close();

                return GetAll(connection);
            }
            catch(Exception)
            {
                MessageBox.Show("Podaj wszystkie potrzebne informacje lub we właściwym formacie", "Błąd podawania informacji");
                return null;
            }
        }

        /// <summary>
        /// metoda wypisujaća wszystkie informacje o kliencie w datagridview
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static DataTable GetAll(SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select c.Name,c.Surname,a.City,a.Street,a.HouseNumber,ct.Mail,ct.PhoneNumber"+
      " from Client c join Address a on c.IdAddress = a.Id join Contact ct on c.IdContact = ct.Id", connection);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

    }
}
