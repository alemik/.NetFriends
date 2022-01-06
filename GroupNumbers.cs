using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETfriends
{
    internal class GroupNumbers
    {
        List<int> sourceNumbers;

        Dictionary<string, List<int>> Founded = new Dictionary<string, List<int>>();
        Dictionary<string, List<int>> Unfounded = new Dictionary<string, List<int>>();
        List<int> currentGroup;

        public GroupNumbers()
        {
            sourceNumbers = new List<int> { 1, 2, 3, 4, 12, 13, 14, 15, 21, 22, 23, 24, 25 };
            
            bool foundActive = false;
            bool notFoundActive = false;

            for (int i = 0; i < 30; i++)
            {
                if (sourceNumbers.Contains(i))
                {
                    notFoundActive = false;
                    if (foundActive)
                    {
                        currentGroup.Add(i);
                    }
                    if (!foundActive)
                    {
                        currentGroup = new List<int>();
                        Founded.Add("Group"+i, currentGroup); //Crea nuovo gruppo
                        foundActive=true;
                        currentGroup.Add(i);
                    }
                }
                else
                {
                    foundActive = false;
                    if (notFoundActive)
                    {
                        currentGroup.Add(i);
                    }
                    if (!notFoundActive)
                    {
                        currentGroup = new List<int>();
                        Unfounded.Add("Group" + i, currentGroup); //Crea nuovo gruppo
                        notFoundActive = true;
                        currentGroup.Add(i);
                    }
                }
            }
        }
    }
}