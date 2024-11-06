using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewДЗ3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    //Встреча 5 задание 1
    /*    public partial class MainWindow : Window
        {
            public MainWindow()
            {
                InitializeComponent();
            }
            private void SearchButton_Click(object sender, RoutedEventArgs e)
            {
                string searchMask = SearchMaskTextBox.Text;
                string directory = Environment.CurrentDirectory;

                List
    <string> files = new List
        <string>();

                foreach (string file in Directory.GetFiles(directory, searchMask, SearchOption.AllDirectories))
                {
                    files.Add(file);
                }

                SearchResultsListBox.ItemsSource = files;
            }
        }
    }


    namespace SearchApp
    {
        public partial class SearchWindow : Window
        {
            public SearchWindow()
            {
                InitializeComponent();
            }

            private void SearchButton_Click(object sender, RoutedEventArgs e)
            {
                string searchMask = SearchMaskTextBox.Text;
                string directory = Environment.CurrentDirectory;

                List<string> files = new List<string>();

                foreach (string file in Directory.GetFiles(directory, searchMask, SearchOption.AllDirectories))
                {
                    files.Add(file);
                }

                SearchResultsListBox.ItemsSource = files;
            }
        }
    }*/



    /*    //Встреча 5 Задание 2

        // Учёт

        namespace ComputerStore;

        public partial class SalesForm : Window
        {
            private readonly List<Sale> _sales = new List<Sale>();

            public SalesForm()
            {
                InitializeComponent();
                SalesDataGrid.ItemsSource = _sales;
            }

            private void AddSaleButton_Click(object sender, RoutedEventArgs e)
            {
                var sale = new Sale();
                _sales.Add(sale);
                SalesDataGrid.Items.Refresh();
            }

            private void RemoveSaleButton_Click(object sender, RoutedEventArgs e)
            {
                if (SalesDataGrid.SelectedItem is Sale sale)
                {
                    _sales.Remove(sale);
                    SalesDataGrid.Items.Refresh();
                }
            }

            private void SaveSalesButton_Click(object sender, RoutedEventArgs e)
            {
                // Сохранение продаж в базу данных или файл
            }
        }

    //Добавление и редактирование
        namespace ComputerStore;

        public partial class ComponentsForm : Window
        {
            private readonly List<Component> _components = new List<Component>();

            public ComponentsForm()
            {
                InitializeComponent();
                ComponentsDataGrid.ItemsSource = _components;
            }

            private void AddComponentButton_Click(object sender, RoutedEventArgs e)
            {
                var component = new Component();
                _components.Add(component);
                ComponentsDataGrid.Items.Refresh();
            }

            private void EditComponentButton_Click(object sender, RoutedEventArgs e)
            {
                if (ComponentsDataGrid.SelectedItem is Component component)
                {
                    // Отображение диалогового окна для редактирования составляющей
                }
            }

            private void RemoveComponentButton_Click(object sender, RoutedEventArgs e)
            {
                if (ComponentsDataGrid.SelectedItem is Component component)
                {
                    _components.Remove(component);
                    ComponentsDataGrid.Items.Refresh();
                }
            }

            private void SaveComponentsButton_Click(object sender, RoutedEventArgs e)
            {
                // Сохранение составляющих в базу данных или файл
            }
        }

    */


    // Встреча 2 Задание 3
    // Main
    /*    namespace WpfFileDialog
        {
            public partial class MainWindow : Window
            {
                public MainWindow()
                {
                    InitializeComponent();
                }

                private void BtnLoadFile_Click(object sender, RoutedEventArgs e)
                {
                    OpenFileDialog fileDialog = new OpenFileDialog();
                    fileDialog.Filter = "Text Files (*.txt)|*.txt";

                    if (fileDialog.ShowDialog() == true)
                    {
                        txtContent.Text = System.IO.File.ReadAllText(fileDialog.FileName);
                        btnEdit.IsEnabled = true;
                    }
                }

                private void BtnEdit_Click(object sender, RoutedEventArgs e)
                {
                    EditWindow editWindow = new EditWindow(txtContent.Text);
                    editWindow.ShowDialog();

                    if (editWindow.DialogResult == true)
                    {
                        txtContent.Text = editWindow.EditedText;
                    }
                }
            }
        }*/
    //Edit
    /*    namespace WpfFileDialog
        {
            public partial class EditWindow : Window
            {
                private string _originalText;

                public EditWindow(string originalText)
                {
                    InitializeComponent();
                    _originalText = originalText;
                    txtEditedContent.Text = originalText;
                }

                public string EditedText { get; private set; }

                private void BtnSave_Click(object sender, RoutedEventArgs e)
                {
                    EditedText = txtEditedContent.Text;
                    DialogResult = true;
                    Close();
                }

                private void BtnCancel_Click(object sender, RoutedEventArgs e)
                {
                    DialogResult = false;
                    Close();
                }
            }
        }*/

    /* //Встреча 6 задание 1
     namespace TextEditor
     {
         public partial class MainWindow : Window
         {
             private string currentFilePath;

             public MainWindow()
             {
                 InitializeComponent();
             }

             private void NewFile_Click(object sender, RoutedEventArgs e)
             {
                 textEditor.Clear();
                 currentFilePath = null;
                 Title = "Text Editor";
             }

             private void OpenFile_Click(object sender, RoutedEventArgs e)
             {
                 OpenFileDialog openFileDialog = new OpenFileDialog();
                 if (openFileDialog.ShowDialog() == true)
                 {
                     textEditor.Text = File.ReadAllText(openFileDialog.FileName);
                     currentFilePath = openFileDialog.FileName;
                     Title = $"Text Editor - {currentFilePath}";
                 }
             }

             private void SaveFile_Click(object sender, RoutedEventArgs e)
             {
                 if (currentFilePath != null)
                 {
                     File.WriteAllText(currentFilePath, textEditor.Text);
                 }
                 else
                 {
                     SaveAsFile_Click(sender, e);
                 }
             }

             private void SaveAsFile_Click(object sender, RoutedEventArgs e)
             {
                 SaveFileDialog saveFileDialog = new SaveFileDialog();
                 if (saveFileDialog.ShowDialog() == true)
                 {
                     File.WriteAllText(saveFileDialog.FileName, textEditor.Text);
                     currentFilePath = saveFileDialog.FileName;
                     Title = $"Text Editor - {currentFilePath}";
                 }
             }

             private void Exit_Click(object sender, RoutedEventArgs e)
             {
                 Application.Current.Shutdown();
             }

             private void Undo_Click(object sender, RoutedEventArgs e)
             {
                 textEditor.Undo();
             }

             private void Cut_Click(object sender, RoutedEventArgs e)
             {
                 textEditor.Cut();
             }

             private void Copy_Click(object sender, RoutedEventArgs e)
             {
                 textEditor.Copy();
             }

             private void Paste_Click(object sender, RoutedEventArgs e)
             {
                 textEditor.Paste();
             }

             private void SelectAll_Click(object sender, RoutedEventArgs e)
             {
                 textEditor.SelectAll();
             }

             private void EditorOptions_Click(object sender, RoutedEventArgs e)
             {
                 // Открытие окна настроек редактора 
             }

             private void TextEditor_ContextMenuOpening(object sender, ContextMenuEventArgs e)
             {
                 ContextMenu contextMenu = new ContextMenu();

                 MenuItem cutItem = new MenuItem { Header = "Cut" };
                 cutItem.Click += (s, ev) => Cut_Click(s, ev);
                 contextMenu.Items.Add(cutItem);

                 MenuItem copyItem = new MenuItem { Header = "Copy" };
                 copyItem.Click += (s, ev) => Copy_Click(s, ev);
                 contextMenu.Items.Add(copyItem);

                 MenuItem pasteItem = new MenuItem { Header = "Paste" };
                 pasteItem.Click += (s, ev) => Paste_Click(s, ev);
                 contextMenu.Items.Add(pasteItem);

                 MenuItem undoItem = new MenuItem { Header = "Undo" };
                 undoItem.Click += (s, ev) => Undo_Click(s, ev);
                 contextMenu.Items.Add(undoItem);

                 contextMenu.IsOpen = true;
             }
         }
     }*/

    /*    //Встреча 6 Задание 2
        namespace FileExplorer
        {
            public partial class MainWindow : Window
            {
                public MainWindow()
                {
                    InitializeComponent();
                    LoadDrives();
                }

                private void LoadDrives()
                {
                    directoryTree.Items.Clear();
                    foreach (var drive in DriveInfo.GetDrives().Where(d => d.IsReady))
                    {
                        TreeViewItem item = new TreeViewItem
                        {
                            Header = drive.Name,
                            Tag = drive.RootDirectory.FullName
                        };
                        item.Expanded += Item_Expanded;
                        directoryTree.Items.Add(item);
                    }
                }

                private void Item_Expanded(object sender, RoutedEventArgs e)
                {
                    TreeViewItem item = sender as TreeViewItem;
                    if (item != null && (item.Items.Count == 0))
                    {
                        try
                        {
                            string path = item.Tag.ToString();
                            foreach (var dir in Directory.GetDirectories(path))
                            {
                                TreeViewItem subItem = new TreeViewItem
                                {
                                    Header = Path.GetFileName(dir),
                                    Tag = dir
                                };
                                subItem.Expanded += Item_Expanded;
                                item.Items.Add(subItem);
                            }
                        }
                        catch { }
                    }
                }

                private void DirectoryTree_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
                {
                    if (directoryTree.SelectedItem is TreeViewItem item)
                    {
                        string path = item.Tag.ToString();
                        LoadFiles(path);
                    }
                }

                private void LoadFiles(string path)
                {
                    fileList.Items.Clear();
                    try
                    {
                        var directories = Directory.GetDirectories(path);
                        var files = Directory.GetFiles(path);
                        foreach (var dir in directories)
                        {
                            fileList.Items.Add(new ListBoxItem { Content = Path.GetFileName(dir) });
                        }
                        foreach (var file in files)
                        {
                            fileList.Items.Add(new ListBoxItem { Content = Path.GetFileName(file) });
                        }
                    }
                    catch { }
                }

                private void DirectoryTree_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
                {
                    if (directoryTree.SelectedItem is TreeViewItem item)
                    {
                        string path = item.Tag.ToString();
                        LoadFiles(path);
                    }
                }

                private void FileList_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
                {
                    if (fileList.SelectedItem is ListBoxItem selectedItem)
                    {
                        try
                        {
                            string filePath = Path.Combine(GetCurrentPath(), selectedItem.Content.ToString());
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = filePath,
                                UseShellExecute = true
                            });
                        }
                        catch { }
                    }
                }

                private string GetCurrentPath()
                {
                    if (directoryTree.SelectedItem is TreeViewItem item)
                    {
                        return item.Tag.ToString();
                    }
                    return string.Empty;
                }

                private void Open_Click(object sender, RoutedEventArgs e)
                {
                    if (fileList.SelectedItem is ListBoxItem selectedItem)
                    {
                        FileList_MouseDoubleClick(sender, null);
                    }
                }

                private void Exit_Click(object sender, RoutedEventArgs e)
                {
                    Application.Current.Shutdown();
                }

                private void Refresh_Click(object sender, RoutedEventArgs e)
                {
                    LoadDrives();
                }

                private void FileList_ContextMenuOpening(object sender, ContextMenuEventArgs e)
                {
                    ContextMenu contextMenu = new ContextMenu();
                    MenuItem openItem = new MenuItem { Header = "Open" };
                    openItem.Click += Open_Click;
                    contextMenu.Items.Add(openItem);

                    MenuItem refreshItem = new MenuItem { Header = "Refresh" };
                    refreshItem.Click += Refresh_Click;
                    contextMenu.Items.Add(refreshItem);

                    contextMenu.IsOpen = true;
                }
            }
        }*/



    //Встреча 6 Задание 3

    /*
        namespace MenuApp
        {
            public partial class Form1 : Form
            {
                public Form1()
                {
                    InitializeComponent();
                }

                private void btnAddTopLevel_Click(object sender, EventArgs e)
                {
                    // Получаем текст из TextBox для добавления пункта меню верхнего уровня
                    string topLevelMenuText = TopLevelMenu.Text;
                    if (!string.IsNullOrEmpty(topLevelMenuText))
                    {
                        ToolStripMenuItem newItem = new ToolStripMenuItem(topLevelMenuText);
                        menuStrip.Items.Add(newItem);
                        TopLevelMenu.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, введите текст для пункта меню.");
                    }
                }

                private void btnAddSubItem_Click(object sender, EventArgs e)
                {
                    // Получаем текст из TextBox для добавления подменю
                    string subItemText = SubItem.Text;

                    if (!string.IsNullOrEmpty(subItemText) && menuStrip.Items.Count > 0)
                    {
                        // Получаем последний добавленный пункт меню верхнего уровня
                        ToolStripMenuItem lastTopLevelItem = menuStrip.Items[menuStrip.Items.Count - 1] as ToolStripMenuItem;

                        if (lastTopLevelItem != null)
                        {
                            ToolStripMenuItem subItem = new ToolStripMenuItem(subItemText);
                            lastTopLevelItem.DropDownItems.Add(subItem);
                            SubItem.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, выберите пункт меню для добавления подменю или введите текст для подменю.");
                    }
                }
            }
        }*/


    //Встреча 4 Задание 1

 /*   namespace FuelStation
    {
        public partial class MainWindow : Window
        {
            private double totalSales = 0;

            public MainWindow()
            {
                InitializeComponent();
                FuelComboBox.SelectedIndex = 0; // Выбор первого элемента
                UpdatePrice();
                StatusLabel.Content += DateTime.Now.ToString("dddd");
                var timer = new System.Windows.Threading.DispatcherTimer();
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Tick += Timer_Tick;
                timer.Start();
            }

            private void FuelComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                UpdatePrice();
            }

            private void UpdatePrice()
            {
                if (FuelComboBox.SelectedItem is ComboBoxItem selectedFuel)
                {
                    PriceTextBox.Text = selectedFuel.Tag.ToString();
                }
            }

            private void LitersRadioButton_Checked(object sender, RoutedEventArgs e)
            {
                LitersTextBox.IsEnabled = true;
                AmountTextBox.IsEnabled = false;
            }

            private void AmountRadioButton_Checked(object sender, RoutedEventArgs e)
            {
                LitersTextBox.IsEnabled = false;
                AmountTextBox.IsEnabled = true;
            }

            private void Calculate_Click(object sender, RoutedEventArgs e)
            {
                double price = double.Parse(PriceTextBox.Text);
                double result = 0;

                if (LitersRadioButton.IsChecked == true && double.TryParse(LitersTextBox.Text, out double liters))
                {
                    result = liters * price;
                }
                else if (AmountRadioButton.IsChecked == true && double.TryParse(AmountTextBox.Text, out double amount))
                {
                    result = amount / price;
                }

                TotalLabel.Content = $"Итого к оплате: {result:N2} руб.";
                totalSales += result;
                ShowClearFormPrompt();
            }

            private void ShowClearFormPrompt()
            {
                var messageBoxResult = MessageBox.Show("Очистить форму?", "Очистка", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    ClearForms();
                }
            }

            private void ClearForms()
            {
                LitersTextBox.Clear();
                AmountTextBox.Clear();
                TotalLabel.Content = "Итого к оплате:";
                FuelComboBox.SelectedIndex = 0;
                PriceTextBox.Clear();
                UpdatePrice();
            }

            private void CalculateCafe_Click(object sender, RoutedEventArgs e)
            {
                // Здесь будет логика для расчета кафе
                MessageBox.Show("Пока не реализовано!");
            }

            private void ChangeFormColor_Click(object sender, RoutedEventArgs e)
            {
                // Здесь будет логика для изменения цвета формы
            }

            private void ChangeLanguage_Click(object sender, RoutedEventArgs e)
            {
                // Здесь будет логика для изменения языка интерфейса
            }

            private void Timer_Tick(object sender, EventArgs e)
            {
                StatusLabel.Content = $"Текущий день: {DateTime.Now:dddd}, {DateTime.Now:HH:mm:ss}";
            }

        }
    }*/
}
