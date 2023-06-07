using System.Collections.Generic;
using Avalonia.Controls;
using Material.Icons;
using SidebarMenu.ViewModels;
using SidebarMenu;

namespace SidebarMenu.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();


        var item0 = new ItemMenu("Dashboard", new UserControl(), MaterialIconKind.ViewDashboard);

        var menuSchedule = new List<SubItem>();
        menuSchedule.Add(new SubItem("Services"));
        menuSchedule.Add(new SubItem("Meetings"));
        var item1 = new ItemMenu("Appointments", menuSchedule, MaterialIconKind.Schedule);

        var menuReports = new List<SubItem>();
        menuReports.Add(new SubItem("Customers"));
        menuReports.Add(new SubItem("Providers"));
        menuReports.Add(new SubItem("Products"));
        menuReports.Add(new SubItem("Stock"));
        menuReports.Add(new SubItem("Sales"));
        var item2 = new ItemMenu("Reports", menuReports, MaterialIconKind.FileReport);

        var menuExpenses = new List<SubItem>();
        menuExpenses.Add(new SubItem("Fixed"));
        menuExpenses.Add(new SubItem("Variable"));
        var item3 = new ItemMenu("Expenses", menuExpenses, MaterialIconKind.ShoppingBasket);

        var menuFinancial = new List<SubItem>();
        menuFinancial.Add(new SubItem("Cash flow"));
        var item4 = new ItemMenu("Financial", menuFinancial, MaterialIconKind.ScaleBalance);

        var menuRegister = new List<SubItem>();
        menuRegister.Add(new SubItem("Customer"));
        menuRegister.Add(new SubItem("Providers"));
        menuRegister.Add(new SubItem("Employees"));
        menuRegister.Add(new SubItem("Products"));
        var item6 = new ItemMenu("Register", menuRegister, MaterialIconKind.Register);
        
        
        var menu = this.FindControl<StackPanel>("Menu");
        
        var userControl0 = new UserControlMenuItem();
        userControl0.InitUserControlMenuItem(item0);
        menu.Children.Add(userControl0);
        
        var userControl1 = new UserControlMenuItem();
        userControl1.InitUserControlMenuItem(item1);
        menu.Children.Add(userControl1);
        
        var userControl2 = new UserControlMenuItem();
        userControl2.InitUserControlMenuItem(item2);
        menu.Children.Add(userControl2);
        
        var userControl3 = new UserControlMenuItem();
        userControl3.InitUserControlMenuItem(item3);
        menu.Children.Add(userControl3);
        
        var userControl4 = new UserControlMenuItem();
        userControl4.InitUserControlMenuItem(item4);
        menu.Children.Add(userControl4);
        
        var userControl6 = new UserControlMenuItem();
        userControl6.InitUserControlMenuItem(item6);
        menu.Children.Add(userControl6);
    }
}