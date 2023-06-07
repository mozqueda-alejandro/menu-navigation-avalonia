using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SidebarMenu.ViewModels;

namespace SidebarMenu.Views;

public partial class UserControlMenuItem : UserControl
{
    public UserControlMenuItem()
    {
        InitializeComponent();
    }
    
    public void InitUserControlMenuItem(ItemMenu itemMenu)
    {
        var expanderMenu = this.FindControl<Expander>("ExpanderMenu");
        expanderMenu.IsVisible = itemMenu.SubItems == null ? false : true;
        var listViewItemMenu = this.FindControl<ListBoxItem>("ListViewItemMenu");
        listViewItemMenu.IsVisible = itemMenu.SubItems == null ? true : false;
        this.DataContext = itemMenu;
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}