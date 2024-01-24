using CrudAvaloniaUI.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace CrudAvaloniaUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        private ViewModelBase _contentViewModel;
        
        private string? _nome;
        private int _idade;

        public ObservableCollection<Pessoas> Pessoas { get; } = new ObservableCollection<Pessoas>();

        public ViewModelBase ViewModelBase 
        {
            get => _contentViewModel;
            private set => this.RaisePropertyChanged(ref _contentViewModel, value);
        }

        private void RaisePropertyChanged(ref ViewModelBase contentViewModel, ViewModelBase value)
        {
            throw new NotImplementedException();
        }

        public string? Nome
        {
            get => _nome;
            set => SetAndRaise(ref _nome, value);
        }

        public int Idade
        {
            get => _idade;
            set => SetAndRaise(ref _idade, value);
        }

        public void Adicionar()
        {
            // Adicionar uma nova pessoa à lista
            Pessoas novaPessoa = new Pessoas
            {
                Nome = Nome,
                Idade = Idade
            };
            Pessoas.Add(novaPessoa);

            // Limpar os campos de entrada
            Nome = "";
            Idade = 0;
        }

        private Pessoas _selectedPessoa;

        public Pessoas SelectedPessoa
        {
            get => _selectedPessoa;
            set => SetAndRaise(ref _selectedPessoa, value);
        }

        public void Excluir()
        {
            if (SelectedPessoa != null)
            {
                Pessoas.Remove(SelectedPessoa);
            }
        }

        private string _textoBusca;


        public string TextoBusca
        {
            get => _textoBusca;
            set => SetAndRaise(ref _textoBusca, value);
        }

        public void Buscar()
        {
            // Lógica para filtrar a lista com base no TextoBusca
            var resultados = Pessoas.Where(p => p.Nome.Contains(TextoBusca)).ToList();

            // Atualiza a lista exibida
            Pessoas.Clear();
            foreach (var pessoa in resultados)
            {
                Pessoas.Add(pessoa);
            }
        }



    }
}
