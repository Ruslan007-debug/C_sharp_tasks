using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Magazine : LibraryItemBase
    {
        public int IssueNumber { get; set; }
        public Magazine(string title, int year, int issueNumber) : base(title, year)
        {
            IssueNumber = issueNumber;
        }

        public override string GetItemType()
        {
            return "Magazine";
        }

        public override string GetDisplayInfo()
        {
            var s = base.GetDisplayInfo() + " " + $"IssueNumber: {IssueNumber}";
            return s;
        }
    }
}
