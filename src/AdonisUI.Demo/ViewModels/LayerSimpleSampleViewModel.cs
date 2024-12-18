﻿using AdonisUI.Demo.Framework;

namespace AdonisUI.Demo.ViewModels
{
    class LayerSimpleSampleViewModel
        : ViewModel
        , IApplicationContentView
    {
        public string Name => "Layers";

        public ApplicationNavigationGroup Group => ApplicationNavigationGroup.Samples;

        private bool _isLoading;

        public bool IsLoading
        {
            get => _isLoading;
            set => SetProperty(ref _isLoading, value);
        }

        public void Init()
        {
        }
    }
}
