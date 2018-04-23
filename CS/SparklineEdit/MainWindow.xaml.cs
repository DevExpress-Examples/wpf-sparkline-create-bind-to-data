using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Windows;

namespace SparklineEdit {

    public partial class MainWindow : Window {

        public IList SourceCollection { get; set; }

        public MainWindow() {
            InitializeComponent();

            grid.DataContext = this;

            GenerateData(7);
        }

        private void GenerateData(int n) {
            SourceCollection = new ObservableCollection<CustomElement>();

            Random rnd = new Random();
            for (int i = 1; i <= n; i++) {
                SourceCollection.Add(new CustomElement() {
                    ArgumentColumn = new DateTime(2000, 1, i),
                    ValueColumn = rnd.Next(20),
                    FilteringColumn = 1
                });
            }

           
        }
    }

    public class CustomElement {
        public object ArgumentColumn { get; set; }
        public int ValueColumn { get; set; }
        public int FilteringColumn { get; set; }
    }


}
