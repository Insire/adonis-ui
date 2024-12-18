﻿using AdonisUI.Demo.Framework;

namespace AdonisUI.Demo.ViewModels
{
    class LoadingReferenceViewModel
        : ViewModel
        , IApplicationContentView
    {
        public string Name => "Loading";

        public ApplicationNavigationGroup Group => ApplicationNavigationGroup.Reference;

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
