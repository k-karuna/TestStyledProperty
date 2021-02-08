using System;
using System.Reactive;
using ReactiveUI;

namespace TestStyledProperty.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        private int _currentStep = 0;
        public int CurrentStep
        {
            get => _currentStep;
            set => this.RaiseAndSetIfChanged(ref _currentStep, value);
        }
        
        public void Increase()
        {
            CurrentStep += 1;
        }
    }
}