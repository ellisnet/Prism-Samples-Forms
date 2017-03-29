using Prism.Commands;
using Prism.Mvvm;
using UsingDependencyService.Services;

namespace UsingDependencyService.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private readonly ITextToSpeech _textToSpeech;

        private string _textToSay = "Hello from Xamarin Forms and Prism.";
        public string TextToSay
        {
            get { return _textToSay; }
            set { SetProperty(ref _textToSay, value); }
        }

        public DelegateCommand SpeakCommand { get; set; }

        //TODO: This constructor fails with Prism.Autofac.Forms - I don't think it is capable of 
        //  resolving dependencies via the Xamarin.Forms DependencyService
        public MainPageViewModel(ITextToSpeech textToSpeech)
        {
            _textToSpeech = textToSpeech;
            SpeakCommand = new DelegateCommand(Speak);
        }

        //Adding this constructor appears to fix the problem.
        public MainPageViewModel() : this(Xamarin.Forms.DependencyService.Get<ITextToSpeech>())
        { }

        private void Speak()
        {
            _textToSpeech.Speak(TextToSay);
        }
    }
}
