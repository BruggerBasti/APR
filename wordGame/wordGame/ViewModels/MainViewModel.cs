using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace wordGame.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public string Title => "WordMix";

        // a.
        List<string> _words = new List<string>()
        {
            "mouse", "roof", "door", "word",
            "browser", "desktop", "pencil", "bag",
            "pant", "pen", "ballpen", "ruler"
        };

        string _originalWord = string.Empty;

        Random gen = new Random();

        [ObservableProperty]
        string _word = string.Empty;

        [ObservableProperty]
        string _input = string.Empty;

        [ObservableProperty]
        string _feedback = string.Empty;

        [ObservableProperty]
        int _versuche = 0;

        string MixWord(string word)
        {
            return new String(word.OrderBy(c => gen.Next()).ToArray());
        }

        [RelayCommand]
        void NeuGenerieren()
        {
            int randomWordIndex = gen.Next(0, _words.Count);
            this.Word = this.MixWord(_words[randomWordIndex]);

            this._originalWord = _words[randomWordIndex];
            Versuche++;
        }

        public MainViewModel()
        {
            int randomWordIndex = gen.Next(0, _words.Count);
            this.Word = this.MixWord(_words[randomWordIndex]);

            this._originalWord = _words[randomWordIndex];
        }

        [RelayCommand]
        void Validate()
        {
            if(this.Input == this._originalWord)
            {
                this.Feedback = "Great!";
                int randomWordIndex = gen.Next(0, _words.Count);
                this.Word = this.MixWord(_words[randomWordIndex]);

                this._originalWord = _words[randomWordIndex];

                this.Input = string.Empty;
            }
            else
            {
                this.Feedback = "Oh no - try again!";
                this.Input = string.Empty;
                Versuche++;
            }

            if(_versuche == 3)
            {
                App.Current.MainPage.DisplayAlert("3 Fehler!", "Du hast 3 Fehler erreicht. Das Spiel wird zurückgesetzt.", "OK");
                Versuche = 0;
                this.Input = string.Empty;

                int randomWordIndex = gen.Next(0, _words.Count);
                this.Word = this.MixWord(_words[randomWordIndex]);

                this._originalWord = _words[randomWordIndex];

                this.Feedback = string.Empty;
            }
        }
    }
}

