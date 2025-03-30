using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{
    internal class Applicant
    {
        private string _fio;
        private double _avgMark;
        private int _respectMark;
        private int _dateOfSubmission;

       public static bool operator < (Applicant lsd, Applicant rsd)
        {
            if (lsd._avgMark != rsd._avgMark)
            {
                return lsd._avgMark < rsd._avgMark;
            }
                return lsd._respectMark < rsd._respectMark;
        }

        public static bool operator >(Applicant lsd, Applicant rsd)
        {
            if (lsd._avgMark != rsd._avgMark)
            {
                return lsd._avgMark > rsd._avgMark;
            }
            return lsd._respectMark > rsd._respectMark;
        }
    }
}
