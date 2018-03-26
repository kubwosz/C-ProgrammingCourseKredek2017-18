using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Configuration;

namespace JakubWoszczynaZad4
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Obiekt klasy DataClassesJakubWoszczynaZad4DataContext służący do obsługi bazy danych
        /// </summary>
        DataClassesJakubWoszczynaZad4DataContext context = new DataClassesJakubWoszczynaZad4DataContext();

        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funkcja obsługująca przycisk wyświetlający dane zamówienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowData_Click(object sender, EventArgs e)
        {
            ShowOrders();
        }
        /// <summary>
        /// Funkcja wpisująca do głównej dataGridView dane o wszystkich zamówiniach
        /// </summary>
        private void ShowOrders()
        {
            dataGridViewMainInformation.DataSource = GetOrder();
        }
        /// <summary>
        /// Funkcja obsługująca ściąganie z bazy danych informacji o zamówieniach
        /// </summary>
        /// <returns></returns>
        private IQueryable GetOrder()
        {
            //var orders = from ord in context.Orders select new { ord.PlaceToGetProductID, ord.ClientID, ord.DateToGetProduct, ord.OrderNumber};
            var orders = from ord in context.Orders
                         select new
                         {
                             Numer_Zamowienia = ord.OrderNumber,
                             Imie = ord.Client.Name,
                             Nazwisko = ord.Client.Surname,
                             Data_Zamowienia = ord.DateToGetProduct,
                             Miasto_Odbioru = ord.PlacesToGetProduct.City,
                             Ulica_Odbioru = ord.PlacesToGetProduct.Street,
                             Number_Budynku_Odbioru = ord.PlacesToGetProduct.BuildingNumber,
                             Numer_Telefonu_Klienta = ord.Client.Contact.PhoneNumber,
                             Mail_Klienta = ord.Client.Contact.Mail,
                             Miasto_Klienta = ord.Client.ClientAddress.City,
                             Ulica_Klienta = ord.Client.ClientAddress.Street,
                             Numer_Domu_Klienta = ord.Client.ClientAddress.BuildingNumber
                         };

            return orders;
        }
        /// <summary>
        /// Funkcja dodająca do bazy danych nowe zamówienie, a wraz z nim wszystkie pozostałe informacje o kliencie
        /// oraz zamówieniu. W przypadku nie wypełnienia wszystkich pól, lub wypełnienia ich niepoprawnie,
        /// zostaje wyświetlony komunikat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddData_Click(object sender, EventArgs e)
        {
            try
            {

            var contact = new Contact
            {
                PhoneNumber = Int32.Parse(textBoxClientPhoneNumber.Text),
                Mail = textBoxClientMailAddress.Text
            };

            context.Contacts.InsertOnSubmit(contact);
            context.SubmitChanges();

            var clientAddress = new ClientAddress
            {
                City =textBoxClientCity.Text,
                Street = textBoxClientStreet.Text,
                BuildingNumber = Int32.Parse(textBoxClientBuildingNumber.Text)
            };

            context.ClientAddresses.InsertOnSubmit(clientAddress);
            context.SubmitChanges();

            var client = new Client
            {
                ContactID = contact.ID,
                AddressID = clientAddress.ID,
                Name = textBoxClientName.Text,
                Surname = textBoxClientSurname.Text
            };

            context.Clients.InsertOnSubmit(client);
            context.SubmitChanges();

            var placeToGetProduct = new PlacesToGetProduct
            {
                City = textBoxOrderCity.Text,
                Street = textBoxOrderStreet.Text,
                BuildingNumber = Int32.Parse(textBoxOrderBuildingNumber.Text)
            };

            context.PlacesToGetProducts.InsertOnSubmit(placeToGetProduct);
            context.SubmitChanges();

            var order = new Order
            {
                PlaceToGetProductID = placeToGetProduct.ID,
                ClientID = client.ID,
                DateToGetProduct = dateTimePickerOrderDate.Value,
                OrderNumber = Int32.Parse(textBoxOrderNumber.Text)
            };

            context.Orders.InsertOnSubmit(order);
            context.SubmitChanges();

                MessageBox.Show("Dane dodano poprawnie");

                ShowOrders();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Należy wypełnić wszystkie pola lub w poprawnym formacie. Błąd: "+ exception.Message);
            }
        }
        /// <summary>
        /// Funkcja usuwająca dane zamówienie wg podanego numeru zamówienia, a wraz z nim wszystkie powiązane informacje o kliencie
        /// oraz o zamówieniu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = (from element in context.Orders
                               where element.OrderNumber == Int32.Parse(textBoxDeleteOrderNumber.Text)
                               orderby element.ID descending
                               select element).FirstOrDefault();

                //usuwanie wszystkich obiektów
                context.Orders.DeleteOnSubmit(order);
                context.PlacesToGetProducts.DeleteOnSubmit(order.PlacesToGetProduct);
                context.ClientAddresses.DeleteOnSubmit(order.Client.ClientAddress);
                context.Contacts.DeleteOnSubmit(order.Client.Contact);
                context.Clients.DeleteOnSubmit(order.Client);
                context.SubmitChanges();

                MessageBox.Show("Zamówienie usunięto poprawnie");
                ShowOrders();
            }
            catch (Exception exception)
            {   
                MessageBox.Show("Należy wypełnić potrzebne pole lub wypełnić je w poprawnym formacie. Błąd: " + exception.Message);
            }
        }
        /// <summary>
        /// Funkcja obsługująca szukanie zamówienia po numberze zamówienia, i zwracająca tabelę z informacjami o kiencie o danym zamówieniu.
        /// </summary>
        /// <param name="SearchOrderNumber"></param>
        /// <returns></returns>
        private IQueryable SearchGetOrder(int SearchOrderNumber)
        {
            var orders = from ord in context.Orders
                         where ord.OrderNumber == SearchOrderNumber
                         select new
                         {
                             Numer_Zamowienia = ord.OrderNumber,
                             Imie = ord.Client.Name,
                             Nazwisko = ord.Client.Surname,
                             Data_Zamowienia = ord.DateToGetProduct,
                             Miasto_Odbioru = ord.PlacesToGetProduct.City,
                             Ulica_Odbioru = ord.PlacesToGetProduct.Street,
                             Number_Budynku_Odbioru = ord.PlacesToGetProduct.BuildingNumber,
                             Numer_Telefonu_Klienta = ord.Client.Contact.PhoneNumber,
                             Mail_Klienta = ord.Client.Contact.Mail,
                             Miasto_Klienta = ord.Client.ClientAddress.City,
                             Ulica_Klienta = ord.Client.ClientAddress.Street,
                             Numer_Domu_Klienta = ord.Client.ClientAddress.BuildingNumber
                         };

            return orders;
        }

        /// <summary>
        /// Funkcja szukająca informacji z danych o klienatach na podstawie instrukcji OR, umożliwia wyszukanie danego zamówienia
        /// tylko po podaniu kilku informacji
        /// </summary>
        /// <returns></returns>
        private IQueryable SearchAny()
        {
            //konstrukcja szukająca zamówienia o kilku  podanych informacjach 
            var orders = from ord in context.Orders
                         where ord.Client.Name == ((!string.IsNullOrWhiteSpace(textBoxClientName.Text)) ? textBoxClientName.Text : null) ||
                         ord.Client.Surname == ((!string.IsNullOrWhiteSpace(textBoxClientSurname.Text)) ? textBoxClientSurname.Text : null) ||
                         ord.Client.ClientAddress.City == ((!string.IsNullOrWhiteSpace(textBoxClientCity.Text)) ? textBoxClientCity.Text : null) ||
                         ord.Client.ClientAddress.Street == ((!string.IsNullOrWhiteSpace(textBoxClientStreet.Text)) ?  textBoxClientStreet.Text : null) ||
                         ord.Client.ClientAddress.BuildingNumber == ((!string.IsNullOrWhiteSpace(textBoxClientBuildingNumber.Text)) ?  Int32.Parse(textBoxClientBuildingNumber.Text)  : -1) ||
                         ord.Client.Contact.Mail == ((!string.IsNullOrWhiteSpace(textBoxClientMailAddress.Text)) ?  textBoxClientMailAddress.Text : null) ||
                         ord.Client.Contact.PhoneNumber == ((!string.IsNullOrWhiteSpace(textBoxClientPhoneNumber.Text)) ?  Int32.Parse(textBoxClientPhoneNumber.Text) : -1) ||
                         ord.PlacesToGetProduct.City == ((!string.IsNullOrWhiteSpace(textBoxOrderCity.Text)) ?  textBoxOrderCity.Text : null) ||
                         ord.PlacesToGetProduct.Street == ((!string.IsNullOrWhiteSpace(textBoxOrderStreet.Text)) ?  textBoxOrderStreet.Text : null) ||
                         ord.PlacesToGetProduct.BuildingNumber == ((!string.IsNullOrWhiteSpace(textBoxOrderBuildingNumber.Text)) ? Int32.Parse(textBoxOrderBuildingNumber.Text) : -1)
                         select new
                         {
                             Numer_Zamowienia = ord.OrderNumber,
                             Imie = ord.Client.Name,
                             Nazwisko = ord.Client.Surname,
                             Data_Zamowienia = ord.DateToGetProduct,
                             Miasto_Odbioru = ord.PlacesToGetProduct.City,
                             Ulica_Odbioru = ord.PlacesToGetProduct.Street,
                             Number_Budynku_Odbioru = ord.PlacesToGetProduct.BuildingNumber,
                             Numer_Telefonu_Klienta = ord.Client.Contact.PhoneNumber,
                             Mail_Klienta = ord.Client.Contact.Mail,
                             Miasto_Klienta = ord.Client.ClientAddress.City,
                             Ulica_Klienta = ord.Client.ClientAddress.Street,
                             Numer_Domu_Klienta = ord.Client.ClientAddress.BuildingNumber
                         };

            return orders;
        }

        /// <summary>
        /// Funkcja szukająca wśród danych zamówienia o podanym numerze w textBoxSearchOrderNumber
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearchData_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewMainInformation.DataSource = SearchGetOrder(Int32.Parse(textBoxSearchOrderNumber.Text));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Należy wypełnić potrzebne pole lub wypełnić je w poprawnym formacie. Błąd: " + exception.Message);

            }
        }
        /// <summary>
        /// Funkcja pokazująca zamówienie wybrane do edytowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditOrderShow_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewMainInformation.DataSource = SearchGetOrder(Int32.Parse(textBoxEditOrderNumber.Text));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Należy wypełnić potrzebne pole lub wypełnić je w poprawnym formacie. Błąd: " + exception.Message);
            }
        }
        /// <summary>
        /// Funkcja edytująca zamówienie o numerze zamówienia podanym w textBoxEditOrderNumber
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = (from element in context.Orders
                           where element.OrderNumber == Int32.Parse(textBoxEditOrderNumber.Text)
                           orderby element.ID descending
                           select element).FirstOrDefault();

                order.Client.Name = (!string.IsNullOrWhiteSpace(textBoxClientName.Text)) ? textBoxClientName.Text : order.Client.Name;
                order.Client.Surname = (!string.IsNullOrWhiteSpace(textBoxClientSurname.Text)) ? textBoxClientSurname.Text : order.Client.Surname;
                order.Client.ClientAddress.City = (!string.IsNullOrWhiteSpace(textBoxClientCity.Text)) ? textBoxClientCity.Text : order.Client.ClientAddress.City;
                order.Client.ClientAddress.Street = (!string.IsNullOrWhiteSpace(textBoxClientStreet.Text)) ? textBoxClientStreet.Text : order.Client.ClientAddress.Street;
                order.Client.ClientAddress.BuildingNumber = (!(string.IsNullOrWhiteSpace(textBoxClientBuildingNumber.Text))) ? Int32.Parse(textBoxClientBuildingNumber.Text) : order.Client.ClientAddress.BuildingNumber;
                order.Client.Contact.PhoneNumber = (!(string.IsNullOrWhiteSpace(textBoxClientPhoneNumber.Text))) ? Int32.Parse(textBoxClientPhoneNumber.Text) : order.Client.Contact.PhoneNumber;
                order.Client.Contact.Mail = (!(string.IsNullOrWhiteSpace(textBoxClientMailAddress.Text))) ? textBoxClientMailAddress.Text : order.Client.Contact.Mail;
                order.OrderNumber = (!string.IsNullOrWhiteSpace(textBoxOrderNumber.Text)) ? Int32.Parse(textBoxOrderNumber.Text) : order.OrderNumber;
                order.PlacesToGetProduct.City = (!(string.IsNullOrWhiteSpace(textBoxOrderCity.Text))) ? textBoxOrderCity.Text : order.PlacesToGetProduct.City;
                order.PlacesToGetProduct.Street = (!(string.IsNullOrWhiteSpace(textBoxOrderStreet.Text))) ? textBoxOrderStreet.Text : order.PlacesToGetProduct.Street;
                order.PlacesToGetProduct.BuildingNumber = (!(string.IsNullOrWhiteSpace(textBoxOrderBuildingNumber.Text))) ? Int32.Parse(textBoxOrderBuildingNumber.Text) : order.PlacesToGetProduct.BuildingNumber;

                context.SubmitChanges();

                dataGridViewMainInformation.DataSource = SearchGetOrder(Int32.Parse(textBoxEditOrderNumber.Text));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Należy wypełnić potrzebne pole lub wypełnić je w poprawnym formacie. Błąd: " + exception.Message);
            }
}

        /// <summary>
        /// Funkcja eksportująca pismo przypominające o przesyłce do formatu PDF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExportPdf_Click(object sender, EventArgs e)
        {
            try
            {
            Order order = (from element in context.Orders
                           where element.OrderNumber == Int32.Parse(textBoxExportPdfOrderNumber.Text)
                           orderby element.ID descending
                           select element).FirstOrDefault();


                string pdfPath = ConfigurationManager.AppSettings["csvPath"] + "test";

                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(pdfPath + order.OrderNumber + ".pdf", FileMode.Create));
            doc.Open();

                var myFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 8);

                Paragraph p1 = new Paragraph("Szanowny kliencie " + order.Client.Name +" "+ order.Client.Surname +",\n\n"+
                "Chcielibyśmy poinformowac o zbliżającym się terminie odebrania przesyłki o numerze \n zamówienia: " +
                order.OrderNumber+ ", który mija "+ order.DateToGetProduct.Value.Day +":" + order.DateToGetProduct.Value.Month + ":" + 
                order.DateToGetProduct.Value.Year + "."+ " Produkt można odebrać w miescie: " +
                 order.PlacesToGetProduct.City+ " przy ulicy " + order.PlacesToGetProduct.Street + " "+
                order.PlacesToGetProduct.BuildingNumber+ ".\n\n"+ "Z wyrazami szacunku,\nFirma elektroniczna EleK", myFont);

                doc.Add(p1);
                doc.Close();
            MessageBox.Show("Plik PDF został pomyślnie utworzony");
            }
            catch (Exception exception)
            {

                MessageBox.Show("Należy wypełnić potrzebne pole lub wypełnić je w poprawnym formacie.Błąd: " + exception.Message);
            }
        }
        /// <summary>
        /// Funkcja eksporująca tabelę dataGridViewMainInformation do formatu .csv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExportCsv_Click(object sender, EventArgs e)
        {
            using(DataClassesJakubWoszczynaZad4DataContext order = new DataClassesJakubWoszczynaZad4DataContext())
            {
                //string csvPath = "C:\\Users\\Jakub Woszczyna\\Desktop\\Kurs C#\\cpc2017-2\\Jakub_Woszczyna\\test2.csv";
                string csvPath = ConfigurationManager.AppSettings["csvPath"] + "test.csv";
                try
                {
                    dataGridViewMainInformation.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                    dataGridViewMainInformation.SelectAll();
                    DataObject dataObject = dataGridViewMainInformation.GetClipboardContent();

                    File.WriteAllText(csvPath, dataObject.GetText(TextDataFormat.CommaSeparatedValue));


                    MessageBox.Show("Plik .csv został pomyślnie utworzony");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
              
            }
        }

        /// <summary>
        /// Funkcja obsługująca przycisk szukający po pewnej ilości informacji o zamówieniu.
        /// Funckja wywołuje metodę SearchAny która zajmuje się znajdywaniem obiektu o podanych informacjach
        /// oraz zwraca tablę do DataGridView, metoda także przechwytuje wyjątki, w razie błędu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearchAny_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewMainInformation.DataSource = SearchAny();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Należy wypełnić potrzebne pole lub wypełnić je w poprawnym formacie. Błąd: " + exception.Message);

            }
        }
    }
}
