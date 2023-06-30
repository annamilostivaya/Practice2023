using coffe.Commands;
using coffe.Models;
using coffe.NavigationServises;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace coffe.ViewModel
{
    public class OrdersVM : ViewModelBase
    {
        public ObservableCollection<Order> orders = new ObservableCollection<Order>();

        public ICommand back { get; }

        private double _total;

        public OrdersVM(NavigationService<ItemsVM> ItemsVM)
        {
            this.back = new NavigateCommand<ItemsVM>(ItemsVM);
        }

        public double Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
            }
        }
    }
}
