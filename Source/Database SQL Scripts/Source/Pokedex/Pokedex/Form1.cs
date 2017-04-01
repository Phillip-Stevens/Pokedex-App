using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace Pokedex
{
    public partial class Pokedex : Form
    {
        // START OF CODE SNIPPET FOR WINDOW CONTROL TAKEN FROM: http://www.codeproject.com/Articles/11114/Move-window-form-without-Titlebar-in-C
        // Window control variables
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // END OF CODE SNIPPET

        // Public Variables
        bool databaseConnectionFailure = false;
        bool setup = false;
        List<POKEMON> pokedex = new List<POKEMON>();
        List<POKEMON> webCache = new List<POKEMON>();
        List<POKEMON> pokedexCache = new List<POKEMON>();
        List<POKEMON> searchResults = new List<POKEMON>();
        HttpClient pokedexClient;

        public Pokedex()
        {
            InitializeComponent();
            
            // Make Wrap Around happen on the description text box
            lbl_Description.MaximumSize = new Size(250, 0);
            lbl_Description.AutoSize = true;

            if(!setup)
            {
                // Populate the list using a message to the server
                StartupPopulation().GetAwaiter();

                // Run this is 
                if (databaseConnectionFailure)
                {
                    //Testing Variables Data
                    //Create test cases, data is not accurate in order to cover as much as possible in the worst case scenario

                    #region // TEST DATA EVERYWHERE
                    POKEMON venusaur = new POKEMON();
                    venusaur.ENTRYNUMBER = 3;
                    venusaur.NAME = "Venusaur";
                    venusaur.DESCRIPTION = "A strange seed was planted on its back at birth. The plant sprouts and grows with this POKéMON.";
                    venusaur.ELEMENT = "Grass";
                    venusaur.ELEMENTTWO = "Poison";
                    venusaur.GENERATION = 1;

                    POKEMON charizard = new POKEMON();
                    charizard.ENTRYNUMBER = 6;
                    charizard.NAME = "Charizard";
                    charizard.DESCRIPTION = "A dragon with a firey temper.";
                    charizard.ELEMENT = "Fire";
                    charizard.ELEMENTTWO = "Flying";
                    charizard.GENERATION = 1;

                    POKEMON blastioise = new POKEMON();
                    blastioise.ENTRYNUMBER = 6;
                    blastioise.NAME = "Charizard";
                    blastioise.DESCRIPTION = "A dragon with a firey temper.";
                    blastioise.ELEMENT = "Fire";
                    blastioise.ELEMENTTWO = "Flying";
                    blastioise.GENERATION = 1;

                    POKEMON butterfree = new POKEMON();
                    butterfree.ENTRYNUMBER = 12;
                    butterfree.NAME = "Butterfree";
                    butterfree.DESCRIPTION = "A dragon with a firey temper.";
                    butterfree.ELEMENT = "Bug";
                    butterfree.ELEMENTTWO = "Rock";
                    butterfree.GENERATION = 1;

                    ////// Add test cases to the pokedex
                    pokedex.Add(venusaur);
                    pokedex.Add(charizard);
                    pokedex.Add(blastioise);
                    pokedex.Add(butterfree);

                    #endregion
                }
            }
        }

        // Used to populate the caches on startup
        async Task StartupPopulation()
        {
            try
            {
                // Create string that will be concatenated upon in order to pull the information down one by one
                string apiCommand = "api/POKEMONs";
                //int databaseLimit = 18; // edited to 151 in the expanded version of the applicatio0n

                // CONNECT TO THE SERVER AND POPULATE THE POKEDEX LIST!
                pokedexClient = new HttpClient();
                pokedexClient.BaseAddress = new Uri("http://pokedexserver.azurewebsites.net/");
                pokedexClient.DefaultRequestHeaders.Accept.Clear();
                pokedexClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage message;
                message = await pokedexClient.GetAsync(apiCommand);
                message.EnsureSuccessStatusCode();
                //MessageBox.Show("Connection Success: Attempting to populate the database with the data from the database.");

                // create the concatenated string to obtain the individual pokemon at that slot in the servers database
                //MessageBox.Show(exactCommand);
                pokedexClient.DefaultRequestHeaders.Accept.Clear();
                pokedexClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                message = await pokedexClient.GetAsync(apiCommand);
                message.EnsureSuccessStatusCode();
                //MessageBox.Show(message.ToString());
                List <POKEMON> deserial = new List<POKEMON>();

                deserial = JsonConvert.DeserializeObject<List<POKEMON>>(message.Content.ReadAsStringAsync().Result);

                //testing variable
                //MessageBox.Show(deserial[0].NAME.ToString());

                // Populate the Pokedex
                foreach (POKEMON poke in deserial)
                {
                    if(poke != null)
                    {
                        pokedex.Add(poke);
                    }
                }

                // Populate the list box
                foreach (POKEMON poke in pokedex)
                {
                    PokedexList.Items.Add(poke.ENTRYNUMBER + " " + poke.NAME);
                }

                // Create a Cached version of the pokedex initially pulled
                foreach (POKEMON poke in pokedex)
                {
                    pokedexCache.Add(poke);
                }

                setup = true;

                #region // FAILED API ISSUE
                //// A for loop that will be used to send a command to pull down each data item one by one if the API hadn't been broken

                //for(int i = 0; i < databaseLimit; i++)
                //{
                //    // create the concatenated string to obtain the individual pokemon at that slot in the servers database
                //    string iterator = i.ToString();
                //    string exactCommand = apiCommand + iterator;
                //    //MessageBox.Show(exactCommand);
                //    pokedexClient.DefaultRequestHeaders.Accept.Clear();
                //    pokedexClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //    message = await pokedexClient.GetAsync(exactCommand);
                //    message.EnsureSuccessStatusCode();
                //    MessageBox.Show(message.ToString());

                //    POKEMON deserializedItem = JsonConvert.DeserializeObject<POKEMON>(Content.ReadAsStringAsync().Result);

                //    MessageBox.Show(deserializedItem.NAME.ToString());
                //    //pokedex.Add(deserializedItem);
                //}
                #endregion
            }
            catch // If it fails initialize the database with a bunch of test data for the demo
            {
                //MessageBox.Show("CANNOT CONNECT TO SERVER. INITIALIZING LOCAL VARIABLES FOR DEMO!");

                // Set boolean to keep track of the data connection
                databaseConnectionFailure = true;
                setup = true;
            }

            setup = true;
        }

        // Used to attempt to update the cache
        async Task DatabaseUpdate()
        {
            // Create string that will be concatenated upon in order to pull the information down one by one
            string apiCommand = "api/POKEMONs";
            //int databaseLimit = 18; // edited to 151 in the expanded version of the applicatio0n

            // CONNECT TO THE SERVER AND POPULATE THE POKEDEX LIST!
            pokedexClient = new HttpClient();
            pokedexClient.BaseAddress = new Uri("http://pokedexserver.azurewebsites.net/");
            pokedexClient.DefaultRequestHeaders.Accept.Clear();
            pokedexClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage message;
            message = await pokedexClient.GetAsync(apiCommand);
            message.EnsureSuccessStatusCode();
            //MessageBox.Show("Connection Success: Attempting to populate the database with the data from the database.");

            // create the concatenated string to obtain the individual pokemon at that slot in the servers database
            //MessageBox.Show(exactCommand);
            pokedexClient.DefaultRequestHeaders.Accept.Clear();
            pokedexClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            message = await pokedexClient.GetAsync(apiCommand);
            message.EnsureSuccessStatusCode();
            //MessageBox.Show(message.ToString());
            List<POKEMON> deserial = new List<POKEMON>();

            deserial = JsonConvert.DeserializeObject<List<POKEMON>>(message.Content.ReadAsStringAsync().Result);

            //testing variable
            //MessageBox.Show(deserial[0].NAME.ToString());

            // Populate the Pokedex
            foreach (POKEMON poke in deserial)
            {
                if (poke != null)
                {
                    webCache.Add(poke);
                }
            }

            bool difference = false;

            // check loop cache against the pokedexcache to see if anything has changed, if it has we update the local cache
            for(int i = 0; i < webCache.Count; i++)
            {
                if (difference == false)
                {
                    if (webCache[i].NAME != pokedexCache[i].NAME)
                    {
                        difference = true;
                    }
                }
            }

            // If theres a difference compared between the recent downloaded copy and the local cache, update the local cache
            if(difference)
            {
                pokedexCache.Clear();

                foreach(POKEMON poke in webCache)
                {
                    pokedexCache.Add(poke);
                }


                // Reset difference to false now that everythigns the same.
                difference = false;

                // Clear the webcache for next usage
                webCache.Clear();
            }
        }

        private void Pokedex_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void Pokedex_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void PokedexList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Call the Check Update Method to update list if possible
            decimal entryNumber = 0;

            if(PokedexList.SelectedIndex >= 0)
            {
                // Utilize the data that was brought overfrom the server or from the cache
                entryNumber = pokedex[PokedexList.SelectedIndex].ENTRYNUMBER;
                lbl_Name.Text = (pokedex[PokedexList.SelectedIndex].NAME.ToString());
                lbl_Description.Text = (pokedex[PokedexList.SelectedIndex].DESCRIPTION.ToString());
                lbl_typeOne.Text = pokedex[PokedexList.SelectedIndex].ELEMENT.ToString();
                lbl_typeTwo.Text = pokedex[PokedexList.SelectedIndex].ELEMENTTWO.ToString();
            }

            // Call Set Picture Method!
            SetPicture((int)entryNumber);
            // Call Set Element Method!
        }

        // Would be expanded if the database has table hadn't been corrupted
        private void SetPicture(int entryNumber)
        {
            // Bulbasaur 
            if(entryNumber == 1)
            {
                pb_Pokemon.Load("http://vignette4.wikia.nocookie.net/pokemon/images/0/00/Bulbasaur_XY.gif/revision/latest?cb=20140319081443");
            }

            pb_Pokemon.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_Pokemon.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /**************************************************************************************************************************/
        //                                                          FILTERS
        /**************************************************************************************************************************/
        #region BUTTON CHANGES
        private void btn_Electric_Click(object sender, EventArgs e)
        {
            // Attempt to update the pokedexCache by updating the local cache
            DatabaseUpdate().GetAwaiter();

            searchResults.Clear();
            // If it fails search for the pokemon in the list 
            foreach (POKEMON poke in pokedexCache)
            {
                // If either the primary or secondary type matches add it to the results
                if(poke.ELEMENT == "ELECTRIC" || poke.ELEMENTTWO == "ELECTRIC")
                {
                    searchResults.Add(poke);
                }
            }

            // Wipe the list then loop over and add the search results to the list box
            PokedexList.Items.Clear();
            pokedex.Clear();
            
            foreach (POKEMON poke in searchResults)
            {
                pokedex.Add(poke);
            }

            foreach (POKEMON poke in searchResults)
            {
                PokedexList.Items.Add(poke.ENTRYNUMBER + " " + poke.NAME);
            }
        }

        private void btn_Fighting_Click(object sender, EventArgs e)
        {
            // Attempt to update the pokedexCache by updating the local cache
            DatabaseUpdate().GetAwaiter();

            searchResults.Clear();
            // If it fails search for the pokemon in the list 
            foreach (POKEMON poke in pokedexCache)
            {
                // If either the primary or secondary type matches add it to the results
                if (poke.ELEMENT == "FIGHTING" || poke.ELEMENTTWO == "FIGHTING")
                {
                    searchResults.Add(poke);
                }
            }

            // Wipe the list then loop over and add the search results to the list box
            PokedexList.Items.Clear();
            pokedex.Clear();

            foreach (POKEMON poke in searchResults)
            {
                pokedex.Add(poke);
            }

            foreach (POKEMON poke in searchResults)
            {
                PokedexList.Items.Add(poke.ENTRYNUMBER + " " + poke.NAME);
            }
        }

        private void btn_Ghost_Click(object sender, EventArgs e)
        {
            // Attempt to update the pokedexCache by updating the local cache
            DatabaseUpdate().GetAwaiter();

            // If it fails search for the pokemon in the list 
            foreach (POKEMON poke in pokedexCache)
            {
                // If either the primary or secondary type matches add it to the results
                if (poke.ELEMENT == "GHOST" || poke.ELEMENTTWO == "GHOST")
                {
                    searchResults.Add(poke);
                }
            }

            // Wipe the list then loop over and add the search results to the list box
            PokedexList.Items.Clear();
            pokedex.Clear();

            foreach (POKEMON poke in searchResults)
            {
                pokedex.Add(poke);
            }

            foreach (POKEMON poke in searchResults)
            {
                PokedexList.Items.Add(poke.ENTRYNUMBER + " " + poke.NAME);
            }

            searchResults.Clear();
        }

        private void btn_Grass_Click(object sender, EventArgs e)
        {
            // Attempt to update the pokedexCache by updating the local cache
            DatabaseUpdate().GetAwaiter();

            searchResults.Clear();
            // If it fails search for the pokemon in the list 
            foreach (POKEMON poke in pokedexCache)
            {
                // If either the primary or secondary type matches add it to the results
                if (poke.ELEMENT == "GRASS" || poke.ELEMENTTWO == "GRASS")
                {
                    searchResults.Add(poke);
                }
            }

            // Wipe the list then loop over and add the search results to the list box
            PokedexList.Items.Clear();
            pokedex.Clear();

            foreach (POKEMON poke in searchResults)
            {
                pokedex.Add(poke);
            }

            foreach (POKEMON poke in searchResults)
            {
                PokedexList.Items.Add(poke.ENTRYNUMBER + " " + poke.NAME);
            }
        }

        private void btn_Ground_Click(object sender, EventArgs e)
        {
            // Attempt to update the pokedexCache by updating the local cache
            DatabaseUpdate().GetAwaiter();

            searchResults.Clear();
            // If it fails search for the pokemon in the list 
            foreach (POKEMON poke in pokedexCache)
            {
                // If either the primary or secondary type matches add it to the results
                if (poke.ELEMENT == "GROUND" || poke.ELEMENTTWO == "GROUND")
                {
                    searchResults.Add(poke);
                }
            }

            // Wipe the list then loop over and add the search results to the list box
            PokedexList.Items.Clear();
            pokedex.Clear();

            foreach (POKEMON poke in searchResults)
            {
                pokedex.Add(poke);
            }

            foreach (POKEMON poke in searchResults)
            {
                PokedexList.Items.Add(poke.ENTRYNUMBER + " " + poke.NAME);
            }

        }

        private void btn_Bug_Click(object sender, EventArgs e)
        {
            // Attempt to update the pokedexCache by updating the local cache
            DatabaseUpdate().GetAwaiter();

            searchResults.Clear();

            // If it fails search for the pokemon in the list 
            foreach (POKEMON poke in pokedexCache)
            {
                // If either the primary or secondary type matches add it to the results
                if (poke.ELEMENT == "BUG" || poke.ELEMENTTWO == "BUG")
                {
                    searchResults.Add(poke);
                }
            }

            // Wipe the list then loop over and add the search results to the list box
            PokedexList.Items.Clear();
            pokedex.Clear();

            foreach (POKEMON poke in searchResults)
            {
                pokedex.Add(poke);
            }

            foreach (POKEMON poke in searchResults)
            {
                PokedexList.Items.Add(poke.ENTRYNUMBER + " " + poke.NAME);
            }
        }

        // ICE
        private void button1_Click_2(object sender, EventArgs e)
        {
            // Attempt to update the pokedexCache by updating the local cache
            DatabaseUpdate().GetAwaiter();

            searchResults.Clear();
            // If it fails search for the pokemon in the list 
            foreach (POKEMON poke in pokedexCache)
            {
                // If either the primary or secondary type matches add it to the results
                if (poke.ELEMENT == "ICE" || poke.ELEMENTTWO == "ICE")
                {
                    searchResults.Add(poke);
                }
            }

            // Wipe the list then loop over and add the search results to the list box
            PokedexList.Items.Clear();
            pokedex.Clear();

            foreach (POKEMON poke in searchResults)
            {
                pokedex.Add(poke);
            }

            foreach (POKEMON poke in searchResults)
            {
                PokedexList.Items.Add(poke.ENTRYNUMBER + " " + poke.NAME);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            // Attempt to update the pokedexCache by updating the local cache
            DatabaseUpdate().GetAwaiter();

            searchResults.Clear();

            // Wipe the list then loop over and add the search results to the list box
            PokedexList.Items.Clear();
            pokedex.Clear();

            foreach (POKEMON poke in pokedexCache)
            {
                pokedex.Add(poke);
            }

            foreach (POKEMON poke in pokedex)
            {
                PokedexList.Items.Add(poke.ENTRYNUMBER + " " + poke.NAME);
            }
        }

        private void btn_Dragon_Click(object sender, EventArgs e)
        {
            // Attempt to update the pokedexCache by updating the local cache
            DatabaseUpdate().GetAwaiter();

            searchResults.Clear();

            // If it fails search for the pokemon in the list 
            foreach (POKEMON poke in pokedexCache)
            {
                // If either the primary or secondary type matches add it to the results
                if (poke.ELEMENT == "DRAGON" || poke.ELEMENTTWO == "DRAGON")
                {
                    searchResults.Add(poke);
                }
            }

            // Wipe the list then loop over and add the search results to the list box
            PokedexList.Items.Clear();
            pokedex.Clear();

            foreach (POKEMON poke in searchResults)
            {
                pokedex.Add(poke);
            }

            foreach (POKEMON poke in searchResults)
            {
                PokedexList.Items.Add(poke.ENTRYNUMBER + " " + poke.NAME);
            }

            searchResults = pokedex;
        }

        // FIRE -_-
        private void button1_Click(object sender, EventArgs e)
        {
            // Attempt to update the pokedexCache by updating the local cache
            DatabaseUpdate().GetAwaiter();

            searchResults.Clear();

            // If it fails search for the pokemon in the list 
            foreach (POKEMON poke in pokedexCache)
            {
                // If either the primary or secondary type matches add it to the results
                if (poke.ELEMENT == "FIRE" || poke.ELEMENTTWO == "FIRE")
                {
                    searchResults.Add(poke);
                }
            }

            // Wipe the list then loop over and add the search results to the list box
            PokedexList.Items.Clear();
            pokedex.Clear();

            foreach (POKEMON poke in searchResults)
            {
                pokedex.Add(poke);
            }

            foreach (POKEMON poke in searchResults)
            {
                PokedexList.Items.Add(poke.ENTRYNUMBER + " " + poke.NAME);
            }
        }

        // Flying
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Attempt to update the pokedexCache by updating the local cache
            DatabaseUpdate().GetAwaiter();

            searchResults.Clear();

            // If it fails search for the pokemon in the list 
            foreach (POKEMON poke in pokedexCache)
            {
                // If either the primary or secondary type matches add it to the results
                if (poke.ELEMENT == "FLYING" || poke.ELEMENTTWO == "FLYING")
                {
                    searchResults.Add(poke);
                }
            }

            // Wipe the list then loop over and add the search results to the list box
            PokedexList.Items.Clear();
            pokedex.Clear();

            foreach (POKEMON poke in searchResults)
            {
                pokedex.Add(poke);
            }

            foreach (POKEMON poke in searchResults)
            {
                PokedexList.Items.Add(poke.ENTRYNUMBER + " " + poke.NAME);
            }
        }

        private void btn_Normal_Click(object sender, EventArgs e)
        {
            // Attempt to update the pokedexCache by updating the local cache
            DatabaseUpdate().GetAwaiter();

            searchResults.Clear();
            // If it fails search for the pokemon in the list 
            foreach (POKEMON poke in pokedexCache)
            {
                // If either the primary or secondary type matches add it to the results
                if (poke.ELEMENT == "NORMAL" || poke.ELEMENTTWO == "NORMAL")
                {
                    searchResults.Add(poke);
                }
            }

            // Wipe the list then loop over and add the search results to the list box
            PokedexList.Items.Clear();
            pokedex.Clear();

            foreach (POKEMON poke in searchResults)
            {
                pokedex.Add(poke);
            }

            foreach (POKEMON poke in searchResults)
            {
                PokedexList.Items.Add(poke.ENTRYNUMBER + " " + poke.NAME);
            }
        }

        private void btn_Poison_Click(object sender, EventArgs e)
        {
            // Attempt to update the pokedexCache by updating the local cache
            DatabaseUpdate().GetAwaiter();

            searchResults.Clear();
            // If it fails search for the pokemon in the list 
            foreach (POKEMON poke in pokedexCache)
            {
                // If either the primary or secondary type matches add it to the results
                if (poke.ELEMENT == "POISON" || poke.ELEMENTTWO == "POISON")
                {
                    searchResults.Add(poke);
                }
            }

            // Wipe the list then loop over and add the search results to the list box
            PokedexList.Items.Clear();
            pokedex.Clear();

            foreach (POKEMON poke in searchResults)
            {
                pokedex.Add(poke);
            }

            foreach (POKEMON poke in searchResults)
            {
                PokedexList.Items.Add(poke.ENTRYNUMBER + " " + poke.NAME);
            }
        }

        private void btn_Psychic_Click(object sender, EventArgs e)
        {
            // Attempt to update the pokedexCache by updating the local cache
            DatabaseUpdate().GetAwaiter();

            searchResults.Clear();

            // If it fails search for the pokemon in the list 
            foreach (POKEMON poke in pokedexCache)
            {
                // If either the primary or secondary type matches add it to the results
                if (poke.ELEMENT == "PSYCHIC" || poke.ELEMENTTWO == "PSYCHIC")
                {
                    searchResults.Add(poke);
                }
            }

            // Wipe the list then loop over and add the search results to the list box
            PokedexList.Items.Clear();
            pokedex.Clear();

            foreach (POKEMON poke in searchResults)
            {
                pokedex.Add(poke);
            }

            foreach (POKEMON poke in searchResults)
            {
                PokedexList.Items.Add(poke.ENTRYNUMBER + " " + poke.NAME);
            }
        }

        private void btn_Rock_Click(object sender, EventArgs e)
        {
            // Attempt to update the pokedexCache by updating the local cache
            DatabaseUpdate().GetAwaiter();

            searchResults.Clear();

            // If it fails search for the pokemon in the list 
            foreach (POKEMON poke in pokedexCache)
            {
                // If either the primary or secondary type matches add it to the results
                if (poke.ELEMENT == "ROCK" || poke.ELEMENTTWO == "ROCK")
                {
                    searchResults.Add(poke);
                }
            }

            // Wipe the list then loop over and add the search results to the list box
            PokedexList.Items.Clear();
            pokedex.Clear();

            foreach (POKEMON poke in searchResults)
            {
                pokedex.Add(poke);
            }

            foreach (POKEMON poke in searchResults)
            {
                PokedexList.Items.Add(poke.ENTRYNUMBER + " " + poke.NAME);
            }

        }

        private void btn_Water_Click(object sender, EventArgs e)
        {
            // Attempt to update the pokedexCache by updating the local cache
            DatabaseUpdate().GetAwaiter();

            searchResults.Clear();

            // If it fails search for the pokemon in the list 
            foreach (POKEMON poke in pokedexCache)
            {
                // If either the primary or secondary type matches add it to the results
                if (poke.ELEMENT == "WATER" || poke.ELEMENTTWO == "WATER")
                {
                    searchResults.Add(poke);
                }
            }

            // Wipe the list then loop over and add the search results to the list box
            PokedexList.Items.Clear();
            pokedex.Clear();

            foreach (POKEMON poke in searchResults)
            {
                pokedex.Add(poke);
            }

            foreach (POKEMON poke in searchResults)
            {
                PokedexList.Items.Add(poke.ENTRYNUMBER + " " + poke.NAME);
            }

            searchResults.Clear();
        }

        #endregion

        private void lbl_Description_Click(object sender, EventArgs e)
        {

        }

        private void Pokedex_MouseDown(object sender, MouseEventArgs e)
        {
            // CODE SNIPPET START: http://www.codeproject.com/Articles/11114/Move-window-form-without-Titlebar-in-C
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

            // CODE SNIPPET END!
        }
    }
}
