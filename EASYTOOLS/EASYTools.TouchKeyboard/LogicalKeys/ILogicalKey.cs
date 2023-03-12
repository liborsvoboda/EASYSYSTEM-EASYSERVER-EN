using System.ComponentModel;

namespace EASYTools.LogicalKeys
{
    public interface ILogicalKey : INotifyPropertyChanged
    {
        string DisplayName { get; }
        void Press();
        event LogicalKeyPressedEventHandler LogicalKeyPressed;
    }
}