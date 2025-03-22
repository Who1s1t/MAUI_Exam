using System.Collections.ObjectModel;

namespace Traevel
{
    public partial class MainPage : ContentPage
    {

        int count = 0;
        public ObservableCollection<Traevel.Travel> Travelers { get; set; } = new ObservableCollection<Traevel.Travel> {
            new Traevel.Travel{Mesto="Сочи", Start="15.02.2025", End="20.02.2025", Budget="25000р" },
            new Traevel.Travel{Mesto="Крым", Start="01.04.2025", End="10.04.2025", Budget="35000р" },
            new Traevel.Travel{Mesto="Тбилиси", Start="05.05.2025", End="12.05.2025", Budget="40000р" },
            new Traevel.Travel{Mesto="Ереван", Start="10.06.2025", End="15.06.2025", Budget="30000р" },
            new Traevel.Travel{Mesto="Барселона", Start="20.07.2025", End="28.07.2025", Budget="70000р" },
            new Traevel.Travel{Mesto="Париж", Start="01.08.2025", End="10.08.2025", Budget="80000р" },
            new Traevel.Travel{Mesto="Стамбул", Start="15.09.2025", End="22.09.2025", Budget="45000р" },
            new Traevel.Travel{Mesto="Ницца", Start="01.10.2025", End="08.10.2025", Budget="50000р" },
            new Traevel.Travel{Mesto="Батуми", Start="10.11.2025", End="15.11.2025", Budget="32000р" },
            new Traevel.Travel{Mesto="Хорватия", Start="01.12.2025", End="10.12.2025", Budget="60000р" },
            };

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;

        }
        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            // Логика для обработки данных из формы
            Travelers.Add(new Traevel.Travel { Mesto = Mesto.Text, Start = Start.Text, End = End.Text, Budget = Budget.Text });

            // Здесь может быть ваш код для сохранения данных

            Mesto.Text = Start.Text = End.Text = Budget.Text = "";
            DisplayAlert("Успешно", "Путешествие успешно добавлено", "OK");
        }

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //}
    }

}
