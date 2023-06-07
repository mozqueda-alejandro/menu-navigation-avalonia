using System.Collections.Generic;
using Avalonia.Controls;
using Material.Icons;

namespace SidebarMenu.ViewModels;

public class ItemMenu
{
    public ItemMenu()
    {
        Header = "";
        SubItems = new List<SubItem>();
        Icon = MaterialIconKind.No;
    }

    public ItemMenu(string header, List<SubItem> subItems, MaterialIconKind icon)
    {
        Header = header;
        SubItems = subItems;
        Icon = icon;
    }

    public ItemMenu(string header, UserControl screen, MaterialIconKind icon)
    {
        Header = header;
        Screen = screen;
        Icon = icon;
    }

    public string Header { get; private set; }
    public MaterialIconKind Icon { get; private set; }
    public List<SubItem> SubItems { get; private set; }
    public UserControl Screen { get; private set; }
}