using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Couche_Modele.Metier;
using Couche_Modele.Modele;
using EGC_Technicien.Databinding;

namespace EGC_Technicien
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Dbal bdd = new Dbal("192.168.1.22", "egc", "Admin", "Admin");
            //Dbal bdd = new Dbal("172.31.254.186", "egc", "Admin", "Admin");
            DAOxClients clients = new DAOxClients(bdd);
            DAOxObstacles obstacles = new DAOxObstacles(bdd);
            DAOxPartieObstacles partieObstacles = new DAOxPartieObstacles(bdd);
            DAOxParties parties = new DAOxParties(bdd);
            DAOxSalle salle = new DAOxSalle(bdd);
            DAOxTheme theme = new DAOxTheme(bdd);
            DAOxTransactions transactions = new DAOxTransactions(bdd);
            DAOxVille ville = new DAOxVille(bdd);
            List<String> ListHoraire = new List<String> { "8h30", "10h00", "11h00", "12h30", "14h00", "15h30", "17h00", "18h30" };

            InitializeComponent();

            Load_Planning(salle.SelectAllSalle());


            void Load_Planning(List<DTOSalle> listSalles)
            {
                RowDefinition rowDefinition = new RowDefinition();
                rowDefinition.Height = new GridLength(50);
                grid_planning.RowDefinitions.Add(rowDefinition);

                ColumnDefinition columnDefinition = new ColumnDefinition();
                columnDefinition.Width = new GridLength(140);
                grid_planning.ColumnDefinitions.Add(columnDefinition);

                //Création des colonnes du planning
                for (int i = 0; i < ListHoraire.Count(); i++)
                {
                    ColumnDefinition cm = new ColumnDefinition();
                    cm.Width = new GridLength(80);
                    grid_planning.ColumnDefinitions.Add(cm);

                    //Création Bordures première colonne
                    Border br_planning_column_fin = new Border();
                    br_planning_column_fin.BorderThickness = new Thickness(1);
                    Grid.SetRow(br_planning_column_fin, 0);
                    Grid.SetColumn(br_planning_column_fin, i+1);
                    grid_planning.Children.Add(br_planning_column_fin);
                }

                //Création des lignes du planning 
                for (int i = 0; i < listSalles.Count(); i++)
                {
                    RowDefinition rw = new RowDefinition();
                    rw.Height = new GridLength(50);
                    grid_planning.RowDefinitions.Add(rw);

                    //Création Bordures première ligne
                    Border br_planning_row_fin = new Border();
                    br_planning_row_fin.BorderThickness = new Thickness(1);
                    Grid.SetRow(br_planning_row_fin, i+1);
                    Grid.SetColumn(br_planning_row_fin, 0);
                    grid_planning.Children.Add(br_planning_row_fin);
                }


                for (int i = 0; i < listSalles.Count(); i++)
                {
                    for (int j = 0; j < ListHoraire.Count(); j++)
                    {
                        Border br_planning = new Border();
                        br_planning.BorderThickness = new Thickness(1);
                        Grid.SetRow(br_planning, i);
                        Grid.SetColumn(br_planning, j);
                        grid_planning.Children.Add(br_planning);

                        Label lbl_horaire = new Label();
                        lbl_horaire.Content = ListHoraire[j];
                        lbl_horaire.Height = 50;
                        lbl_horaire.Width = 80;
                        lbl_horaire.FontSize = 15;
                        lbl_horaire.HorizontalContentAlignment = HorizontalAlignment.Center;
                        lbl_horaire.VerticalContentAlignment = VerticalAlignment.Center;
                        Grid.SetRow(lbl_horaire, 0);
                        Grid.SetColumn(lbl_horaire, j + 1);
                        grid_planning.Children.Add(lbl_horaire);

                        Button btn = new Button();
                        btn.VerticalContentAlignment = VerticalAlignment.Center;
                        btn.HorizontalContentAlignment = HorizontalAlignment.Center;
                        btn.Width = 140;
                        btn.Height = 50;
                        btn.FontSize = 15;
                        btn.Background = Brushes.White;
                        btn.Content = "test";
                        Grid.SetRow(btn, i+1);
                        Grid.SetColumn(btn, j+1);

                        grid_planning.Children.Add(btn);
                    }
                    Label lbl_salle = new Label();
                    lbl_salle.Content = listSalles[1].GetNom();
                    lbl_salle.Height = 50;
                    lbl_salle.Width = 140;
                    lbl_salle.FontSize = 15;
                    lbl_salle.HorizontalContentAlignment = HorizontalAlignment.Center;
                    lbl_salle.VerticalContentAlignment = VerticalAlignment.Center;
                    Grid.SetRow(lbl_salle, i+1);
                    Grid.SetColumn(lbl_salle, 0);
                    grid_planning.Children.Add(lbl_salle);
                }

            }
            

            Calendrier.DataContext = new VueModele(bdd, clients, obstacles, partieObstacles, parties, salle, theme, transactions, ville);
            
        }
    }
}
