﻿using AdonisUI.Demo.Framework;
using AdonisUI.Demo.ViewModels;

namespace AdonisUI.Demo.Commands
{
    class CollectionSampleAddItemCommand
        : ViewModelCommand<CollectionSampleViewModel>
    {
        public CollectionSampleAddItemCommand(CollectionSampleViewModel contextViewModel) : base(contextViewModel)
        {
        }

        public override void Execute(CollectionSampleViewModel contextViewModel, object parameter)
        {
            contextViewModel.CreateItemInItems();
        }
    }
}
