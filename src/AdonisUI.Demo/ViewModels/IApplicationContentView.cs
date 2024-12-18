namespace AdonisUI.Demo.ViewModels
{
    interface IApplicationContentView
    {
        string Name { get; }

        ApplicationNavigationGroup Group { get; }

        bool IsLoading { get; set; }

        void Init();
    }
}
