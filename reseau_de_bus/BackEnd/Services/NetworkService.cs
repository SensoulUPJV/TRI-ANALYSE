using System;
using System.Collections.Generic;
using System.Linq;
using reseau_de_bus.BackEnd.Models;

namespace reseau_de_bus.BackEnd.Services
{
    public class NetworkService
    {
        public void InitialiserArrets(Reseau reseau)
        {
            var arrets = new Dictionary<int, (string nom, float x, float y)>
            {
                {1, ("Promenade", 24, 0)},
                {2, ("Centre commercial Nord", 22.5f, 1)},
                {3, ("Romain Rolland", 22, 2.5f)},
                {4, ("Espace santé", 22, 3.5f)},
                {5, ("Pôle d'échanges Nord", 22, 4.5f)},
                {6, ("Berlioz", 22, 5.5f)},
                {7, ("Clémenceau", 21.5f, 6.5f)},
                {8, ("Citadelle François 1er", 21, 8f)},
                {9, ("Citadelle Monstrescu", 20.5f, 9f)},
                {10, ("Vogel", 18.5f, 11.5f)},
                {11, ("Saint Leu", 20.5f, 12f)},
                {12, ("Place de Don", 22, 13f)},
                {13, ("Alsace Lorraine", 24.5f, 14.5f)},
                {14, ("Gare du Nord", 23.5f, 17f)},
                {15, ("Otages", 21f, 18f)},
                {16, ("Cirque Jules Verne", 19, 18)},
                {17, ("Collège Saint Martin", 18, 20.5f)},
                {18, ("Delpech", 17, 22)},
                {19, ("Cité - Providence", 19f, 23f)},
                {20, ("Charassin", 20.5f, 24.5f)},
                {21, ("Aquapôle", 20, 26)},
                {22, ("Pôle des cliniques", 19f, 25.5f)},
                {23, ("Georges Beauvais", 15.5f, 25)},
                {24, ("Espagne", 13.5f, 26)},
                {25, ("Grèce", 12.5f, 27)},
                {26, ("IME", 10.5f, 29)},
                {27, ("Centre Commercial Sud", 10, 30.5f)},
                {28, ("Etouvie", 0, 3.5f)},
                {29, ("Martinique", 1, 2.5f)},
                {30, ("Collège Rosa Parks", 2, 2)},
                {31, ("Languedoc", 4, 2.5f)},
                {32, ("Les Coursives", 3.5f, 3)},
                {33, ("La Fontaine", 3.5f, 4.5f)},
                {34, ("Place La Barre", 4.5f, 5)},
                {35, ("Sully", 6.5f, 6)},
                {36, ("Espace Alliance", 9, 7)},
                {37, ("Faubourg de Hem", 10, 7.5f)},
                {38, ("Eglise Saint Firmin", 11.5f, 8.5f)},
                {39, ("Zoo d'Amiens", 13, 9.5f)},
                {40, ("Jean Jaures", 14.5f, 11)},
                {41, ("Saint-Jacques", 15.5f, 12.5f)},
                {42, ("Maison de la Culture", 17, 13.5f)},
                {43, ("Place du Marché", 17.5f, 13)},
                {44, ("Beffroi", 19, 13)},
                {45, ("Dusevel", 20, 14)},
                {46, ("Palais de Justice", 21, 15)},
                {47, ("René Goblet", 21.5f, 16.5f)},
                {48, ("Caserne Dejean", 25.5f, 18)},
                {49, ("Pinceau", 27, 19)},
                {50, ("Lycée de Luzarches", 28f, 20f)},
                {51, ("Eglise Saint Acheul", 29, 21)},
                {52, ("Mercey", 30.5f, 22)},
                {53, ("Sobo", 31.5f, 22.5f)},
                {54, ("Pont de l'Avre", 33, 23.5f)},
                {55, ("Cité du Château", 35, 24.5f)},
                {56, ("La Rose Rouge", 35.5f, 25.5f)},
                {57, ("Poidevin", 36.5f, 26)},
                {58, ("Mairie de Longueau", 37, 26.5f)},
                {59, ("La Fournche", 38, 27)},
                {60, ("Croix de Fer", 40.5f, 27.5f)},
                {61, ("Centre Commercial Glisy", 42, 29)},
                {62, ("Capitaine Nemo", 43.5f, 30f)},
                {63, ("Pôle Jules Verne", 45, 30.5f)},
                {64, ("La Paix", 19.5f, 4.5f)},
                {65, ("Chardin", 21f, 4.5f)},
                {66, ("Colvert", 24.5f, 4.5f)},
                {67, ("Nautilus", 26, 5)},
                {68, ("Balzac", 27.5f, 5)},
                {69, ("Stendhal", 28, 6.5f)},
                {70, ("Centre Saint Victor", 28, 7.5f)},
                {71, ("Eloi Morel", 27, 9)},
                {72, ("Parc Saint Pierre", 26, 11)},
                {73, ("Hortillonnages", 25, 13)},
                {75, ("Nicole Fontaine", 16, 16.5f)},
                {76, ("Simone Veil", 14.5f, 15)},
                {77, ("Quatre Chênes", 12.5f, 18)},
                {78, ("Libération", 11.5f, 19.5f)},
                {79, ("Quatre Lemaire", 11.5f, 20.5f)},
                {80, ("Ambroise Paré", 7, 23)},
                {81, ("Rotonde", 5.5f, 23.5f)},
                {82, ("CHU Amiens Picardie", 3.5f, 24)},
                {83, ("Laënnec", 3.5f, 26)},
                {84, ("Résidence du Thil", 5, 26)},
                {85, ("IUT", 7, 26.5f)},
                {86, ("Pôle Licorne", 7.5f, 11)},
                {87, ("Hyppodrome", 9.5f, 12)},
                {88, ("Colbert", 11.5f, 14)},
                {89, ("Lucien Fournier", 12.5f, 14)},
                {90, ("Hôtel de Ville", 17.5f, 15)},
                {91, ("Jacobins", 19.5f, 15.5f)},
                {92, ("Emile Zola", 21, 16.5f)},
                {93, ("Mons", 27.5f, 21.5f)},
                {94, ("3ième DI", 26, 22)},
                {95, ("Hôtel des Impôts", 25.5f, 23)},
                {96, ("Rollin", 26, 24)},
                {97, ("Ormale", 27, 24.5f)},
                {98, ("Görlitz", 28, 26)},
                {99, ("Frédéric Mistral", 28.5f, 27)},
                {100, ("Collège Guy Mareschal", 29.5f, 27)},
                {101, ("IREAM", 31, 26.5f)},
                {102, ("Bel Air", 31.5f, 28)},
                {103, ("Wasse", 32, 29)},
                {104, ("Place de Cagny", 33, 30.5f)},
                {105, ("Latapie", 33.5f, 29.5f)},
                {106, ("Longueau SNCF", 36, 29.5f)}
            };

            foreach (var kvp in arrets)
            {
                var arret = new Arret(kvp.Key.ToString(), kvp.Value.nom,
                    new Coordonnees(kvp.Value.x, kvp.Value.y));
                reseau.Arrets.Add(arret);
            }
        }

        public void InitialiserLignes(Reseau reseau)
        {
            var lignesConfig = new Dictionary<string, int[]>
            {
                {"Nemo 1", new int[] {28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 14, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63}},
                {"Nemo 2", new int[] {64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 13, 14, 15, 16, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85}},
                {"Nemo 3", new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27}},
                {"Nemo 4", new int[] {86, 87, 88, 89, 76, 75, 90, 91, 92, 14, 48, 49, 50, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106}}
            };

            foreach (var ligneConfig in lignesConfig)
            {
                var ligne = new Ligne(ligneConfig.Key);

                foreach (var idArret in ligneConfig.Value)
                {
                    var arret = reseau.Arrets.FirstOrDefault(a => a.IdArret == idArret.ToString());
                    if (arret != null)
                    {
                        ligne.AjouterArret(arret);
                    }
                }

                reseau.Lignes.Add(ligne);
            }
        }
    }
    }