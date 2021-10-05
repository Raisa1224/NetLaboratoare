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
            
            string[] Columns = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            Name = Columns[1];
            P    = Convert.ToInt32(Columns[2]);
            W    = Convert.ToInt32(Columns[3]);
            L    = Convert.ToInt32(Columns[4]);
            D    = Convert.ToInt32(Columns[5]);
            F    = Convert.ToInt32(Columns[6]);
            A    = Convert.ToInt32(Columns[8]);
            Pts  = Convert.ToInt32(Columns[9]);
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
