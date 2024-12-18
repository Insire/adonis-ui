﻿using AdonisUI.Demo.Framework;

namespace AdonisUI.Demo.ViewModels
{
    class Issue5ScenarioViewModel
        : ViewModel
        , IApplicationContentView
    {
        public string Name => "Issue 5";

        public ApplicationNavigationGroup Group => ApplicationNavigationGroup.IssueScenarios;

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
