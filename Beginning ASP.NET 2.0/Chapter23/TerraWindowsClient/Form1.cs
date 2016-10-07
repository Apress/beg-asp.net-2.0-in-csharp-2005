using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsTerraClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private net.terraservice.TerraService ts = new net.terraservice.TerraService();

        private void cmdShow_Click(object sender, EventArgs e)
        {
            // Retrieve the matching list.
            net.terraservice.PlaceFacts[] factsArray;
            factsArray = ts.GetPlaceList(txtPlace.Text, 100, false);

            // Loop through all the results, and display them.
            foreach (net.terraservice.PlaceFacts facts in factsArray)
            {
                ShowPlaceFacts(facts);
            }
        }

        private void ShowPlaceFacts(net.terraservice.PlaceFacts facts)
        {
            string newItem;
            newItem = "Place: " + facts.Place.City + ", ";
            newItem += facts.Place.State + ", " + facts.Place.Country;
            lstPlaces.Items.Add(newItem);
        }

    }
}