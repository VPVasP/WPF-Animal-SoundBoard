using System;
using System.Media;
using System.Windows;
using System.Windows.Controls;


namespace Animals_SoundBoard_WPF_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FindButtons();
        }
        private void FindButtons()
        {

           //we find all the cat buttons and assign them
           CatSound1 = (Button)FindName("CatSound1");
           DogSound1 = (Button)FindName("DogSound1");
           MonkeySound1 = (Button)FindName("MonkeySound1");
           HorseSound1 = (Button)FindName("HorseSound1");
           LionSound1 = (Button)FindName("LionSound1");
           DuckSound1 = (Button)FindName("DuckSound1");
           WolfSound1 =(Button)FindName("WolfSound1");
           BearSound1 = (Button)FindName("BearSound1");
           FrogSound1 = (Button)FindName("FrogSound1");
           SnakeSound1 = (Button)FindName("SnakeSound1");
        }
        //play cat sound
        private void PlayCatSound1(object sender, EventArgs e)
        {
            CatSound1 = (Button)sender;
            PlaySoundEffect("CatSound1.wav");
        }
        //play dog sound
        private void PlayDogSound1(object sender, EventArgs e)
        {
            DogSound1= (Button)sender;
            PlaySoundEffect("DogSound1.wav");
        }
        //play monkey sound
        private void PlayMonkeySound1(object sender, EventArgs e)
        {
            MonkeySound1 = (Button)sender;
            PlaySoundEffect("MonkeySound1.wav");
        }
        //play horse sound
        private void PlayHorseSound1(object sender, EventArgs e)
        {
           HorseSound1 = (Button)sender;
           PlaySoundEffect("HorseSound1.wav");
        }
        //play lion sound
        private void PlayLionSound1(object sender, EventArgs e)
        {
            LionSound1 = (Button)sender;
            PlaySoundEffect("LionSound1.wav");
        }
        //play duck sound
        private void PlayDuckSound1(object sender, EventArgs e)
        {
            DuckSound1 = (Button)sender;
            PlaySoundEffect("DuckSound1.wav");
        }
        //play wolf sound
        private void PlayWolfSound1(object sender, EventArgs e)
        {
            WolfSound1 = (Button)sender;
            PlaySoundEffect("WolfSound1.wav");
        }
        //play bear sound
        private void PlayBearSound1(object sender, EventArgs e)
        {
            BearSound1 = (Button)sender;
            PlaySoundEffect("BearSound1.wav");
        }
        //play frog sound
        private void PlayFrogSound1(object sender, EventArgs e)
        {
            FrogSound1 = (Button)sender;
            PlaySoundEffect("FrogSound1.wav");
        }
        //play snake sound
        private void PlaySnakeSound1(object sender, EventArgs e)
        {
            SnakeSound1 = (Button)sender;
            PlaySoundEffect("SnakeSound1.wav");
        }
        //play sound effect function
        private void PlaySoundEffect(string audioClipFilePath)
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = audioClipFilePath;
            soundPlayer.Play();
        }
    }
}
