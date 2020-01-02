using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Windows;
using Service;

namespace Host
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private ServiceHost host;

        private void AfisareEndpoint()
        {
            foreach (ServiceEndpoint se in host.Description.Endpoints)
            {
                string temp = String.Format("A (address): {0}, EP name : {1} B(binding): {2}, (Contract): {3}  Uri: {4}  ",
                    se.Address, se.Name, se.Binding.Name, se.Contract.Name,
                    se.ListenUri.AbsolutePath);
                this.listBox.Items.Add(temp);
                foreach (var x in se.EndpointBehaviors)
                {
                    string t = x.ToString();
                    this.listBox.Items.Add(t);
                }
            }
        }

        public void WriteMessage(string msg)
        {
            listBox.Items.Add(msg);
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            this.listBox.Items.Clear();
            this.listBox.Items.Add("Start server. Asteptati...");
            // Am folosit aceasta varianta pentru a avea acces la interfata din cadrul
            // metodellor definite in serviciu.
            // Acest lucru e numai pentru exemplificare si vizualizare
            // apel metode pe partea de server
            BibliotecaService biblioService = new BibliotecaService();
            host = new ServiceHost(biblioService,
                new Uri("http://localhost:8081/biblio"));
            try
            {
                host.Open();
                // Am nevoie de obiectul curent (fereastra) this pentru a-l pasa
                // in obiectul de pe server.
                // Fiecare metoda de pe server va afisa un mesaj in ListBox in
                // momentul cand va fi apelata
                // Management instanta serviciu (atribut plasat pe clasa
                // ce implementeaza ServiceContract
                // [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
                var singletonInstance = (IBiblioteca)host.SingletonInstance;
                BibliotecaService svp = (BibliotecaService)singletonInstance;
                svp.PassMainWindow(this);
                AfisareEndpoint();
                this.listBox.Items.Add("Server lansat in executie cu succes!Asteptare cereri de la clienti...");
            }
            catch (Exception ex)
            {
                this.listBox.Items.Add("Serverul nu poate fi lansat in executie!");
                this.listBox.Items.Add(ex.Message);
            }
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            if (host != null)
            {
                this.listBox.Items.Add("Incercare oprire server...");
                try
                {
                    host.Close();
                    this.listBox.Items.Add("Server oprit!");
                }
                catch
                {
                    this.listBox.Items.Add("Probabil server nelansat. Actiune esuata.");
                }
            }
        }
    }
}
