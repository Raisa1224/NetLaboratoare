using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerData
{
    class Team
    {
        string Name;
        int P;
        int W;
        int L;
        int D;
        int F;
        int A;
        int Pts;

        public Team(string line)
        {
            //split the string in substrings
            //convert each substring to the corresponding format for the data member
            //set the data members' values
        }

        public int GetPointDifference()
        {
            if (this.F >= this.A)
                return this.F - this.A;
            else
                return this.A - this.F;
        }

        public string GetName()
        {
            return this.Name;
        }
    }
}
