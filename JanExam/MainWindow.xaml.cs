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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JanExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Member> MembersList = new List<Member>();
        Member selectedItem = new Member();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Member m1 = new Member("Bobby Quinn", new DateTime(2014, 12, 1),750);
            Member m2 = new Member("Cian Daly", new DateTime(2013, 06, 12), 630);
            Member m3 = new Member("Daniel Ryan", new DateTime(2012,07,14), 500);
            Member m4 = new Member("Ella Doyle", new DateTime(2013, 11,12), 890);
            Member m5 = new Member("Emily Kelly", new DateTime(2016,12,10), 800);
            Member m6 = new Member("Eva Gallagher", new DateTime(2018,02,24), 770);
            Member m7 = new Member("Fion Kennedy", new DateTime(2013, 12, 8), 900);
            Member m8 = new Member("Jake Murphy", new DateTime(2013, 06, 12), 400);
            Member m9 = new Member("Louis Moore", new DateTime(2007,10,10), 785);

            m1.membertype = Member.MemberType.Senior;
            m1.paymentSchedule = Member.PaymentSchedule.Biannual;
            m2.membertype = Member.MemberType.Senior;
            m2.paymentSchedule = Member.PaymentSchedule.Biannual;
            m3.membertype = Member.MemberType.Senior;
            m3.paymentSchedule = Member.PaymentSchedule.Biannual;
            m4.membertype = Member.MemberType.Junior;
            m4.paymentSchedule = Member.PaymentSchedule.Annual;
            m5.membertype = Member.MemberType.Junior;
            m5.paymentSchedule = Member.PaymentSchedule.Annual;
            m6.membertype = Member.MemberType.Junior;
            m6.paymentSchedule = Member.PaymentSchedule.Annual;
            m7.membertype = Member.MemberType.Regular;
            m7.paymentSchedule = Member.PaymentSchedule.Monthly;
            m8.membertype = Member.MemberType.Regular;
            m8.paymentSchedule = Member.PaymentSchedule.Monthly;
            m9.membertype = Member.MemberType.Regular;
            m9.paymentSchedule = Member.PaymentSchedule.Monthly;

            MembersList.Add(m1);
            MembersList.Add(m2);
            MembersList.Add(m3);
            MembersList.Add(m4);
            MembersList.Add(m5);
            MembersList.Add(m6);
            MembersList.Add(m7);
            MembersList.Add(m8);
            MembersList.Add(m9);

            LstBoxMemberList.ItemsSource = MembersList;
        }

        private void LstBoxMemberList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedItem = (Member)LstBoxMemberList.SelectedItem;
            
            txtBlockMemberDetails.Text = 
            
        }
    }
}
