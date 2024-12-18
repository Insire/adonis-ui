﻿using AdonisUI.Demo.Framework;

namespace AdonisUI.Demo.ViewModels
{
    class ToolBarReferenceViewModel
        : ViewModel
        , IApplicationContentView
    {
        public string Name => "Tool Bars";

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
