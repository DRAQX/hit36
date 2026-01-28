using hit36.Properties;

namespace hit36
{
    public partial class mainGameWindow : Form
    {
        public mainGameWindow()
        {
            InitializeComponent();
            MainRunner();
        }
        public void settingsicon_Click(object sender, EventArgs e)
        {
            var settings = new settingsWindow();
            settings.ShowDialog(this);
        }

        private void setPhoto(int which)
        {
            if (which == 1) { showCase.Image = Resources.potato_win; }
            else { showCase.Image = Resources.potato_lose; }
            showCase.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            TestRunner();
        }


        public static int getKeyValue(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string keytext = b.Text;
            int keyval = Convert.ToInt32(keytext);
            return keyval;
        }

        private void keypadOnClick(object sender, EventArgs e)
        {
            int currentTotal = Convert.ToInt32(scoreTracker.Text);
            Button b = (Button)sender;
            string keytext = b.Text;
            int keyval = Convert.ToInt32(keytext);
            int nextTotal = currentTotal + keyval;
            bool end = false;
            string resetact = "";

            switch (nextTotal)
            {
                case < 36:
                    currentTotal = nextTotal;
                    scoreTracker.Text = currentTotal.ToString();
                    scoreTracker.Refresh();
                    b.Enabled = false;
                    break;

                case 36:
                    currentTotal = nextTotal;
                    scoreTracker.Text = currentTotal.ToString();
                    scoreTracker.Refresh();
                    setPhoto(1);
                    streakCount.Text = (Convert.ToInt32(streakCount.Text) + 1).ToString();
                    MessageBox.Show("You successfully Hit36 !", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    end = true;
                    break;

                case > 36:
                    currentTotal = nextTotal;
                    scoreTracker.Text = currentTotal.ToString();
                    end = true;
                    setPhoto(0);
                    streakCount.Text = "0";
                    MessageBox.Show("You missed 36...", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            if (end)
            {
                if (!keepRollin.Checked)
                {
                    keyHolder.Enabled = false;
                    resetact = resetAsk();
                    if (resetact == "Yes") { resetter(); MainRunner(); }
                }
                else { resetter(); MainRunner(); }

            }
        }


        private void resetter()
        {
            var keypad = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button b in keypad)
            {
                b.Enabled = true;
            }
            keyHolder.Enabled = true;

        }
        static string resetAsk()
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to start a new one?", "Restart", MessageBoxButtons.YesNo);
            string respond = dialogResult.ToString();
            return respond;
        }

        private void MainRunner() // Main show
        {
            int keyCount;
            int maxRand, minKeyCount, maxKeyCount, maxKeyValue = 0, maxKeyIndex = 0;
            int rawKeyTotal = 0, normalizedKeyTotal = 0;
            double equilizer;
            double equed;

            minKeyCount = 3;
            maxKeyCount = 6;
            maxRand = 16;

            scoreTracker.Text = "0";
            scoreTracker.Refresh();

            keyHolder.Enabled = true;

            var keypad = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (Button b in keypad)
            {
                b.Enabled = true;
            }

            Random rnd = new Random(); // define what random is
            int[] numbers = new int[9]; // generate array with length of 9
            keyCount = rnd.Next(minKeyCount, maxKeyCount + 1); // define randomly how many to pick as correct

            /* ----------------------------------------------------------- */

            int[] Keys = new int[keyCount]; // construct array in length of correct answers
            for (int i = 0; i < keyCount; i++) // fill keys with random numbers
            {
                Keys[i] = rnd.Next(1, maxRand + 1);
                rawKeyTotal = rawKeyTotal + Keys[i];
            }
            equilizer = ((double)rawKeyTotal / 36.00); // find equilizing ratio
            for (int i = 0; i < keyCount; i++) // normalize array to 36.0
            {
                equed = Keys[i] / equilizer;
                Keys[i] = (int)Math.Round(equed);
                normalizedKeyTotal = normalizedKeyTotal + Keys[i];
            }

            for (int i = 0; i < Keys.Length; i++) // get index of max value in keys
            {
                if (Keys[i] > maxKeyValue)
                {
                    maxKeyValue = Keys[i];
                    maxKeyIndex = i;
                }
            }

            Keys[maxKeyIndex] = Keys[maxKeyIndex] - (GetTotal(Keys) - 36);

            for (int i = 0; i < keyCount; i++) // Assing generated keys to general numbers array
            {
                numbers[i] = Keys[i];
            }

            for (int i = 0; i < (9 - keyCount); i++) // Generate remainning numbers
            {
                numbers[i + keyCount] = rnd.Next(1, maxRand + 1);
            }


            rnd.Shuffle(numbers); // Randomize list order
            rnd.Shuffle(numbers); // Randomize again, just to make sure :)

            for (int i = 0; i < numbers.Length; i++)
            {
                keypad[i].Text = numbers[i].ToString();
            }

        }

        private void TestRunner() // Run to test and see steps
        {
            int keyCount;
            int maxRand, minKeyCount, maxKeyCount, maxKeyValue = 0, maxKeyIndex = 0;
            int rawKeyTotal = 0, normalizedKeyTotal = 0;
            double equilizer;
            double equed;

            minKeyCount = 3;
            maxKeyCount = 6;
            maxRand = 16;

            var keypad = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button b in keypad)
            {
                b.Enabled = true;
            }

            Random rnd = new Random(); // define what random is
            int[] numbers = new int[9]; // generate array with length of 9
            keyCount = rnd.Next(minKeyCount, maxKeyCount + 1); // define randomly how many to pick as correct
            System.Windows.Forms.MessageBox.Show(keyCount.ToString() + " keys generated"); //del

            /* ----------------------------------------------------------- */

            int[] Keys = new int[keyCount]; // construct array in length of correct answers
            System.Windows.Forms.MessageBox.Show(Keys.Length.ToString() + " Keys[] elements."); //del

            for (int i = 0; i < keyCount; i++) // fill keys with random numbers
            {
                Keys[i] = rnd.Next(1, maxRand + 1);
                rawKeyTotal = rawKeyTotal + Keys[i];
                System.Windows.Forms.MessageBox.Show("Assigned Key[" + (i) + "] as: " + Keys[i]); //del
            }
            equilizer = ((double)rawKeyTotal / 36.00); // find equilizing ratio
            System.Windows.Forms.MessageBox.Show("rawKeyTotal total is: " + rawKeyTotal.ToString());
            System.Windows.Forms.MessageBox.Show("Equilizer is: " + equilizer); //sho equilizer
            MessageBox.Show("Raw Max is: " + GetMax(Keys));

            for (int i = 0; i < keyCount; i++) // normalize array to 36.0
            {
                equed = Keys[i] / equilizer;
                Keys[i] = (int)Math.Round(equed);
                normalizedKeyTotal = normalizedKeyTotal + Keys[i];
            }

            MessageBox.Show("Normalized keys adds up to: " + normalizedKeyTotal);
            MessageBox.Show("Current max is: " + GetMax(Keys));

            for (int i = 0; i < Keys.Length; i++) // get index of max value in keys
            {
                if (Keys[i] > maxKeyValue)
                {
                    maxKeyValue = Keys[i];
                    maxKeyIndex = i;
                }
            }

            MessageBox.Show("MaxIndex is: " + maxKeyIndex.ToString());
            for (int i = 0; i < Keys.Length; i++)
            {
                MessageBox.Show("Keys[" + i + "] = " + Keys[i]);
            }

            Keys[maxKeyIndex] = Keys[maxKeyIndex] - (GetTotal(Keys) - 36);
            System.Windows.Forms.MessageBox.Show("Now current max is: " + maxKeyValue.ToString() + " to fit 36"); //del
            MessageBox.Show("Now total of keys is: " + GetTotal(Keys));

            for (int i = 0; i < keyCount; i++) // Assing generated keys to general numbers array
            {
                numbers[i] = Keys[i];
            }

            for (int i = 0; i < (9 - keyCount); i++) // Generate remainning numbers
            {
                numbers[i + keyCount] = rnd.Next(1, maxRand + 1);
            }

            // RANDOMIZE!
            rnd.Shuffle(numbers);
            rnd.Shuffle(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                keypad[i].Text = numbers[i].ToString();
            }

        }

        static int GetMax(int[] arr)
        {
            int maxval = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxval) { maxval = arr[i]; }
            }

            return maxval;
        }

        static int GetTotal(int[] arr)
        {
            int total = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                total = total + arr[i];
            }

            return total;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            resetter();
            MainRunner();
        }

        private void keepRollin_CheckedChanged(object sender, EventArgs e)
        {
            if (keepRollin.Checked) 
            {
                keepRollin.BackColor = Color.Violet;
                keepRollin.Text = "KEEPIN ROLLIN";
            }
            else 
            {
                keepRollin.BackColor = Color.FromArgb(225, 225, 225);
                keepRollin.Text = "Keep me rollin";
            }
        }
    }
}