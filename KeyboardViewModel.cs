using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Windows.Input;

namespace VirtualKeyboardControl
{
    public class KeyboardViewModel : ReactiveObject
    {
        [Reactive] public ObservableCollection<KeyModel> FirstRowKeys { get; set; }
        [Reactive] public ObservableCollection<KeyModel> SecondRowKeys { get; set; }
        [Reactive] public ObservableCollection<KeyModel> ThirdRowKeys { get; set; }
        [Reactive] public ObservableCollection<KeyModel> NumberRowKeys { get; set; }
        [Reactive] public string TextValue { get; set; } = "";

        private readonly ReactiveCommand<object, Unit> _insertCharCommand;
        public ICommand InsertCharCommand => _insertCharCommand;

        private readonly ReactiveCommand<string, Unit> _insertSpecialKeyCommand;
        public ICommand InserSpecialKeyCommand => _insertSpecialKeyCommand;

        public KeyboardViewModel()
        {
            _insertCharCommand = ReactiveCommand.Create<object>(InserChar);
            _insertSpecialKeyCommand = ReactiveCommand.Create<string>(InserSpecialKey);

            FirstRowKeys = new ObservableCollection<KeyModel>()
            {
               new KeyModel(){ KeyValue = "й"},
               new KeyModel(){ KeyValue = "ц"},
               new KeyModel(){ KeyValue = "у"},
               new KeyModel(){ KeyValue = "к"},
               new KeyModel(){ KeyValue = "е"},
               new KeyModel(){ KeyValue = "н"},
               new KeyModel(){ KeyValue = "г"},
               new KeyModel(){ KeyValue = "ш"},
               new KeyModel(){ KeyValue = "щ"},
               new KeyModel(){ KeyValue = "з"},
               new KeyModel(){ KeyValue = "х"},
               new KeyModel(){ KeyValue = "ъ"},
            };

            SecondRowKeys = new ObservableCollection<KeyModel>()
            {
               new KeyModel(){ KeyValue = "ф"},
               new KeyModel(){ KeyValue = "ы"},
               new KeyModel(){ KeyValue = "в"},
               new KeyModel(){ KeyValue = "а"},
               new KeyModel(){ KeyValue = "п"},
               new KeyModel(){ KeyValue = "р"},
               new KeyModel(){ KeyValue = "о"},
               new KeyModel(){ KeyValue = "л"},
               new KeyModel(){ KeyValue = "д"},
               new KeyModel(){ KeyValue = "ж"},
               new KeyModel(){ KeyValue = "э"},
            };

            ThirdRowKeys = new ObservableCollection<KeyModel>()
            {
                new KeyModel(){ KeyValue = "я"},
                new KeyModel(){ KeyValue = "ч"},
                new KeyModel(){ KeyValue = "с"},
                new KeyModel(){ KeyValue = "м"},
                new KeyModel(){ KeyValue = "и"},
                new KeyModel(){ KeyValue = "т"},
                new KeyModel(){ KeyValue = "ь"},
                new KeyModel(){ KeyValue = "б"},
                new KeyModel(){ KeyValue = "ю"},
                new KeyModel(){ KeyValue = "."},
            };

            NumberRowKeys = new ObservableCollection<KeyModel>()
            {
                new KeyModel(){ KeyValue = "ё"},
                new KeyModel(){ KeyValue = "1"},
                new KeyModel(){ KeyValue = "2"},
                new KeyModel(){ KeyValue = "3"},
                new KeyModel(){ KeyValue = "4"},
                new KeyModel(){ KeyValue = "5"},
                new KeyModel(){ KeyValue = "6"},
                new KeyModel(){ KeyValue = "7"},
                new KeyModel(){ KeyValue = "8"},
                new KeyModel(){ KeyValue = "9"},
                new KeyModel(){ KeyValue = "0"},
                new KeyModel(){ KeyValue = "-"},
                new KeyModel(){ KeyValue = "="},
            };
        }

        private void InserSpecialKey(string obj)
        {
            System.Diagnostics.Trace.WriteLine(obj);
            if (obj.Contains("back"))
            {
                if (TextValue.Length > 0)
                {
                    TextValue = TextValue.Remove(TextValue.Length - 1);
                }
            }

            if (obj.Contains("space")) TextValue += " ";
            if (obj.Contains("enter")) TextValue += "\r\n";
        }

        private void InserChar(object ch)
        {
            if (ch != null)
            {
                TextValue += ch;
            }
        }
    }
}
