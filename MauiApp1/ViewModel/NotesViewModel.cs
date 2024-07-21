using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiApp1.ViewModel
{
    public partial class NotesViewModel : BaseViewModel
    {
        public ObservableCollection<string> Notes { get; } = new ObservableCollection<string>();

        [ObservableProperty]
        private string newNote;

        [RelayCommand]
        private void AddNote()
        {
            if (!string.IsNullOrEmpty(NewNote))
            {
                Notes.Add(NewNote);
                NewNote = string.Empty;
            }
        }

        [RelayCommand]
        private void DeleteNote(string note)
        {
            if (Notes.Contains(note))
            {
                Notes.Remove(note);
            }
        }
    }
}

