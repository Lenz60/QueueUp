using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Antrian.View
{
    /// <summary>
    /// Interaction logic for IDMemberWindow.xaml
    /// </summary>
    public partial class IDMemberWindow : Window
    {
        //Deklarasi Constructor
        private Controller.MemberIDController MemberIDController;
        public IDMemberWindow()
        {
            InitializeComponent();
            //Instance
            MemberIDController = new Controller.MemberIDController(this);
            TampilID();
        }
        public void TampilID()
        {
            MemberIDController.SelectMember();
        }
    }
}
