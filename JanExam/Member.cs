using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanExam
{
    public class Member
    {
        //Properties
        public string name { get; set; }
        public DateTime JoinDate { get; set; }
        public PaymentSchedule paymentSchedule { get; set; }
        public MemberType membertype { get; set; }
        public double fee { get; set; }
       
        public enum MemberType
        {
            Regular,
            Senior,
            Junior
        }
        public enum PaymentSchedule
        {
            Annual,
            Biannual,
            Monthly
        }
        
        public Member()
        {

        }
        public Member(string Name, DateTime joinDate, double Fee)
        {
            name = Name;
            JoinDate = joinDate;
            fee = Fee;
        }

        public override string ToString()
        {
            return $"{name}";
        }
        public string displayDetails(Member SelectedItems)
        {
            string displayInfo;
            displayInfo = $"{SelectedItems.name}\nJoin date: {SelectedItems.JoinDate}\nBasic Fee: {SelectedItems.fee}";
            return displayInfo;
        }
    }
}
